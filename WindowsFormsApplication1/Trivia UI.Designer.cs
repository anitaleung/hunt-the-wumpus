namespace WumpusTest
{
    partial class TriviaUI
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonanswer1 = new System.Windows.Forms.Button();
            this.buttonanswer2 = new System.Windows.Forms.Button();
            this.buttonanswer3 = new System.Windows.Forms.Button();
            this.buttonanswer4 = new System.Windows.Forms.Button();
            this.labelanswer1 = new System.Windows.Forms.Label();
            this.labelanswer2 = new System.Windows.Forms.Label();
            this.labelanswer3 = new System.Windows.Forms.Label();
            this.labelanswer4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(20, 20);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(148, 20);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question goes here";
            this.labelQuestion.Click += new System.EventHandler(this.labelQuestion_Click);
            // 
            // buttonanswer1
            // 
            this.buttonanswer1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonanswer1.Location = new System.Drawing.Point(24, 91);
            this.buttonanswer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonanswer1.Name = "buttonanswer1";
            this.buttonanswer1.Size = new System.Drawing.Size(112, 35);
            this.buttonanswer1.TabIndex = 1;
            this.buttonanswer1.Text = "button1";
            this.buttonanswer1.UseVisualStyleBackColor = true;
            this.buttonanswer1.Click += new System.EventHandler(this.buttonanswer1_Click);
            // 
            // buttonanswer2
            // 
            this.buttonanswer2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonanswer2.Location = new System.Drawing.Point(24, 137);
            this.buttonanswer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonanswer2.Name = "buttonanswer2";
            this.buttonanswer2.Size = new System.Drawing.Size(112, 35);
            this.buttonanswer2.TabIndex = 2;
            this.buttonanswer2.Text = "button2";
            this.buttonanswer2.UseVisualStyleBackColor = true;
            this.buttonanswer2.Click += new System.EventHandler(this.buttonanswer2_Click);
            // 
            // buttonanswer3
            // 
            this.buttonanswer3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonanswer3.Location = new System.Drawing.Point(24, 183);
            this.buttonanswer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonanswer3.Name = "buttonanswer3";
            this.buttonanswer3.Size = new System.Drawing.Size(112, 35);
            this.buttonanswer3.TabIndex = 3;
            this.buttonanswer3.Text = "button3";
            this.buttonanswer3.UseVisualStyleBackColor = true;
            this.buttonanswer3.Click += new System.EventHandler(this.buttonanswer3_Click);
            // 
            // buttonanswer4
            // 
            this.buttonanswer4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonanswer4.Location = new System.Drawing.Point(24, 229);
            this.buttonanswer4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonanswer4.Name = "buttonanswer4";
            this.buttonanswer4.Size = new System.Drawing.Size(112, 35);
            this.buttonanswer4.TabIndex = 4;
            this.buttonanswer4.Text = "button4";
            this.buttonanswer4.UseVisualStyleBackColor = true;
            this.buttonanswer4.Click += new System.EventHandler(this.buttonanswer4_Click);
            // 
            // labelanswer1
            // 
            this.labelanswer1.AutoSize = true;
            this.labelanswer1.Location = new System.Drawing.Point(147, 98);
            this.labelanswer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelanswer1.Name = "labelanswer1";
            this.labelanswer1.Size = new System.Drawing.Size(0, 20);
            this.labelanswer1.TabIndex = 5;
            // 
            // labelanswer2
            // 
            this.labelanswer2.AutoSize = true;
            this.labelanswer2.Location = new System.Drawing.Point(159, 145);
            this.labelanswer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelanswer2.Name = "labelanswer2";
            this.labelanswer2.Size = new System.Drawing.Size(61, 20);
            this.labelanswer2.TabIndex = 6;
            this.labelanswer2.Text = "anwer2";
            // 
            // labelanswer3
            // 
            this.labelanswer3.AutoSize = true;
            this.labelanswer3.Location = new System.Drawing.Point(159, 190);
            this.labelanswer3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelanswer3.Name = "labelanswer3";
            this.labelanswer3.Size = new System.Drawing.Size(69, 20);
            this.labelanswer3.TabIndex = 7;
            this.labelanswer3.Text = "answer3";
            // 
            // labelanswer4
            // 
            this.labelanswer4.AutoSize = true;
            this.labelanswer4.Location = new System.Drawing.Point(159, 236);
            this.labelanswer4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelanswer4.Name = "labelanswer4";
            this.labelanswer4.Size = new System.Drawing.Size(69, 20);
            this.labelanswer4.TabIndex = 8;
            this.labelanswer4.Text = "answer4";
            // 
            // TriviaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 354);
            this.Controls.Add(this.labelanswer4);
            this.Controls.Add(this.labelanswer3);
            this.Controls.Add(this.labelanswer2);
            this.Controls.Add(this.labelanswer1);
            this.Controls.Add(this.buttonanswer4);
            this.Controls.Add(this.buttonanswer3);
            this.Controls.Add(this.buttonanswer2);
            this.Controls.Add(this.buttonanswer1);
            this.Controls.Add(this.labelQuestion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TriviaUI";
            this.Text = "TriviaUI";
            this.Load += new System.EventHandler(this.TriviaUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonanswer1;
        private System.Windows.Forms.Button buttonanswer2;
        private System.Windows.Forms.Button buttonanswer3;
        private System.Windows.Forms.Button buttonanswer4;
        private System.Windows.Forms.Label labelanswer1;
        private System.Windows.Forms.Label labelanswer2;
        private System.Windows.Forms.Label labelanswer3;
        private System.Windows.Forms.Label labelanswer4;
    }
}