
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelTopic = new System.Windows.Forms.Label();
            this.buttonAddForm = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxAnswers = new System.Windows.Forms.ListBox();
            this.labelCorrectAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.HorizontalScrollbar = true;
            this.listBoxQuestions.Location = new System.Drawing.Point(12, 83);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(306, 147);
            this.listBoxQuestions.TabIndex = 0;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 4);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(35, 13);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "label1";
            this.labelQuestion.Click += new System.EventHandler(this.labelQuestion_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 32);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(35, 13);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "label2";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(93, 240);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(12, 62);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(35, 13);
            this.labelTopic.TabIndex = 11;
            this.labelTopic.Text = "label3";
            // 
            // buttonAddForm
            // 
            this.buttonAddForm.Location = new System.Drawing.Point(243, 240);
            this.buttonAddForm.Name = "buttonAddForm";
            this.buttonAddForm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddForm.TabIndex = 12;
            this.buttonAddForm.Text = "Создать";
            this.buttonAddForm.UseVisualStyleBackColor = true;
            this.buttonAddForm.Click += new System.EventHandler(this.buttonAddForm_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 240);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Новый тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxAnswers
            // 
            this.listBoxAnswers.FormattingEnabled = true;
            this.listBoxAnswers.HorizontalScrollbar = true;
            this.listBoxAnswers.Location = new System.Drawing.Point(324, 83);
            this.listBoxAnswers.Name = "listBoxAnswers";
            this.listBoxAnswers.Size = new System.Drawing.Size(198, 121);
            this.listBoxAnswers.TabIndex = 15;
            // 
            // labelCorrectAnswer
            // 
            this.labelCorrectAnswer.AutoSize = true;
            this.labelCorrectAnswer.Location = new System.Drawing.Point(321, 217);
            this.labelCorrectAnswer.Name = "labelCorrectAnswer";
            this.labelCorrectAnswer.Size = new System.Drawing.Size(35, 13);
            this.labelCorrectAnswer.TabIndex = 16;
            this.labelCorrectAnswer.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Варианты ответа:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCorrectAnswer);
            this.Controls.Add(this.listBoxAnswers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddForm);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.listBoxQuestions);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ListBox listBoxQuestions;
        protected System.Windows.Forms.Label labelQuestion;
        protected System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Button buttonAddForm;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxAnswers;
        private System.Windows.Forms.Label labelCorrectAnswer;
        private System.Windows.Forms.Label label1;
    }
}

