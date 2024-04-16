using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHEditor
{
    public class FileItem
    {
        public TabPage relativeTabPage;
        public RichTextBox relativeRichTextBox;
        public string fullPath;

        public bool IsFocus;
        public bool IsNeedSave;

        public FileItem(TabPage relativeTabPage, RichTextBox relativeRichTextBox, string fullPath)
        {
            this.relativeTabPage = relativeTabPage;
            this.relativeRichTextBox = relativeRichTextBox;
            this.fullPath = fullPath;
            this.IsFocus = false;
            this.IsNeedSave = false;
        }

        public string GetContext()
        {
            return File.ReadAllText(fullPath);
        }

        public void SaveContext()
        {
            SaveContext(relativeRichTextBox?.Text);
        }

        public void SaveContext(string context)
        {
            if(IsNeedSave == false) { return; }
            File.WriteAllText(fullPath, context);
            IsNeedSave = false;
        }
    }
}
