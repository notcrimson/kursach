namespace курсач
{
    partial class Tests
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finishTest = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 9);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Back);
            this.panel2.Controls.Add(this.finishTest);
            this.panel2.Controls.SetChildIndex(this.finishTest, 0);
            this.panel2.Controls.SetChildIndex(this.Back, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(859, -1);
            // 
            // fHide
            // 
            this.fHide.Location = new System.Drawing.Point(831, -3);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(165, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(147, 26);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 224);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(108, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(765, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(курсач.Test);
            // 
            // finishTest
            // 
            this.finishTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishTest.Location = new System.Drawing.Point(766, 8);
            this.finishTest.Name = "finishTest";
            this.finishTest.Size = new System.Drawing.Size(110, 32);
            this.finishTest.TabIndex = 2;
            this.finishTest.Text = "Finish test";
            this.finishTest.UseVisualStyleBackColor = true;
            this.finishTest.Click += new System.EventHandler(this.finishTest_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(16, 10);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(98, 32);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(899, 438);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 540);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Tests";
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.Tests_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button finishTest;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}