using PluginInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSearcherTxt
{
    public class PictureSearcher : IPerfectSearcher
    {
        private string extension = ".txt";
        public string Substring { get; set; }
        public string Name
        {
            get { return "Text Searcher"; }
        }

        public void AddFunctionality(TableLayoutPanel c)
        {
            Label l = new Label();
            l.Name = "substringLabel";
            l.Text = "Подстрока";
            TextBox tb = new TextBox();
            tb.Name = "textBoxSubstr";
            c.Controls.Add(l);
            c.Controls.Add(tb);

        }

        public List<FileInfo> getFiles(TableLayoutPanel c, List<FileInfo> files)
        {
          
            var textbox = c.Controls["textBoxSubstr"];
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
