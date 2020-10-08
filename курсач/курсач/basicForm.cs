using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class basicForm : Form
    {
        public basicForm()
        {
            InitializeComponent();
        }

        private void basicForm_Load(object sender, EventArgs e)
        {

        }

        public void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.DarkRed;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }
        public void MouseH()
        {
            //label2_MouseHover(sender,e);
        }

        private void fHide_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void fHide_MouseHover(object sender, EventArgs e)
        {
            fHide.BackColor = Color.Khaki;
        }

        private void fHide_MouseLeave(object sender, EventArgs e)
        {
            fHide.BackColor = Color.OliveDrab;
        }
    }
}
