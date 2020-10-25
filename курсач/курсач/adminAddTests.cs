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
    public partial class adminAddTests : basicForm
    {
        public int j;
        public int spaceBetweenQ;
        public int ind = 1;
        public int panelNumber = 1;
        public string panelN;
        public string panelToDelete;

        public adminAddTests()
        {
            InitializeComponent();
        }

        private void adminAddTests_Load(object sender, EventArgs e)
        {
            ActiveControl = textBox3;
            adminMenu am = new adminMenu();
            previousForm = am;
            j = panel0.Location.Y + 293;
            spaceBetweenQ = panelQ.Location.Y + 50;
        }

        private void addQuestion_Click(object sender, EventArgs e)
        {
            //CREATING THE PANEL FOR THE WHOLE QUESTION
            Panel p = new Panel();
            p.Name = "panel" + (panelNumber).ToString();
            p.Location = new Point(panel0.Location.X, j);
            p.Size = new Size(870, 184);
            p.BorderStyle = panel0.BorderStyle;
            p.BackColor = panel0.BackColor;
            p.Enter += new EventHandler(this.panel0_Enter);
            p.Click += new EventHandler(this.panel0_Click);
            j += 293;
            panelNumber++;

            Label l = new Label();
            l.Location = label3.Location;
            l.Size = label3.Size;
            l.Text = label3.Text;

            TextBox t = new TextBox();
            t.Location = textBox1.Location;
            t.Size = textBox1.Size;

            p.Controls.Add(l);
            p.Controls.Add(t);

            // CREATING ONE QUESTION PANEL
            Panel panQ = new Panel();
            panQ.Location = panelQ.Location;
            panQ.Size = panelQ.Size;
            panQ.BackColor = panelQ.BackColor;
            panQ.Visible = true;
            panQ.BorderStyle = panelQ.BorderStyle;


            foreach (Control pQ in panelQ.Controls)
            {
                Control paQ = new Control();
                if (pQ.GetType() == typeof(Label))
                {
                    paQ = new Label();
                    paQ.Location = pQ.Location;
                    paQ.Size = pQ.Size;
                    paQ.Text = pQ.Text;
                }
                if (pQ.GetType() == typeof(TextBox))
                {
                    paQ = new TextBox();
                    paQ.Location = pQ.Location;
                    paQ.Size = pQ.Size;
                }
                if (pQ.GetType() == typeof(RadioButton))
                {
                    paQ = new RadioButton();
                    paQ.Location = pQ.Location;
                    paQ.Size = pQ.Size;
                }
                panQ.Controls.Add(paQ);
            }
            p.Controls.Add(panQ);

            // CREATING BOTTEM PANEL WITH THE ADD AND DELETE BUTTONS
            Panel bp = new Panel();
            bp.Dock = DockStyle.Bottom;
            bp.Location = panel4.Location;
            bp.Size = panel4.Size;
            bp.BorderStyle = panel4.BorderStyle;
            bp.BackColor = panel4.BackColor;
            bp.Visible = true;

            Button add = new Button();
            add.Location = addAnswer.Location;
            add.Size = addAnswer.Size;
            add.Text = addAnswer.Text;
            add.BackColor = addAnswer.BackColor;
            add.Click += new EventHandler(this.addAnswer_Click);

            Button del = new Button();
            del.Location = button2.Location;
            del.Size = button2.Size;
            del.Text = button2.Text;
            del.BackColor = button2.BackColor;
            del.Click += new EventHandler(this.deleteQ_click);

            bp.Controls.Add(add);
            bp.Controls.Add(del);

            p.Controls.Add(bp);
            flowLayoutPanel1.Controls.Add(p);
        }

        private void deleteQ_Click(object sender, EventArgs e)
        {
            //var panel = flowLayoutPanel1.Controls[panelN];
            if (flowLayoutPanel1.Controls.Count >1 )
            {
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count-1);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            Close();
        }

        private void addAnswer_Click(object sender, EventArgs e)
        {
            Panel anotherQuestion = new Panel();
            anotherQuestion.Name = "question № " + (ind).ToString();
            anotherQuestion.Location = new Point(panelQ.Location.X, spaceBetweenQ);
            anotherQuestion.Size = panelQ.Size;
            anotherQuestion.BackColor = panelQ.BackColor;
            spaceBetweenQ += 50;
            ind++;

            foreach (Control question in panelQ.Controls)
            {
                Control c4 = new Control();
                if (question.GetType() == typeof(Label))
                {
                    c4 = new Label();
                    c4.Location = question.Location;
                    c4.Size = question.Size;
                    c4.Text = question.Text;
                }
                if (question.GetType() == typeof(TextBox))
                {
                    c4 = new TextBox();
                    c4.Location = question.Location;
                    c4.Size = question.Size;
                }
                if (question.GetType() == typeof(RadioButton))
                {
                    c4 = new RadioButton();
                    c4.Location = question.Location;
                    c4.Size = question.Size;
                }
                anotherQuestion.Controls.Add(c4);
            }
            var panel = flowLayoutPanel1.Controls[panelN];
            panel.Controls.Add(anotherQuestion);
            panel.Size = new Size(panel.Width, panel.Height + 50);
        }

        private void panel0_Click(object sender, EventArgs e)
        {


        }

        private void deleteQ_click(object sender, EventArgs e)
        {
            var panel = flowLayoutPanel1.Controls[panelN];
            if (panel.Controls.Count > 4)
            {
                panel.Controls.RemoveAt(panel.Controls.Count - 1);
            }

            panel.MinimumSize = new Size(870, 184);
            panel.Size = new Size(panel.Width, panel.Height - 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int countQ = 0;
            var panel = flowLayoutPanel1.Controls[panelN];
            foreach (Control h in panel.Controls)
            {
                if (h.GetType() == typeof(Panel))
                {
                    countQ++;
                }
            }

            for (int i = 0; i < countQ - 1; i++)
            {
                spaceBetweenQ = panelQ.Location.Y + 50 + (i * 50);
            }

        }

        private void panel0_Enter(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            int countQ = 0;

            Panel questionPanel = sender as Panel;
            panelN = questionPanel.Name;


            foreach (Control h in questionPanel.Controls)
            {
                if (h.GetType() == typeof(Panel))
                {
                    countQ++;
                }
            }
            for (int i = 0; i < countQ - 1; i++)
            {
                spaceBetweenQ = panelQ.Location.Y + 50 + (i * 50);
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"So you want the name of the test to be:\n\"{textBox3.Text}\"", "Test name", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                textBox3.Visible = false;
                label5.Visible = false;
                label1.Text = textBox3.Text;
            }
            else
            {
                return;
            }
        }

        private void addTest_Click(object sender, EventArgs e)
        {
            string k = "";
            int num = 0;
            List<string> questions = new List<string>();
            List<string> pAnswers = new List<string>();
            List<string> allAnswers = new List<string>();
            foreach (Panel p in flowLayoutPanel1.Controls)
            {
                foreach (Control c in p.Controls)
                {
                    if(c is TextBox && !String.IsNullOrEmpty(((TextBox)c).Text))
                    {
                        questions.Add(c.Text);
                    }
                    if (c is Panel)
                    {
                        foreach (Control c2 in c.Controls)
                        {
                            if (c2 is TextBox && !String.IsNullOrEmpty(((TextBox)c2).Text))
                            {
                                pAnswers.Add(c2.Text);
                            }
                        }
                    }
                }
                for (int i = 0; i < pAnswers.Count; i++)
                {
                    if (i + 1 == pAnswers.Count)
                    {
                        k += pAnswers[i] + ";";
                    }
                    else
                    {
                        k += pAnswers[i] + ", ";
                    }
                }
                allAnswers.Add(k);
                k = "";
                pAnswers.Clear();
            }

            Test test = new Test();
            foreach(var a in questions)
            {
                test.Name_of_PU = "1.Introduction to programming";
                test.Test_name = label1.Text;
                test.Question = questions[num];
                test.Answers = allAnswers[num];
                db.Tests.Add(test);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("added");
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
                num++;
            }
            //for (int i = 0; i < allAnswers.Count; i++)
            //{
            //    if (i  == allAnswers.Count)
            //    {
            //        l += allAnswers[i] + ";";
            //    }
            //    else
            //    {
            //        l += allAnswers[i] + ", ";
            //    }
            //}
                //MessageBox.Show(l);
        }
    }
}
