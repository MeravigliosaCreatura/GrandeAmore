using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginInterface
{
    public interface IPerfectSearcher
    {
     
        String Name { get; }
        void AddFunctionality(TableLayoutPanel c);
        List<FileInfo> getFiles(TableLayoutPanel c, List<FileInfo> files);
       
    }
}
