using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace JHEditor
{
    public partial class FormMain : Form
    {
        

        JHContextTabControl tabControl_Context;

        public FormMain()
        {
            InitializeComponent();

            tabControl_Context = new JHContextTabControl();
            tabControl_Context.Dock = DockStyle.Fill;
            tabControl_Context.OnMouseOhterClickEvt += new JHContextTabControl.OnMouseOhterClickHandle(ClickTabPageTitleHandler);
            panel_Context.Controls.Add(tabControl_Context);
        }

        private void ClickTabPageTitleHandler(int index,bool isclose)
        {
            if(index >= 0)
            {
                TabPage Page = tabControl_Context.TabPages[index];
                if(Page != null)
                {
                    if (isclose)
                    {
                        FileItem item = GVL.filesMgr.FindItemByTabPage(Page);
                        if(item.IsNeedSave)
                        {
                            if(MessageBox.Show("保存修改吗?","提示",MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                item.SaveContext();
                            }
                        }
                        GVL.filesMgr.RemoveItem(item.fullPath);
                        tabControl_Context.TabPages.Remove(Page);
                    }
                    else
                    {
                        GVL.filesMgr.SetFocusFileItemByTabpage(Page);
                    }
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                GVL.InitConfigParam();
                
                treeView_search_list.Nodes.Add(GVL.directoryMgr.GetTreeRoot());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void treeView_search_list_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Console.WriteLine("clicknode " + e.Node.FullPath+" level:"+e.Node.Level+" file:"+File.Exists(e.Node.FullPath.Replace(@"我的电脑\", "")));


            
        }

        private void treeView_search_list_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                Console.WriteLine("before expend " + e.Node.FullPath + " level:" + e.Node.Level);
                if (e.Node.Level > 0)
                {
                    string startpath = e.Node.FullPath.Replace(@"我的电脑\", "");
                    if (Directory.Exists(startpath))
                    {
                        e.Node.Nodes.Clear();
                        List<TreeNode> nodes = GVL.directoryMgr.GetSubNodes(startpath);
                        e.Node.Nodes.AddRange(nodes.ToArray());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void treeView_search_list_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string filepath = e.Node.FullPath.Replace(@"我的电脑\", "");
            Console.WriteLine("doubleclicknode " + e.Node.FullPath + " level:" + e.Node.Level + " file:" + File.Exists(filepath));
            if(File.Exists(filepath))
            {
                try
                {
                    if (GVL.filesMgr.IsFileItemOpen(filepath)) { return; }

                    
                    RichTextBox box = new RichTextBox();
                    box.Dock = DockStyle.Fill;
                    box.ContextMenuStrip = contextMenuStrip_richbox;
                    if(GVL.ConfigParam.defaultFont != null)
                    {
                        box.Font = GVL.ConfigParam.defaultFont;
                    }

                    box.TextChanged += new EventHandler(RichTextContextChangeCallBack);
                    box.KeyDown += new KeyEventHandler(RichTextBoxKeyDown);
                    TabPage page = new TabPage();
                    page.Name = "Context_" + Path.GetFileNameWithoutExtension(filepath);
                    page.Text = Path.GetFileNameWithoutExtension(filepath)+"    X";
                    page.Controls.Add(box);
                    
                    Encoding encoding = Encoding.UTF8;
                    encoding = GVL.ConfigParam.GetEncoding();
                    FileItem item = new FileItem(page, box, filepath, encoding);

                    if (item.IsCryptoFile)
                    {
                        DESKeyForm form = new DESKeyForm();
                        form.relativeFileItem = item;
                        form.FinishKeyEnterEvent += new DESKeyForm.FinishKeyEnterHandle(FinishKeyEnterCallBack);
                        form.ShowDialog();
                    }
                    else
                    {
                        AddPageToTabControl(item);
                    } 
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void FinishKeyEnterCallBack(FileItem item)
        {
            //item.relativeRichTextBox.Invoke(new Action(() =>
           // {
                AddPageToTabControl(item);
           // }));
        }

        private void AddPageToTabControl(FileItem item)
        {
            item.relativeRichTextBox.Text = item.GetContext();
            GVL.filesMgr.FileList.Add(item);
            if (GVL.filesMgr.FileList.Count == 1)
            {
                //当只有一个page的时候，这个page就是focus的
                GVL.filesMgr.SetFocusFileItemByTabpage(item.relativeTabPage);
            }
            tabControl_Context.TabPages.Add(item.relativeTabPage);
        }

        private void RichTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                Console.WriteLine("rich save");
                FileItem item = GVL.filesMgr.FindItemByRichTextBox((RichTextBox)sender);
                item.SaveContext();
                tabControl_Context.Invalidate();
            }
            else if (e.KeyData == (Keys.Control | Keys.F))
            {
                RichTextBox bb = (RichTextBox)sender;
                MessageBox.Show(bb.SelectedText);
                FileItem item = GVL.filesMgr.FindItemByRichTextBox(bb);
            }
        }

        private void RichTextContextChangeCallBack(object sender,EventArgs e)
        {
            FileItem selectItem = GVL.filesMgr.FindItemByRichTextBox((RichTextBox)sender);
            if(selectItem != null) { selectItem.IsNeedSave = true; }
            tabControl_Context.Invalidate();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData ==(Keys.Control | Keys.C))
            {
                Console.WriteLine("form copy");
            }
        }

        private void contextMenuStrip_richbox_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 字体设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                GVL.filesMgr.GetFocusItem().relativeRichTextBox.Font = dialog.Font;
                GVL.filesMgr.GetFocusItem().relativeRichTextBox.Invalidate();
            }

        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GVL.ConfigParam.defaultFont = dialog.Font;
                GVL.SaveConfigParam();
            }
        }

        private void uTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVL.ConfigParam.defaultEncoding = ConfigParam.JHEncoding.utf8;
            GVL.SaveConfigParam();
        }

        private void uTF16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVL.ConfigParam.defaultEncoding = ConfigParam.JHEncoding.utf16;
            GVL.SaveConfigParam();
        }

        private void gBKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVL.ConfigParam.defaultEncoding = ConfigParam.JHEncoding.gbk;
            GVL.SaveConfigParam();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GVL.ConfigParam.defaultEncoding = ConfigParam.JHEncoding.ascii;
            GVL.SaveConfigParam();
        }

        private void 普通文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                GVL.directoryMgr.InserFileNode(diag.FileName);
                File.WriteAllText(diag.FileName, "");
            }
        }

        private void 加密文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Filter = "加密|*.jhf";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                GVL.directoryMgr.InserFileNode(diag.FileName);
                File.WriteAllText(diag.FileName, "");
            }
        }

        private void binFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileItem item = GVL.filesMgr.GetFocusItem();
            item.IsBinFile = true;
            item.relativeRichTextBox.Text = item.GetContext();
        }

        private void sourceFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileItem item = GVL.filesMgr.GetFocusItem();
            item.IsBinFile = false;
            item.relativeRichTextBox.Text = item.GetContext();
        }
    }
}
