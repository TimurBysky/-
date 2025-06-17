
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(31, 25);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(362, 20);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(130, 64);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(141, 20);
            this.textBoxSubject.TabIndex = 1;
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(130, 104);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(141, 20);
            this.textBoxTopic.TabIndex = 2;
            // 
            // textBoxOption1
            // 
            this.textBoxOption1.Location = new System.Drawing.Point(31, 154);
            this.textBoxOption1.Name = "textBoxOption1";
            this.textBoxOption1.Size = new System.Drawing.Size(362, 20);
            this.textBoxOption1.TabIndex = 3;
            // 
            // textBoxOption2
            // 
            this.textBoxOption2.Location = new System.Drawing.Point(30, 194);
            this.textBoxOption2.Name = "textBoxOption2";
            this.textBoxOption2.Size = new System.Drawing.Size(362, 20);
            this.textBoxOption2.TabIndex = 4;
            // 
            // textBoxOption3
            // 
            this.textBoxOption3.Location = new System.Drawing.Point(30, 236);
            this.textBoxOption3.Name = "textBoxOption3";
            this.textBoxOption3.Size = new System.Drawing.Size(362, 20);
            this.textBoxOption3.TabIndex = 5;
            // 
            // textBoxOption4
            // 
            this.textBoxOption4.Location = new System.Drawing.Point(30, 274);
            this.textBoxOption4.Name = "textBoxOption4";
            this.textBoxOption4.Size = new System.Drawing.Size(362, 20);
            this.textBoxOption4.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(165, 370);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCorrectIndex
            // 
            this.textBoxCorrectIndex.Location = new System.Drawing.Point(165, 332);
            this.textBoxCorrectIndex.Name = "textBoxCorrectIndex";
            this.textBoxCorrectIndex.Size = new System.Drawing.Size(75, 20);
            this.textBoxCorrectIndex.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Вопрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тема";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Варианты ответа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "0:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "1:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "2:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "3:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Номер правильного варианта";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 431);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание вопросов";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}