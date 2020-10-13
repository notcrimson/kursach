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
        public static User USER { get; set; }

        

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User usr = db.Users.Find(textBox1.Text);
            if ((usr != null) && (usr.Password == textBox2.Text))
            {
                USER = usr;
                previousForm = this;

                if (usr.Role == "admin")
                {

                }
                else if (usr.Role == "student")
                {
                    Form3 menu = new Form3();
                    menu.Show();
                    this.Hide();
                }

            }
        }
    }
}
