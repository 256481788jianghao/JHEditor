using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        public Encoding encoding;

        public bool IsBinFile;

        public bool IsFocus;
        public bool IsNeedSave;

        public bool IsCryptoFile;
        private string CryptoKey;
        private byte[] CryptoKey_bytes = new byte[32];
        private byte[] CryptoIv_bytes = new byte[16];

        public FileItem(TabPage relativeTabPage, RichTextBox relativeRichTextBox, string fullPath,Encoding encoding)
        {
            this.relativeTabPage = relativeTabPage;
            this.relativeRichTextBox = relativeRichTextBox;
            this.fullPath = fullPath;

            if(Path.GetExtension(this.fullPath) == ".bin")
            {
                this.IsBinFile = true;
            }
            else
            {
                this.IsBinFile = false;
            }

            if(Path.GetExtension(this.fullPath) == ".jhf")
            {
                this.IsCryptoFile = true;
            }
            else
            {
                this.IsCryptoFile = false;
            }


            this.IsFocus = false;
            this.IsNeedSave = false;
            this.encoding = encoding;
        }

        public void SetDESKey(string key)
        {
            this.CryptoKey = key;

            string rev_CryptoKey = this.CryptoKey.Reverse().ToString();

            Array.Copy(Encoding.UTF8.GetBytes(CryptoKey.PadRight(CryptoKey_bytes.Length)), this.CryptoKey_bytes, this.CryptoKey_bytes.Length);
            Array.Copy(Encoding.UTF8.GetBytes(rev_CryptoKey.PadRight(CryptoIv_bytes.Length)), this.CryptoIv_bytes, this.CryptoIv_bytes.Length);

        }

        public string GetContext()
        {
            if (IsBinFile)
            {
                byte[] values = File.ReadAllBytes(this.fullPath);
                return ChangeByteToStr(values);
            }
            else
            {
                if (IsCryptoFile)
                {
                    string base64str = File.ReadAllText(this.fullPath, Encoding.ASCII);
                    if (string.IsNullOrEmpty(base64str))
                    {
                        return "";
                    }
                    else
                    {
                        try
                        {
                            string all_base64_str = File.ReadAllText(fullPath, Encoding.ASCII);
                            byte[] base64_bytes = Convert.FromBase64String(all_base64_str);

                            Rijndael aes = Rijndael.Create();
                            MemoryStream mStream = new MemoryStream();
                            CryptoStream cStream = new CryptoStream(mStream, aes.CreateDecryptor(CryptoKey_bytes, CryptoIv_bytes), CryptoStreamMode.Write);
                            cStream.Write(base64_bytes, 0, base64_bytes.Length);
                            cStream.FlushFinalBlock();
                            return Encoding.UTF8.GetString(mStream.ToArray());
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("没有解密成功");
                        }
                    }
                }
                else
                {
                    return File.ReadAllText(fullPath, encoding);
                }
            } 
        }

        private string ChangeByteToStr(byte[] value)
        {
            string ans = "";
            for(int i = 0; i < value.Length; i++)
            {
                if(i>0 && i%16 == 15)
                {
                    ans += value[i].ToString("x2") + "\n";
                }
                else if(i == value.Length - 1)
                {
                    ans += value[i].ToString("x2") + "\n";
                }
                else
                {
                    ans += value[i].ToString("x2") + ",";
                }
            }
            return ans;
        }

        private byte[] ChangeStrToBytes(string formatStr)
        {
            List<byte> ans = new List<byte>();
            string[] lines = formatStr.Split('\n');
            foreach(string line in lines)
            {
                if(string.IsNullOrEmpty(line)) continue;

                string[] sigleChar = line.Split(',');
                foreach(string c in sigleChar)
                {
                    ans.Add(Convert.ToByte(c,16));
                }
            }
            return ans.ToArray();
        }

        public void SaveContext()
        {
            SaveContext(relativeRichTextBox?.Text);
        }

        public void SaveContext(string context)
        {
            if(IsNeedSave == false) { return; }
            if (IsBinFile == true)
            {
                File.WriteAllBytes(fullPath,ChangeStrToBytes(context));
            }
            else
            {
                if (IsCryptoFile)
                {
                    string sourceStr = context;//.net 默认的utf16
                    byte[] utf8_bytes = Encoding.UTF8.GetBytes(sourceStr);//转为utf8字节码


                    Rijndael aes = Rijndael.Create();
                    MemoryStream mStream = new MemoryStream();
                    CryptoStream cStream = new CryptoStream(mStream, aes.CreateEncryptor(CryptoKey_bytes, CryptoIv_bytes), CryptoStreamMode.Write);
                    cStream.Write(utf8_bytes, 0, utf8_bytes.Length);
                    cStream.FlushFinalBlock();
                    File.WriteAllText(fullPath, Convert.ToBase64String(mStream.ToArray()), Encoding.ASCII);
                }
                else
                {
                    File.WriteAllText(fullPath, context, encoding);
                }
            }
            IsNeedSave = false;
        }
    }
}
