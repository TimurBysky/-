
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.textBoxOption1 = new System.Windows.Forms.TextBox();
            this.textBoxOption2 = new System.Windows.Forms.TextBox();
            this.textBoxOption3 = new System.Windows.Forms.TextBox();
            this.textBoxOption4 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCorrectIndex = new System.Windows.Forms.TextBox();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(31, 29);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(141, 20);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(31, 61);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(141, 20);
            this.textBoxSubject.TabIndex = 1;
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(31, 96);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(141, 20);
            this.textBoxTopic.TabIndex = 2;
            // 
            // textBoxOption1
            // 
            this.textBoxOption1.Location = new System.Drawing.Point(72, 147);
            this.textBoxOption1.Name = "textBoxOption1";
            this.textBoxOption1.Size = new System.Drawing.Size(100, 20);
            this.textBoxOption1.TabIndex = 3;
            // 
            // textBoxOption2
            // 
            this.textBoxOption2.Location = new System.Drawing.Point(71, 187);
            this.textBoxOption2.Name = "textBoxOption2";
            this.textBoxOption2.Size = new System.Drawing.Size(100, 20);
            this.textBoxOption2.TabIndex = 4;
            // 
            // textBoxOption3
            // 
            this.textBoxOption3.Location = new System.Drawing.Point(71, 229);
            this.textBoxOption3.Name = "textBoxOption3";
            this.textBoxOption3.Size = new System.Drawing.Size(100, 20);
            this.textBoxOption3.TabIndex = 5;
            // 
            // textBoxOption4
            // 
            this.textBoxOption4.Location = new System.Drawing.Point(71, 267);
            this.textBoxOption4.Name = "textBoxOption4";
            this.textBoxOption4.Size = new System.Drawing.Size(100, 20);
            this.textBoxOption4.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(216, 229);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "button1";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCorrectIndex
            // 
            this.textBoxCorrectIndex.Location = new System.Drawing.Point(276, 147);
            this.textBoxCorrectIndex.Name = "textBoxCorrectIndex";
            this.textBoxCorrectIndex.Size = new System.Drawing.Size(24, 20);
            this.textBoxCorrectIndex.TabIndex = 8;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(216, 264);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(75, 23);
            this.buttonAddQuestion.TabIndex = 9;
            this.buttonAddQuestion.Text = "button2";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 306);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.textBoxCorrectIndex);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxOption4);
            this.Controls.Add(this.textBoxOption3);
            this.Controls.Add(this.textBoxOption2);
            this.Controls.Add(this.textBoxOption1);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxQuestion);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.TextBox textBoxOption1;
        private System.Windows.Forms.TextBox textBoxOption2;
        private System.Windows.Forms.TextBox textBoxOption3;
        private System.Windows.Forms.TextBox textBoxOption4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCorrectIndex;
        private System.Windows.Forms.Button buttonAddQuestion;
    }
}