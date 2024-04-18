using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHEditor
{
    public class ConfigParam
    {
        public enum JHEncoding
        {
            utf8,utf16,gbk,ascii
        }

        public Font defaultFont = null;
        public JHEncoding defaultEncoding = JHEncoding.utf8;

        public Encoding GetEncoding()
        {
            switch(defaultEncoding)
            {
                case JHEncoding.utf8: { return Encoding.UTF8; }
                case JHEncoding.utf16: { return Encoding.Unicode; }
                case JHEncoding.gbk: { return Encoding.GetEncoding("gbk"); }
                case JHEncoding.ascii: { return Encoding.ASCII; }
                default:return Encoding.UTF8;
            }
        }
    }
}
