using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHEditor
{
    public class JHDirectoryMgr
    {
        DriveInfo[] drivers;

        TreeNode TreeRoot;

        public JHDirectoryMgr()
        {
            drivers = DriveInfo.GetDrives();

            TreeRoot = new TreeNode("我的电脑");
        }

        public List<string> GetDrivesPaths()
        {
            List<string> paths = new List<string>();
            foreach (DriveInfo info in drivers)
            {
                if (info.DriveType == DriveType.Fixed || info.DriveType == DriveType.Removable)
                {
                    paths.Add(info.Name);
                }

            }
            return paths;
        }

        public TreeNode GetTreeRoot()
        {
            try
            {
                List<string> names = GetDrivesPaths();
                foreach (string name in names)
                {
                    TreeNode node = new TreeNode(name);
                    List<TreeNode> subNodes = GetSubNodes_OneLevel(name);
                    node.Nodes.AddRange(subNodes.ToArray());
                    TreeRoot.Nodes.Add(node);
                }
                return TreeRoot;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TreeNode> GetSubNodes(string startpath)
        {
            try
            {
                List<TreeNode> curLevel = GetSubNodes_OneLevel(startpath);
                Console.WriteLine("startPath:" + startpath);
                foreach (TreeNode nd in curLevel)
                {
                    string sub_startPath = startpath + nd.Text;
                    Console.WriteLine("sub_startPath:" + sub_startPath);
                    if (Directory.Exists(sub_startPath))
                    {
                        List<TreeNode> nextLevel = GetSubNodes_OneLevel(sub_startPath);
                        nd.Nodes.AddRange(nextLevel.ToArray());
                    }
                }
                return curLevel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private List<TreeNode> GetSubNodes_OneLevel(string startpath)
        {

            Console.WriteLine("GetSubNodes_OneLevel:" + startpath);
            List<TreeNode> ans = new List<TreeNode>();
            DirectoryInfo infos = new DirectoryInfo(startpath);
            try
            {
                //有些文件夹有访问权限问题，但目前没有找到如何检测是否有权限的方法
                foreach (DirectoryInfo dinfo in infos.GetDirectories())
                {
                    ans.Add(new TreeNode(dinfo.Name + @"\"));
                }
                foreach (FileInfo finfo in infos.GetFiles())
                {
                    ans.Add(new TreeNode(finfo.Name));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("GetSubNodes_OneLevel:" + startpath+" ans.count:"+ans.Count);
            return ans;

        }
    }
}
