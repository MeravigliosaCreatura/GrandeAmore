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
        private string[] extension = { ".png", ".jpg" };
        private int Width { get; set; }
        private int Height { get; set; }
        public string Name
        {
            get { return "Picture Searcher"; }
        }
       
        public List<FileInfo> getFiles(TableLayoutPanel c, List<FileInfo> files)
        {
            NumericUpDown numericUpDownWidth =  (NumericUpDown)c.Controls["imageWidth"];
            NumericUpDown numericUpDownHeight = (NumericUpDown)c.Controls["imageHeight"];
            CheckBox dimSearch = (CheckBox)c.Controls["dimSearch"];
            if((numericUpDownHeight!=null) && (numericUpDownHeight!=null))
            {
                Width = (int)numericUpDownWidth.Value;
                Height = (int)numericUpDownHeight.Value;
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
                                if (dimSearch!= null && dimSearch.Checked)
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

        public void AddFunctionality(TableLayoutPanel c)
        {

            CheckBox dim = new CheckBox();
            dim.Name = "dimSearch";
            dim.Text = "Размер";
            Label widthLabel = new Label();
            widthLabel.Name = "widthLabel";
            widthLabel.Text = "Ширина";
            Label heightLabel = new Label();
            heightLabel.Text = "Высота";
            heightLabel.Name = "heightLabel";
            heightLabel.Location = new Point(25, widthLabel.Location.Y - widthLabel.Height);
            NumericUpDown imageWidth = new NumericUpDown();
            imageWidth.Name = "imageWidth";
            imageWidth.Maximum = 5000;
            NumericUpDown imageHeight = new NumericUpDown();
            imageHeight.Name = "imageHeight";
            imageHeight.Maximum = 5000;
            imageHeight.Location = new Point(heightLabel.Width, imageWidth.Location.Y - imageWidth.Height);
            c.Controls.Add(dim);
            c.Controls.Add(heightLabel);
            c.Controls.Add(imageHeight);
            c.Controls.Add(widthLabel);
            c.Controls.Add(imageWidth);
        }
    }
}
