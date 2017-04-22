using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordFrequency
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FontSize = 15;
        }

        string text = string.Empty;
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt*)|*.txt*";
            
            if (openFileDialog.ShowDialog() == true)
            {
                text = File.ReadAllText(openFileDialog.FileName,Encoding.Default);
            }
        }

        private void ShowResult_Click(object sender, RoutedEventArgs e) 
        {
            if (text!=string.Empty)
            {
                WordFrequency wf = new WordFrequency(text);
                wordsList.ItemsSource = wf.countToPoint().OrderByDescending(z => z.Count).Take(10);
            }
        }
        private void СloseWindow_Click(object sender, RoutedEventArgs e) 
        {
            this.Close();
        }
       
    }
}
