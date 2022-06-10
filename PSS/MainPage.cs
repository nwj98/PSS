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

namespace PSS
{
    public partial class MainPage : Form
    {
        ucPanel.PrintrecodePanel1 printrecode1 = new ucPanel.PrintrecodePanel1();
        ucPanel.PrintrecordPanel printrecord = new ucPanel.PrintrecordPanel();
        ucPanel.PSSPanel psspanel = new ucPanel.PSSPanel();
        ucPanel.UserPanel1 userpanel1 = new ucPanel.UserPanel1();
        ucPanel.UserPanel userpanel = new ucPanel.UserPanel();

        PropertyPage.UserPropertyPage userProperty;
        PropertyPage.PrintrecordPage printrecordProperty;



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
                /*
                userpanel1.LoadData();
                mainPanel.Controls.Add(userpanel1);
                userpanel1.Dock = mainPanel.Dock;
                */
                userpanel.LoadData();
                mainPanel.Controls.Add(userpanel);
                userpanel.Dock = mainPanel.Dock;


            }
            else if (treeView.SelectedNode.Text.Equals("인쇄 기록")) 
            {
                mainPanel.Controls.Clear();
               /*
                printrecode1.LoadData();
                mainPanel.Controls.Add(printrecode1);
                printrecode1.Dock = mainPanel.Dock;
               */

                printrecord.LoadData();
                mainPanel.Controls.Add(printrecord);
                printrecord.Dock = mainPanel.Dock;
            }
        }

        private void btfilter_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode.Text.Equals("유저"))
            {
                Filter.UserFilter filter = new Filter.UserFilter();
                filter.DataSendEvent += new Filter.UserDataGetEventHandler(this.UserDataGet);
                filter.Show();
            }
            else if(treeView.SelectedNode.Text.Equals("인쇄 기록"))
            {
                Filter.PrintrecordFilter filter = new Filter.PrintrecordFilter();
                filter.DataSendEvent += new Filter.PrintrecordDataGetEventHandler(this.PrintrecordDataGet);
                filter.Show();
            }
        }
        public void UserDataGet(string logf,string logl, string dept, string name, string rank)
        {
            mainPanel.Controls.Clear();
            /*
            userpanel1.FilterData(logf, logl, dept, name, rank);
            mainPanel.Controls.Add(userpanel1);
            userpanel1.Dock = mainPanel.Dock;
            */
            userpanel.FilterData(logf, logl, dept, name, rank);
            mainPanel.Controls.Add(userpanel);
            userpanel.Dock = mainPanel.Dock;

        }
        public void PrintrecordDataGet(string logf, string logl, string name)
        {
            mainPanel.Controls.Clear();
            /*
            printrecode1.FilterData(logf, logl, name, pagesize, isColor);
            mainPanel.Controls.Add(printrecode1);
            printrecode1.Dock = mainPanel.Dock;
            */
            printrecord.FilterData(logf, logl, name);
            mainPanel.Controls.Add(printrecord);
            printrecord.Dock = mainPanel.Dock;
        }
        private void btcsv_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode.Text.Equals("유저"))
            {
                SaveFileDialog save = GetCSVSave();
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Save_CSV(save.FileName, userpanel1.getGrid(), true);
                    Save_CSV(save.FileName, userpanel.getGrid(), true);
                }
            }
            else if(treeView.SelectedNode.Text.Equals("인쇄 기록"))
            {
                SaveFileDialog save = GetCSVSave();
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Save_CSV(save.FileName, printrecode1.getGrid(), true);
                    Save_CSV(save.FileName, printrecord.getGrid(), true);
                }
            }
        }
        
        public SaveFileDialog GetCSVSave()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.CheckPathExists = true;
            save.AddExtension = true;
            save.ValidateNames = true;

            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string filepath = Path.GetDirectoryName(path);

            save.InitialDirectory = filepath;

            save.DefaultExt = ".csv";
            save.Filter = "csv (*.csv) | *.csv";
            save.FileName = "export".ToString();

            return save;
        }
        public void Save_CSV(string filename, DataGridView grid, bool header)
        {
            string delimiter = ",";
            FileStream fs = new FileStream(filename, System.IO.FileMode.Create,
                System.IO.FileAccess.Write);
            StreamWriter csvExport = new StreamWriter(fs, System.Text.Encoding.UTF8);

            if (grid.Rows.Count == 0) return;

            if (header)
            {
                for(int i = 0; i < grid.Columns.Count; i++)
                {
                    csvExport.Write(grid.Columns[i].HeaderText);
                    if(i != grid.Columns.Count - 1)
                    {
                        csvExport.Write(delimiter);
                    }
                }
            }
            csvExport.Write(csvExport.NewLine);

            foreach(DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow)
                {
                    for(int i =0; i< grid.Columns.Count; i++)
                    {
                        csvExport.Write(row.Cells[i].Value);
                        if(i != grid.Columns.Count - 1)
                        {
                            csvExport.Write(delimiter);
                        }
                    }
                    csvExport.Write(csvExport.NewLine);
                }
            }
            csvExport.Flush();
            csvExport.Close();
            fs.Close();
        }

        private void btevent_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode.Text.Equals("유저"))
            {
                /*
                DataGridView grid = userpanel1.getGrid();
                PropertyPage.UserPropertyPage propertyPage = new PropertyPage.UserPropertyPage();
                propertyPage.SetPropertyLabel(grid.CurrentRow.Cells[0].Value.ToString(),
                grid.CurrentRow.Cells[1].Value.ToString(),
                grid.CurrentRow.Cells[2].Value.ToString(),
                grid.CurrentRow.Cells[3].Value.ToString(),
                grid.CurrentRow.Cells[4].Value.ToString(),
                grid.CurrentRow.Cells[5].Value.ToString(),
                grid.CurrentRow.Cells[6].Value.ToString());
                propertyPage.Show();*/
                
                DataGridView grid = userpanel.getGrid();
                userProperty = new PropertyPage.UserPropertyPage();
                userProperty.SetContext(grid.CurrentRow.Cells[0].Value.ToString(),
                grid.CurrentRow.Cells[1].Value.ToString(),
                grid.CurrentRow.Cells[2].Value.ToString(),
                grid.CurrentRow.Cells[3].Value.ToString(),
                grid.CurrentRow.Cells[4].Value.ToString(),
                grid.CurrentRow.Cells[5].Value.ToString(),
                grid.CurrentRow.Cells[6].Value.ToString());
                userProperty.Show();

            }
            else if (treeView.SelectedNode.Text.Equals("인쇄 기록"))
            {
                DataGridView grid = printrecord.getGrid();
                printrecordProperty = new PropertyPage.PrintrecordPage();
                printrecordProperty.SetContext(grid.CurrentRow.Cells[0].Value.ToString(),
                grid.CurrentRow.Cells[1].Value.ToString(),
                grid.CurrentRow.Cells[2].Value.ToString(),
                grid.CurrentRow.Cells[3].Value.ToString());
                printrecordProperty.Show();
            }
        }

        private void btrecycle_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode.Text.Equals("유저"))
            {
                mainPanel.Controls.Clear();
                /*
                userpanel1.LoadData();
                mainPanel.Controls.Add(userpanel1);
                userpanel1.Dock = mainPanel.Dock;
                */
                userpanel.LoadData();
                mainPanel.Controls.Add(userpanel);
                userpanel.Dock = mainPanel.Dock;

            }
            else if (treeView.SelectedNode.Text.Equals("인쇄 기록"))
            {
                mainPanel.Controls.Clear();
                /*
                printrecode1.LoadData();
                mainPanel.Controls.Add(printrecode1);
                printrecode1.Dock = mainPanel.Dock;
                */
                printrecord.LoadData();
                mainPanel.Controls.Add(printrecord);
                printrecord.Dock = mainPanel.Dock;
            }
        }

        private void btfindname_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode.Text.Equals("유저"))
            {
                Search.NameSearch search = new Search.NameSearch();
                search.DataSendEvent += new Search.UserNameSearchEventHandler(this.UserNameSearch);
                search.Show();

            }
            else if (treeView.SelectedNode.Text.Equals("인쇄 기록"))
            {
                Search.NameSearch search = new Search.NameSearch();
                search.DataSendEvent += new Search.UserNameSearchEventHandler(this.PrinterrecordNameSearch);
                search.Show();
            }
        }
        public void UserNameSearch(string name)
        {
            /*
            userpanel1.SearchNameData(name);
            mainPanel.Controls.Add(userpanel1);
            userpanel1.Dock = mainPanel.Dock;
            */

            userpanel.SearchNameData(name);
            mainPanel.Controls.Add(userpanel);
            userpanel.Dock = mainPanel.Dock;
        }
        public void PrinterrecordNameSearch(string name)
        {
            /*
            userpanel1.SearchNameData(name);
            mainPanel.Controls.Add(userpanel1);
            userpanel1.Dock = mainPanel.Dock;
            */

            printrecord.SearchNameData(name);
            mainPanel.Controls.Add(printrecord);
            printrecord.Dock = mainPanel.Dock;
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btpreview_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode.Text.Equals("인쇄 기록"))
            {
                string print_num = "";
                DataGridView grid = printrecord.getGrid();
                
                //grid.ClearSelection();
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Selected)
                    {
                        print_num = row.Cells[0].Value.ToString();
                    }
                    

                }

                string file_path = printrecord.GetFilepath(print_num);

                System.Diagnostics.ProcessStartInfo pri = new System.Diagnostics.ProcessStartInfo();

                System.Diagnostics.Process pro = new System.Diagnostics.Process();

                pri.FileName = "cmd.exe";
                pri.CreateNoWindow = false; //flase가 띄우기, true가 안 띄우기
                pri.UseShellExecute = false;

                pri.RedirectStandardInput = true;
                pri.RedirectStandardOutput = true;
                pri.RedirectStandardError = true;

                pro.StartInfo = pri;
                pro.Start();

                pro.StandardInput.Write(@"C:\Windows\System32\xpsrchvw.exe "+ file_path + Environment.NewLine);
                pro.StandardInput.Close();
                string resultValue = pro.StandardOutput.ReadToEnd();
                pro.WaitForExit();
                pro.Close();
                
            }
        }
    }
}
