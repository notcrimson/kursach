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
                    AdminPUsChanges admin = new AdminPUsChanges();
                    admin.Show();
                    this.Hide();
                }
                else if (usr.Role == "student")
                {
                    Form3 menu = new Form3();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            //int locx = (this.Width) / 2 - (textBox1.Width / 2);
            //int locy = textBox1.Location.Y;
            //textBox1.Location = new Point(locx, locy);
        }
        private void Register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            Hide();
        }
    }
}
