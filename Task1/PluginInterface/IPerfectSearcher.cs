using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PluginInterface
{
    public interface IPerfectSearcher
    {
     
        String Name { get; }
        void AddFunctionality(Panel c);
        List<FileInfo> getFiles(List<FileInfo> files);
        void Dispose();
       
    }
}
