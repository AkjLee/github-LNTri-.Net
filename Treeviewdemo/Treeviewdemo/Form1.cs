using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treeviewdemo
{
    public partial class Form1 : Form
    {
        private string subNode;

        public Form1()
        {
            InitializeComponent();
            /*    InitializeComponent();
                var drives = Environment.GetLogicalDrives();
                foreach(var drive in drives)
                {
                    TreeNode node = new TreeNode(drive);
                    treeView1.Nodes.Add(node);
                    addNode(drive, node, 1);

                   *//* var directoryInfo = new System.IO.DirectoryInfo(drive);
                    var directories = directoryInfo.GetDirectories();
                    foreach(var d in directories)
                    {
                        TreeNode subNode = new TreeNode(d.Name);
                        node.Nodes.Add(subNode);
                    } *//*                
                }*/
        }

 
        void addNode(string parentDirectory, TreeNode parentNode, int level)
        {
            try 
            { 
                if( level < 5)
                {
                    var directoryInfo = new System.IO.DirectoryInfo(parentDirectory);
                    var directories = directoryInfo.GetDirectories();
                        foreach (var d in directories)
                        {
                            TreeNode subNode = new TreeNode(d.Name);
                            parentNode.Nodes.Add(subNode);
                            addNode(d.FullName, subNode, level +1); // giới hạn file xâu
                        }
                }
            }
            catch(Exception ex )
            {

            }
        }

        private void bttaocay_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            List<TreeNode> list = new List<TreeNode>();

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (t, w) =>
            {
                var drives = Environment.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    TreeNode node = new TreeNode(drive);
                    list.Add(node);
                    addNode(drive, node, 1);
                }
            };
            worker.RunWorkerCompleted += (t, w) =>
            {
                pictureBox1.Visible = false;
                treeView1.Nodes.AddRange(list.ToArray());
            };
            worker.RunWorkerAsync();


            //----------------------------------------------------------------
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
       
        }
    }
