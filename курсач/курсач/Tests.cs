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
            
            List<object> lmao = new List<object>();
            var quer = from paa in db.Tests
                       where paa.Test_name == "kek2"
                       select paa;
            foreach (var aa in quer)
            {
                lmao.Add(aa);
            }
            testBindingSource.DataSource = lmao;
            //для андрея





            //MessageBox.Show(s);
            listOfTests l = new listOfTests();
            previousForm = l;


            label1.Text = listOfTests.testName;
            int a = 0;
            int b = 0;
            int j = panel3.Location.X;
            string[] seperator1 = { ";" };
            string[] seperator2 = { "," };
            List<string> multipleAnswers = new List<string>();
            List<string> seperatedAnswer = new List<string>();

           




            var queryForAns = from testAnswers in db.Tests
                              where testAnswers.Test_name == listOfTests.testName
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
            MessageBox.Show(multipleAnswers.Count.ToString());

            var queryForNQ = from k in db.Tests
                             where k.Test_name == listOfTests.testName
                             select k.Question;
            int count = queryForNQ.Count();

            //int countQ = 0;
            

            List<string> Questions = new List<string>();
            foreach (var q in queryForNQ)
            {
                Questions.Add(q);
            }
            MessageBox.Show(Questions[0]);

            List<string> ans = new List<string>();
            List<int> numberOfAnswers = new List<int>();
            for (int i = 0; i <= Questions.Count; i++)
            {
                string s = Questions[i];
                var qForPossibleAnswers = from pA in db.Tests
                                          where pA.Question == s
                                          select pA.Answers;

                foreach (var q in qForPossibleAnswers)
                {
                    ans.AddRange(q.Split(seperator2, StringSplitOptions.RemoveEmptyEntries));
                }
                numberOfAnswers.Add(ans.Count);
                ans.Clear();
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

        private void Back_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            Close();
        }
    }
}
