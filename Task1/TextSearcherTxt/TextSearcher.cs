using PluginInterface;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TextSearcherTxt
{
    public class PictureSearcher : IPerfectSearcher
    {
        private TextSearcherUserControl tc;
        private string extension = ".txt";
        public string Substring { get; set; }
        public string Name
        {
            get { return "Text Searcher"; }
        }

        public void AddFunctionality(Panel c)
        {
            tc = new TextSearcherUserControl();
            c.Controls.Add(tc);
        }

        public void Dispose()
        {
           
        }

        public List<FileInfo> getFiles(List<FileInfo> files)
        {
            var textbox = tc.Controls["textBox1"];
            if(textbox!=null)
            {
                Substring = textbox.Text;
            }
           
            List<FileInfo> textFiles = new List<FileInfo>();
            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.Name.Contains(Substring) && file.Extension.Equals(extension))
                    {
                        textFiles.Add(file);
                    }
                }

            }
            return textFiles;
        }

    }
}
