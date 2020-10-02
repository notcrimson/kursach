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
    public partial class Form1 : basicForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.DarkRed;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void fHide_Click(object sender, EventArgs e)
        {
            HideForm();
        }
    }
}
