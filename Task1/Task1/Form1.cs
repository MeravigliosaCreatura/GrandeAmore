using PluginInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private DirectoryInfo df;
        private string folderPath = string.Empty;
        private List<FileInfo> files;
        private readonly string extension = "*";
        private List<String> attributes { get; set; }
        private bool IsSubfolderSearch { get; set; }
        private DateTime DateTo { get; set; }
        private DateTime DateFrom { get; set; }
        private double SizeFrom { get; set; }
        private double SizeTo { get; set; }
        private delegate void AddListItem(String fileName);
        private AddListItem AddDelegate;
        private delegate void AddComboBoxItem(String pluginName);
        private AddComboBoxItem AddComboBoxItemDelegate;
        private int index;
        private IPerfectSearcher searcher;
        private List<IPerfectSearcher> plugins = new List<IPerfectSearcher>();
        private FileSystemWatcher watcher;
        private CancellationTokenSource cancelTokenSource;
        private CancellationToken token;

        public Form1()
        {
            InitializeComponent();
        }

      
        private void LoadPlugins()
        {
            AddComboBoxItemDelegate = new AddComboBoxItem(AddComboBoxItemMethod);
            if (plugins.Count > 0)
            {
                plugins.Clear();
                pluginsComboBox.Invoke(new MethodInvoker(delegate { pluginsComboBox.Items.Clear(); }));
                pluginsComboBox.Invoke(new MethodInvoker(delegate { pluginsComboBox.Text = string.Empty; }));
                panel1.Invoke(new MethodInvoker(delegate { panel1.Controls.Clear(); }));
            }

            DirectoryInfo df = new DirectoryInfo(@".\plugins");
            foreach (var file in df.GetFiles("*.dll", SearchOption.TopDirectoryOnly).ToList())
            {
                try
                {
                    Assembly assembly = Assembly.Load(File.ReadAllBytes(file.FullName));
                    foreach (var type in assembly.GetTypes())
                    {
                        if (type.GetInterfaces().Contains(typeof(IPerfectSearcher)))
                        {
                            searcher = Activator.CreateInstance(type) as IPerfectSearcher;
                            plugins.Add(searcher);
                            pluginsComboBox.Invoke(AddComboBoxItemDelegate, new Object[] { searcher.Name });
                        }
                    }
                }
                catch (FileNotFoundException) { }
                catch (IOException) { }
                
            }

           
        }

        
        private void Open_Click(object sender, EventArgs e)
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

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void Run()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = @".\plugins";
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName;
            watcher.Filter = "*.dll";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        private  void OnChanged(object sender, FileSystemEventArgs e)
        {
            LoadPlugins();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnCount = 1;
            numericUpTo.Maximum = 10000000;
            numericUpFrom.Maximum = 10000000;
            numericUpTo.Value = numericUpTo.Maximum;
            datePickerFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            LoadPlugins();
            Run();

            
        }
        public void Check(CancellationToken token)
        {
            foreach (var file in files)
            {
                if (token.IsCancellationRequested) { break; }
                CheckFile(file);
                Thread.Sleep(100);
            }
            search_btn.Invoke(new MethodInvoker(delegate { search_btn.Enabled = true; }));
            stop_btn.Invoke(new MethodInvoker(delegate { stop_btn.Enabled = false; }));
            pictureBox1.Invoke(new MethodInvoker(delegate { pictureBox1.Visible = false; }));

        }


        public void AddComboBoxItemMethod(String pluginName)
        {
            pluginsComboBox.Items.Add(pluginName);
        }

        public void AddListItemMethod(String fileName)
        {
            resultList.Items.Add(fileName);
        }
        private void CheckFile(FileInfo file)
        {
            Checker checker = new Checker();
            FileInfo chosenfile = file;
            if (dateCheckBox.Checked)
            {
                chosenfile = checker.CheckFileDate(file, DateFrom, DateTo);
            }
            if (sizeCheckBox.Checked)
            {
                chosenfile = checker.CheckFileSize(chosenfile, SizeFrom, SizeTo);
              
            }
            if(readOnlycheckBox.Checked)
            {
                chosenfile = checker.CheckFileAttributeIsReadOnly(chosenfile);
              
            }
            if (hiddenCheckBox.Checked)
            {
                chosenfile = checker.CheckFileAttributeIsHidden(chosenfile);
            }

            if (chosenfile == null)
            {
                return;
            }

            else { resultList.Invoke(AddDelegate, new Object[] { chosenfile.Name }); }
            
        }
        private  void Search_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(folderPath))
            {
                IsSubfolderSearch = subfolderCheckBox.Checked;
                DateTo = datePickerTo.Value;
                DateFrom = datePickerFrom.Value;
                SizeTo = (double)numericUpTo.Value;
                SizeFrom = (double)numericUpFrom.Value;
                search_btn.Enabled = false;
                stop_btn.Enabled = true;
                pictureBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Выберите папку");
            }
            GetAllFiles();
            Search();


        }

        private List<FileInfo> GetAllFiles()
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
           
            if (PluginCheckBox.Checked && pluginsComboBox.SelectedItem!=null)
            {
                files = plugins[index].getFiles(files);
            }

            return files;
        }

        private void Search()
        {
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
            AddDelegate = new AddListItem(AddListItemMethod);
            if (files != null)
            {
                resultList.Items.Clear();
                Task task1 = new Task(() => Check(token));
                task1.Start();
            }
            
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            stop_btn.Enabled = false;
            search_btn.Enabled = true;
            pictureBox1.Visible = false;
            cancelTokenSource.Cancel();
        }

        private void pluginsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            index = pluginsComboBox.SelectedIndex;
            var plugin = plugins[index];
            plugin.AddFunctionality(panel1);
        }

        private void PluginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PluginCheckBox.Checked)
            {
                pluginsComboBox.Enabled = true;
            }
            else
            {
                pluginsComboBox.Enabled = false;
            }
        }
    }
}
