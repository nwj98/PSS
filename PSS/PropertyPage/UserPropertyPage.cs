using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS.PropertyPage
{
    public partial class UserPropertyPage : Form
    {
        UserProperty property = new UserProperty();
        public UserPropertyPage()
        {
            InitializeComponent();
            
        }

        
        public void SetPropertyLabel(string id, string docname, string name, string gender,
            string rank, string ip,string log)
        {
            property.SetLabelText(id, docname, name, gender, rank, ip,log);
            
            
        }
        public void SetContext(string id, string docname, string name, string gender,
            string rank, string ip, string log)
        {
            lblid.Text = id;
            lbldocname.Text = docname;
            lblname.Text = name;
            lblgender.Text = gender;
            lblrank.Text = rank;
            lblip.Text = ip;
            lbllog.Text = log;
        }
        private void UserPropertyPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
