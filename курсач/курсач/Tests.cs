using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
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
            int a = 0;
            int b = 0;
            int j = panel3.Location.X;
            string[] seperator1 = { ";" };
            string[] seperator2 = { "," };
            List<string> multipleAnswers = new List<string>();
            List<string> seperatedAnswer = new List<string>();

            var queryForAns = from testAnswers in db.Tests
                              select testAnswers.Answers;

            foreach (var answers in queryForAns)
            {
                multipleAnswers.AddRange(answers.Split(seperator1, StringSplitOptions.RemoveEmptyEntries));
            }
            foreach (var sep in multipleAnswers)
            {
                seperatedAnswer.AddRange(sep.Split(seperator2, StringSplitOptions.RemoveEmptyEntries));
            }

            string[] sepp = seperatedAnswer.ToArray();

            var queryForNQ = from k in db.Tests
                             select k.Question;
            int count = queryForNQ.Count();
            //MessageBox.Show(count.ToString());

            //for (int i = 0; i < sepp.Length; i++)
            //{
            //	MessageBox.Show(sepp[i]);
            //}
            //string[] kek = new string []{"TEST", "TEST2"};
            List<string> Questions = new List<string>();
            foreach (var q in queryForNQ)
            {
                Questions.Add(q);
            }
            //MessageBox.Show(Questions.Count.ToString());
            for (int i = 0; i < count; i++)
            {
                Panel gp = new Panel();
                gp.Location = new Point(panel3.Location.X, j);
                gp.BorderStyle = panel3.BorderStyle;
                gp.BackColor = panel3.BackColor;
                gp.Size = panel3.Size;
                //gp.Dock = FillMode;
                gp.Visible = true;

                j += 230;

                foreach (Control c in panel3.Controls)
                {
                    Control c2 = new Control();
                    Control c3 = new Control();
                    if (c.GetType() == typeof(Label))
                    {
                        c3 = new Label();
                        c3.Location = c.Location;
                        c3.Size = c.Size;
                        c3.Text = Questions[b];
                        b++;
                    }
                    if (c.GetType() == typeof(RadioButton))
                    {
                        c2 = new RadioButton();
                        c2.Location = c.Location;
                        c2.Size = c.Size;
                        c2.Text = sepp[a];
                        a++;
                    }
                    gp.Controls.Add(c2);
                    gp.Controls.Add(c3);
                }
                //MessageBox.Show(sepp.Length.ToString());
                flowLayoutPanel1.Controls.Add(gp);
            }
        }

        private void finishTest_Click(object sender, EventArgs e)
        {
            string k = "";
            List<string> answers = new List<string>();
            foreach (Panel p in flowLayoutPanel1.Controls)
            {
                foreach (Control c in p.Controls)
                {
                    if (c is RadioButton)
                    {
                        if (((RadioButton)c).Checked)
                        {
                            answers.Add(c.Text);
                        }
                    }
                }
            }

            for (int i = 0; i < answers.Count; i++)
            {
                if (i+1 == answers.Count)
                {
                    k += answers[i];
                }
                else
                {
                    k += answers[i] + ", ";
                }
            }
            MessageBox.Show(k);
        }
    }
}
