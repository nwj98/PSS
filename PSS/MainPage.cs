using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS
{
    public partial class MainPage : Form
    {
        ucPanel.PrintrecodePanel1 printrecode1 = new ucPanel.PrintrecodePanel1();
        ucPanel.PrintrecodePanel2 printrecode2 = new ucPanel.PrintrecodePanel2();
        ucPanel.PSSPanel psspanel = new ucPanel.PSSPanel();
        ucPanel.UserPanel1 userpanel1 = new ucPanel.UserPanel1();
        ucPanel.UserPanel2 userpanel2 = new ucPanel.UserPanel2();
        
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(psspanel);
            psspanel.Dock = mainPanel.Dock;
            TreeNode root = new TreeNode("PSS",0,0);
            root.Nodes.Add("truser","유저",1,1);
            root.Nodes.Add("trrecord","인쇄 기록",2,2);
            treeView.Nodes.Add(root);
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            if (treeView.SelectedNode.Text.Equals("PSS"))
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(psspanel);
                psspanel.Dock = mainPanel.Dock;
                
                
            }
            else if (treeView.SelectedNode.Text.Equals("유저")) 
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(userpanel1);
                userpanel1.Dock = mainPanel.Dock;
                
            }
            else if (treeView.SelectedNode.Text.Equals("인쇄 기록")) 
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(printrecode1);
                printrecode1.Dock = mainPanel.Dock;
            }
        }
    }
}
