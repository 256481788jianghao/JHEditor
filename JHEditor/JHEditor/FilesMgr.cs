using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHEditor
{
    public class FilesMgr
    {
        public List<FileItem> FileList = new List<FileItem>();

        public bool IsFileItemOpen(string fullPath)
        {
            return FileList.Any(i => i.fullPath == fullPath);
        }

        public FileItem FindItemByTabPage(TabPage page)
        {
            return FileList.Find(i =>i.relativeTabPage == page);
        }

        public FileItem FindItemByFullPath(string fullpath)
        {
            return FileList.Find(i => i.fullPath == fullpath);
        }

        public void RemoveItem(string fullPath)
        {
            FileList.RemoveAll(i => i.fullPath == fullPath);
        }
    }
}
