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

namespace JHEditor
{
    public partial class FormMain : Form
    {
        JHDirectoryMgr directoryMgr = new JHDirectoryMgr();
        FilesMgr filesMgr = new FilesMgr();

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
                        filesMgr.RemoveItem(filesMgr.FindItemByTabPage(Page).fullPath);
                        tabControl_Context.TabPages.Remove(Page);
                    }
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                treeView_search_list.Nodes.Add(directoryMgr.GetTreeRoot());
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
                        List<TreeNode> nodes = directoryMgr.GetSubNodes(startpath);
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
                    if (filesMgr.IsFileItemOpen(filepath)) { return; }

                    
                    RichTextBox box = new RichTextBox();
                    box.Dock = DockStyle.Fill;
                    TabPage page = new TabPage();
                    page.Name = "Context_" + Path.GetFileNameWithoutExtension(filepath);
                    page.Text = Path.GetFileNameWithoutExtension(filepath)+"    X";
                    page.Controls.Add(box);
                    tabControl_Context.TabPages.Add(page);
                    FileItem item = new FileItem(page, box, filepath);
                    box.Text = item.GetContext();
                    filesMgr.FileList.Add(item);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            if(diag.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(diag.FileName, "");
            }
        }
    }
}
