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
        public static Model1 db = new Model1();
        public static Form previousForm { get; set; }
        public string path = Environment.CurrentDirectory.ToString() + @"\PUs\";
        public static string selectedItem;
        Point lastClick;
        int mx;
        int my;
        int sw;
        int sh;
        bool move;

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

        //private void Back_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    previousForm.Show();
        //    previousForm = this;
        //}

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
            Cursor.Current = Cursors.SizeAll;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
            Cursor.Current = Cursors.SizeAll;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) //sizer
        {
            move = true;
            mx = MousePosition.X;
            my = MousePosition.Y;
            sw = Width;
            sh = Height;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                Width = MousePosition.X - mx + sw;
                Height = MousePosition.Y - my + sh;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void sizer_Click(object sender, EventArgs e)
        {

        }
    }
}
