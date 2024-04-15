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


        public FormMain()
        {
            InitializeComponent();
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
            Console.WriteLine("clicknode " + e.Node.FullPath+" level:"+e.Node.Level);
            
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
    }
}
