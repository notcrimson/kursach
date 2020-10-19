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
    public partial class Tests : basicForm
    {
        public Tests()
        {
            InitializeComponent();
        }

        private void Tests_Load(object sender, EventArgs e)
        {
            int j = panel3.Location.X;
            string [] seperator1 = { ";" };
            string[] seperator2 = { "," };
            List<string> multipleAnswers = new List<string>();
            List<string> seperatedAnswers = new List<string>();
            List<string> seperatedAnswer = new List<string>();

            var query = from testAnswers in db.Tests
                        select testAnswers.Answers;

            foreach (var answers in query)
            {
                multipleAnswers.Add(answers);
            }
            foreach (var sepretAnswers in multipleAnswers)
            {
                seperatedAnswers.AddRange(sepretAnswers.Split(seperator1, StringSplitOptions.RemoveEmptyEntries));
            }
            foreach (var sep in seperatedAnswers)
            {
                seperatedAnswer.AddRange( sep.Split(seperator2, StringSplitOptions.RemoveEmptyEntries));
            }

            string[] sepp = seperatedAnswer.ToArray();

            for (int i = 0; i < sepp.Length; i++)
            {
                MessageBox.Show(sepp[i]);
            }
                

            for (int i = 0; i < 5; i++)
            {
              
                Panel gp = new Panel();
                //gp.ForeColor = Color.ForestGreen;
                //gp.Margin = new Padding(200);
                gp.Location = new Point(panel3.Location.X, j);
                gp.BorderStyle = panel3.BorderStyle;
                gp.BackColor = panel3.BackColor;
                gp.Size = panel3.Size;
                gp.Visible = true;

                j += 230;

                foreach (Control c in panel3.Controls)
                {
                    Control c2 = new Control();
                    if (c.GetType() == typeof(Label))
                    {
                        c2 = new Label();
                    }
                    if (c.GetType() == typeof(RadioButton))
                    {
                        c2 = new RadioButton();
                    }
                    c2.Location = c.Location;
                    c2.Size = c.Size;
                    c2.Text = c.Text;
                    gp.Controls.Add(c2);
                }
                panel4.Controls.Add(gp);
            }
        }
    }
}
