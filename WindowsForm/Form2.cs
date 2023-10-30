using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form2 : Form
    {
        List<string> Deptlist = new List<string>()
        {
            "HR","Admin","Development","Testing","Marketing"
        };
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_comboBox_Department.DataSource = Deptlist;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_HRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_PF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_GrossSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void butn_Calculate_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(txt_BasicSalary.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.30;
            double da = bs * 0.20;
            double pf = bs * 0.12;
            double gross = (bs + hra + ta + da) - pf;

            txt_HRA.Text = hra.ToString();
            txt_TA.Text = ta.ToString();
            txt_DA.Text = da.ToString();
            txt_PF.Text = pf.ToString();
            txt_GrossSalary.Text = gross.ToString();
        }

        private void butn_Display_Click(object sender, EventArgs e)
        {
            string msg=txt_Employeeid.Text+"\n"+txt_EmployeeName.Text+"\n"+txt_comboBox_Department.Text+"\n"+txt_GrossSalary.Text+"\n";
            lblmsg.Text = msg;
        }
    }
}
