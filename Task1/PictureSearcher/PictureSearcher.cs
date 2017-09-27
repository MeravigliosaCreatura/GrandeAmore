using PluginInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace PictureSearcher
{
    public class PictureSearcher : IPerfectSearcher
    {
        private PictureSearcherUserControl pc;
        private string[] extension = { ".png", ".jpg" };
        private int Width { get; set; }
        private int Height { get; set; }
        public string Name
        {
            get { return "Picture Searcher"; }
        }
       
        public List<FileInfo> getFiles(List<FileInfo> files)
        {
            NumericUpDown imageWidth =  (NumericUpDown)pc.Controls["WidthNumericUpDown"];
            NumericUpDown imageHeight = (NumericUpDown)pc.Controls["HeightNumericUpDown"];
            CheckBox sizeCheckBox = (CheckBox)pc.Controls["SizeCheckBox"];
            if (imageHeight!=null && imageWidth!=null)
            {
                Width = (int)imageWidth.Value;
                Height = (int)imageHeight.Value;
            }
          
            List<FileInfo> images = new List<FileInfo>();
            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.Exists)
                    {
                        if (file.Extension.Equals(extension[0]) || file.Extension.Equals(extension[1]))
                        {
                            try
                            {
                                var img = Image.FromFile(file.FullName);
                                if (sizeCheckBox != null && sizeCheckBox.Checked)
                                {
                                    if (img.Height == Height && img.Width == Width)
                                    {
                                        images.Add(file);
                                    }
                                }
                                else
                                {
                                    images.Add(file);
                                }

                            }
                            catch (OutOfMemoryException)
                            {

                            }
                        }
                    }
                    
                }
            }
            return images;
        }

        public void AddFunctionality(Panel panel)
        {
            pc = new PictureSearcherUserControl();
            panel.Controls.Add(pc);
        }

        public void Dispose()
        {
            
        }
    }
}
