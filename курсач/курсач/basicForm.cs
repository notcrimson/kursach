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

        public void HideForm()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        public void ExitApplication()
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();  
            }            
        }

        public void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.DarkRed;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {

        }
        public void MouseH()
        {
            //label2_MouseHover(sender,e);
        }
    }
}
