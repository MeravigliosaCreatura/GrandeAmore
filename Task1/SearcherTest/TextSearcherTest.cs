using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextSearcherTxt;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SearcherTest
{
    [TestClass]
    public class TextSearcherTest
    {
        [TestMethod]
        public void TestGetFilesMethodInTextSearcher()
        {
            TextSearcherTxt.PictureSearcher ts = new TextSearcherTxt.PictureSearcher();
            TableLayoutPanel tb = new TableLayoutPanel();
            List<FileInfo> f1 = new List<FileInfo>();
            ts.Substring = String.Empty;
            FileInfo file1 = new FileInfo("text.txt");
            FileInfo file2 = new FileInfo("text2.docx");
            f1.Add(file1);
            f1.Add(file2);
            List<FileInfo> expected = new List<FileInfo>();
            expected.Add(file1);
            List<FileInfo> actual = ts.getFiles(tb, f1);
            CollectionAssert.AreEqual(expected, actual);
        }
        
    }
}
