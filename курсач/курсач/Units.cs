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
            foreach(var Pu in pus)
            {
                //MessageBox.Show(Pu.Name_of_PU);
                listBox1.Items.Add(Pu.Name_of_PU);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            selectedItem = listBox1.SelectedItem.ToString();
            MessageBox.Show(selectedItem);
            panel3.Visible = true;

            //if (listBox1.SelectedItem == "kke")
            //{
            //    MessageBox.Show("kek");
            //}

        }

        private void OpenPU_Click(object sender, EventArgs e)
        {
            StudentPU sPU = new StudentPU();
            sPU.Show();
            this.Hide();
        }
    }
}
