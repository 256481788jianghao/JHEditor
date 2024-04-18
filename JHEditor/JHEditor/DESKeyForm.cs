using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHEditor
{
    public partial class DESKeyForm : Form
    {
        public DESKeyForm()
        {
            InitializeComponent();
        }

        public FileItem relativeFileItem;

        public delegate void FinishKeyEnterHandle(FileItem fileItem);
        public FinishKeyEnterHandle FinishKeyEnterEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            if(key.Length < 8)
            {
                MessageBox.Show("输入的密码小于8位");
            }
            else
            {
                relativeFileItem.SetDESKey(key);
                FinishKeyEnterEvent?.Invoke(relativeFileItem);
                this.Close();
            }
        }

        void PrintChars(string s)
        {
            Console.WriteLine($"\"{s}\".Length = {s.Length}");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"s[{i}] = '{s[i]}' ('\\u{(int)s[i]:x4}')");
            }
            Console.WriteLine();
        }
    }
}
