using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SearcherTest
{
    [TestClass]
    public class PictureSearcherTest
    {
        [TestMethod]
        public void TestGetFilesMethodInPictureSearcher()
        {
            PictureSearcher.PictureSearcher ps = new PictureSearcher.PictureSearcher();
            TableLayoutPanel tb = new TableLayoutPanel();
            List<FileInfo> f1 = new List<FileInfo>();
            FileInfo file1 = new FileInfo("ru.png");
            FileInfo file2 = new FileInfo("5.xml");
            FileInfo file3 = new FileInfo("7.json");
            FileInfo file4 = new FileInfo("7.txt");
            f1.Add(file1);
            f1.Add(file2);
            f1.Add(file3);
            f1.Add(file4);
            List<FileInfo> expected = new List<FileInfo>();
            expected.Add(file1);
            List<FileInfo> actual = ps.getFiles(f1);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
