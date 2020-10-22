﻿using System;
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
    public partial class StudentPU : basicForm
    {
        public StudentPU()
        {
            InitializeComponent();
        }

        private void StudentPU_Load(object sender, EventArgs e)
        {
            Units un = new Units();
            previousForm = un;

            label1.Text = selectedItem;
            string contentString;
            Professional_unit pr = db.Professional_units.Find(selectedItem);
            if (pr != null)
            {
                contentString = Encoding.ASCII.GetString(pr.ContentOfPU);
                richTextBox1.Rtf = contentString;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            Close();
        }
    }
}
