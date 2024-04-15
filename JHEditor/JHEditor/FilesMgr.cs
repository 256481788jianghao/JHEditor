using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHEditor
{
    public class FilesMgr
    {
        public List<FileItem> FileList = new List<FileItem>();

        public bool IsFileItemOpen(string fullPath)
        {
            return FileList.Any(i => i.fullPath == fullPath);
        }
    }
}
