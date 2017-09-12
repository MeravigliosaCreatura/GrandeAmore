using PluginInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Thread myThread;
        private DirectoryInfo df;
        string folderPath = string.Empty;
        List<FileInfo> files;
        private readonly string extension = "*";
        private DateTime date { get; set; }
        private double size { get; set; }
        private List<String> attributes { get; set; }
        private bool IsSubfolderSearch { get; set; }
        private DateTime DateTo { get; set; }
        private DateTime DateFrom { get; set; }
        private double SizeFrom { get; set; }
        private double SizeTo { get; set; }
        private delegate void AddListItem(String fileName);
        private AddListItem addDelegate;
        IPerfectSearcher searcher;
        

        public Form1()
        {
            InitializeComponent();

        }
       
        private  void loadPlugin()
        {
            foreach (var file in Directory.GetFiles(@".\plugins", "*.dll"))
            {
                var assembly = Assembly.Load(File.ReadAllBytes(Directory.GetCurrentDirectory() + file));
                foreach (var type in assembly.GetTypes())
                {
                    if (type.GetInterfaces().Contains(typeof(IPerfectSearcher)))
                    {
                        searcher = Activator.CreateInstance(type) as IPerfectSearcher;
                        searcher.AddFunctionality(tableLayoutPanel1);
                        checkBox1.Visible = true;
                        checkBox1.Text = searcher.Name;
                        return;

                    }
                }
            }
           
        }

     
        private void open_Click(object sender, EventArgs e)
        {
           
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Выберите каталог";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    folderPathLabel.Text = dlg.SelectedPath;
                    folderPath = dlg.SelectedPath;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnCount = 1;
            numericUpTo.Maximum = 10000000;
            numericUpFrom.Maximum = 10000000;
            numericUpTo.Value = numericUpTo.Maximum;
            datePickerFrom.Value = new DateTime(2017, 1, 1);
            loadPlugin();
       
        }

        public void Check()
        {
            foreach (var file in files.ToList())
            {
                checkFile(file);
                Thread.Sleep(100);
            }
        }


      

        public void AddListItemMethod(String fileName)
        {
            resultList.Items.Add(fileName);
        }
        private void checkFile(FileInfo file)
        {

            date = file.CreationTime;
            size = file.Length / 1024;
            bool dateCondition = (DateTime.Compare(date, DateFrom) >= 0) && (DateTime.Compare(date, DateTo) <= 0);
            bool sizeCondition = (SizeFrom <= size) && (size <= SizeTo);
            bool atributesCondition = false;

            FileAttributes fileAttributes = File.GetAttributes(file.FullName);
            
            if(readOnlycheckBox.Checked||hiddencheckBox.Checked)
            {
                if((fileAttributes & FileAttributes.Hidden)== FileAttributes.Hidden ||((fileAttributes & FileAttributes.ReadOnly)) == FileAttributes.ReadOnly)
                {
                    atributesCondition = true;
                }
                if (sizeCondition && dateCondition && atributesCondition)
                {

                    resultList.Invoke(addDelegate, new Object[] { file.Name });
                }

            }
            else
            {
                if (sizeCondition && dateCondition )
                {
                     resultList.Invoke(addDelegate, new Object[] { file.Name });
                }
            }
            
        }
        private void search_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(folderPath))
            {

                IsSubfolderSearch = subfolderCheckBox.Checked;
                DateTo = datePickerTo.Value;
                DateFrom = datePickerFrom.Value;
                SizeTo = (double)numericUpTo.Value;
                SizeFrom = (double)numericUpFrom.Value;

            }
            else
            {
                MessageBox.Show("Выберите папку");
            }

            getAllFiles();
            Search();

        }

        private List<FileInfo> getAllFiles()
        {
            if (!String.IsNullOrEmpty(folderPath))
            {
                df = new DirectoryInfo(folderPath);
            }

            if (df != null)
            {
                try
                {
                    if (IsSubfolderSearch)
                    {
                        files = df.GetFiles(extension, SearchOption.AllDirectories).ToList();
                    }
                    else
                    {
                        files = df.GetFiles(extension, SearchOption.TopDirectoryOnly).ToList();
                    }
                }
                catch (Exception) { }
            }
            if (checkBox1.Checked)
            {
                files = searcher.getFiles(tableLayoutPanel1, files);
            }
            return files;
        }

        private void Search()
        {
            addDelegate = new AddListItem(AddListItemMethod);
            if (files != null)
            {

                resultList.Items.Clear();
                myThread = new Thread(new ThreadStart(Check));
                myThread.Start();

            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            myThread.Abort();
        }


        private void buttonPlugin_Click(object sender, EventArgs e)
        {
            files = searcher.getFiles(tableLayoutPanel1, getAllFiles());
            Search();
        }


    }
}
