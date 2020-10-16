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
    public partial class Units : basicForm
    {
        //public Professional_unit PU {get;set;}
        public Units()
        {

            InitializeComponent();
        }

        private void Units_Load(object sender, EventArgs e)
        {
            var pus = from p in db.Professional_units
                      select new { p.Name_of_PU };
            foreach (var Pu in pus)
            {
                listBox1.Items.Add(Pu.Name_of_PU);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedItem = listBox1.SelectedItem.ToString();
                panel3.Visible = true;
            }
        }

        private void OpenPU_Click(object sender, EventArgs e)
        {
            StudentPU sPU = new StudentPU();
            sPU.Show();
            this.Hide();
        }

        private void Units_Resize(object sender, EventArgs e)
        {
            //int locx = (flowLayoutPanel1.Width) / 2 - (panel3.Width / 2);
            //int locy = panel3.Location.Y;
            //panel3.Location = new Point(locx, locy);

            //int locx2 = (flowLayoutPanel1.Width) / 2 - (listBox1.Width / 2);
            //int locy2 = listBox1.Location.Y;
            //listBox1.Location = new Point(locx2, locy2);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
