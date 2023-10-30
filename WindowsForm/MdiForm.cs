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
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {

        }

        private void empolyeeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // create 
            form2.MdiParent = this;       //Current form
            form2.Show();              // Show
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.MdiParent = this;
            notepad.Show();
        }
    }
}
