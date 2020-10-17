using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace курсач
{
    public partial class Register : basicForm
    {
        // Regex strings
        public string regexString;
        public string numb;
        public string capL;

        // confirmation for inserting in db
        public bool confirmationForUpdate;

        // ERROR MESSAGES

        public string nErrorMessage;
        public string uErrorMessage;
        public string pErrorMessage;
        public string cpErrorMessage;

        public byte[] image;
 
        public Register()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ActiveControl = Namee;
            NameeCheck();
            UsernameCheck();
            PasswordCheck();
            ConfirmPasswordCheck();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageConverter conv = new ImageConverter();
            image = (byte[])conv.ConvertTo(pictureBox1.Image, typeof(byte[]));

            User usr = new User();

            if (confirmationForUpdate)
            {
                usr.Login = Username.Text;
                usr.Name = Namee.Text;
                usr.Password = Password.Text;
                usr.Role = "student";
                usr.ProfilePic = image;
                db.Users.Add(usr);

                try
                {
                    db.SaveChanges();
                    DialogResult dr = MessageBox.Show("Congrats, you created an account!", "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Form3 menu = new Form3();
                        menu.Show();
                        this.Hide();
                    }
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }
            }
        }
        public void NameeCheck()
        {
            regexString = @"^[а-я А-Я a-z A-Z]+$";
            if (!String.IsNullOrEmpty(Namee.Text))
            {
                if (Regex.IsMatch(Namee.Text, regexString) is false)
                {
                    nErrorMessage = "Your name can contain only letters";
                    nameError.Visible = true;
                }
                else
                {
                    nameError.Visible = false;
                }
            }
            else
            {

                nErrorMessage = "The name field is unfilled";
                nameError.Visible = true;
            }
        }
        public void UsernameCheck()
        {
            regexString = @"^[А-Я а-я]+$";
            if (!String.IsNullOrEmpty(Username.Text))
            {
                if (Regex.IsMatch(Username.Text, regexString) is false)
                {
                    usernameError.Visible = false;
                }
                else
                {
                    usernameError.Visible = true;
                    uErrorMessage = "Username cant contain russian letters";
                }
            }
            else
            {
                usernameError.Visible = true;
                uErrorMessage = "The username field is unfilled";
            }
        }
        public void PasswordCheck()
        {
            regexString = @"[!@#$%^&*]+";
            numb = @"[0-9]+";
            capL = @"[A-Z А-Я]+";
            if (!String.IsNullOrEmpty(Password.Text))
            {
                if (Password.TextLength >= 6)
                {
                    if (Regex.IsMatch(Password.Text, regexString))
                    {
                        if (Regex.IsMatch(Password.Text, numb))
                        {
                            if (Regex.IsMatch(Password.Text, capL))
                            {
                                passError.Visible = false;
                            }
                            else
                            {
                                pErrorMessage = "Password must contain at least one capital letter";
                                passError.Visible = true;
                            }
                        }
                        else
                        {
                            pErrorMessage = "Password must contain at least one number\n" +
                                            "Password must contain at least one capital letter";
                            passError.Visible = true;
                        }
                    }
                    else
                    {
                        pErrorMessage = "Password must contain at least one special character:\n" +
                        "!@#$%^&*\n" +
                        "Password must contain at least one number\n" +
                        "Password must contain at least one capital letter";
                        passError.Visible = true;
                    }
                }
                else
                {
                    passError.Visible = true;
                    pErrorMessage = "Password must be at least 6 characters long\n" +
                        "Password must contain at least one special character:\n" +
                        "!@#$%^&*\n" +
                        "Password must contain at least one number\n" +
                        "Password must contain at least one capital letter";
                }
            }
            else
            {
                passError.Visible = true;
                pErrorMessage = "The password field is unfilled";
            }

        }
        public void ConfirmPasswordCheck()
        {
            if (!String.IsNullOrEmpty(ConfirmPassword.Text))
            {
                if (Password.Text == ConfirmPassword.Text)
                {
                    confirmpassError.Visible = false;
                }
                else
                {
                    confirmpassError.Visible = true;
                    cpErrorMessage = "Doesnt match the Password field";
                }
            }
            else
            {
                cpErrorMessage = "The confirm password field is unfilled";
                confirmpassError.Visible = true;
            }
        }
        private void nameError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
        }

        private void usernameError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
        }

        private void passError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
        }

        private void confirmpassError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nameError.Visible && usernameError.Visible && passError.Visible && confirmpassError.Visible)
            {
                confirmationForUpdate = false;
            }
            else
            {
                confirmationForUpdate = true;
            }
            //NameeCheck();
            toolTip1.SetToolTip(nameError, nErrorMessage);
            //UsernameCheck();
            toolTip1.SetToolTip(usernameError, uErrorMessage);
            //PasswordCheck();
            toolTip1.SetToolTip(passError, pErrorMessage);
            //ConfirmPassordCheck();
            toolTip1.SetToolTip(confirmpassError, cpErrorMessage);
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            PasswordCheck();
            toolTip1.SetToolTip(passError, pErrorMessage);
        }

        private void Namee_TextChanged(object sender, EventArgs e)
        {
            NameeCheck();
            toolTip1.SetToolTip(nameError, nErrorMessage);
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            UsernameCheck();
            toolTip1.SetToolTip(usernameError, uErrorMessage);
        }

        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ConfirmPasswordCheck();
            toolTip1.SetToolTip(confirmpassError, cpErrorMessage);
        }

        private void uploadPic_Click(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = @"C:\Pictures";
            openFileDialog1.Filter = "JPG, PNG | *.jpg;*.png";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
               
            }
        }
    }
}
