
namespace WindowsFormsApp2
{
    partial class Form4
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
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonResults = new System.Windows.Forms.Button();
            this.labelTicket = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 20;
            this.listBoxQuestions.Location = new System.Drawing.Point(12, 156);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(406, 64);
            this.listBoxQuestions.TabIndex = 0;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(12, 36);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(51, 20);
            this.labelSubject.TabIndex = 1;
            this.labelSubject.Text = "label1";
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopic.Location = new System.Drawing.Point(12, 66);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(51, 20);
            this.labelTopic.TabIndex = 2;
            this.labelTopic.Text = "label2";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.radioButton4);
            this.groupBoxOptions.Controls.Add(this.radioButton3);
            this.groupBoxOptions.Controls.Add(this.radioButton2);
            this.groupBoxOptions.Controls.Add(this.radioButton1);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 236);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(406, 159);
            this.groupBoxOptions.TabIndex = 3;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "groupBox1";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 91);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonResults
            // 
            this.buttonResults.Location = new System.Drawing.Point(343, 12);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(75, 23);
            this.buttonResults.TabIndex = 4;
            this.buttonResults.Text = "button1";
            this.buttonResults.UseVisualStyleBackColor = true;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTicket.Location = new System.Drawing.Point(12, 9);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(51, 20);
            this.labelTicket.TabIndex = 5;
            this.labelTicket.Text = "label3";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(157, 410);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "button2";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(15, 96);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(51, 20);
            this.labelQuestion.TabIndex = 7;
            this.labelQuestion.Text = "label1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 445);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.listBoxQuestions);
            this.Name = "Form4";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelQuestion;
    }
}