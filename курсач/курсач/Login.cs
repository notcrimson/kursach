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
    public partial class Login : basicForm
    {
        //public static User USER { get; set; }
        public static Login LOGINFORM { get; set; }

        //Model1 db = new Model1();

        public Login()
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

        private void button1_Click(object sender, EventArgs e)
        {
            //User usr = db.Users.Find(textBox1.Text);
            //if (usr != null && (usr.Password == textBox2.Text))
            {
                //USER = usr;
                LOGINFORM = this;

            }
        }
    }
}
