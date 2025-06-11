
namespace WindowsFormsApp2
{
    partial class Form3
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.checkedListBoxSubjects = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxTopics = new System.Windows.Forms.CheckedListBox();
            this.numericUpDownQuesNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTopicsNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTestsNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopicsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(470, 233);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "button1";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxSubjects
            // 
            this.checkedListBoxSubjects.FormattingEnabled = true;
            this.checkedListBoxSubjects.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxSubjects.Name = "checkedListBoxSubjects";
            this.checkedListBoxSubjects.Size = new System.Drawing.Size(178, 244);
            this.checkedListBoxSubjects.TabIndex = 1;
            // 
            // checkedListBoxTopics
            // 
            this.checkedListBoxTopics.FormattingEnabled = true;
            this.checkedListBoxTopics.Location = new System.Drawing.Point(196, 12);
            this.checkedListBoxTopics.Name = "checkedListBoxTopics";
            this.checkedListBoxTopics.Size = new System.Drawing.Size(207, 244);
            this.checkedListBoxTopics.TabIndex = 2;
            // 
            // numericUpDownQuesNumber
            // 
            this.numericUpDownQuesNumber.Location = new System.Drawing.Point(425, 12);
            this.numericUpDownQuesNumber.Name = "numericUpDownQuesNumber";
            this.numericUpDownQuesNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuesNumber.TabIndex = 3;
            // 
            // numericUpDownTopicsNumber
            // 
            this.numericUpDownTopicsNumber.Location = new System.Drawing.Point(425, 52);
            this.numericUpDownTopicsNumber.Name = "numericUpDownTopicsNumber";
            this.numericUpDownTopicsNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTopicsNumber.TabIndex = 4;
            // 
            // numericUpDownTestsNumber
            // 
            this.numericUpDownTestsNumber.Location = new System.Drawing.Point(425, 92);
            this.numericUpDownTestsNumber.Name = "numericUpDownTestsNumber";
            this.numericUpDownTestsNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTestsNumber.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 281);
            this.Controls.Add(this.numericUpDownTestsNumber);
            this.Controls.Add(this.numericUpDownTopicsNumber);
            this.Controls.Add(this.numericUpDownQuesNumber);
            this.Controls.Add(this.checkedListBoxTopics);
            this.Controls.Add(this.checkedListBoxSubjects);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopicsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestsNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.CheckedListBox checkedListBoxSubjects;
        private System.Windows.Forms.CheckedListBox checkedListBoxTopics;
        private System.Windows.Forms.NumericUpDown numericUpDownQuesNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownTopicsNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownTestsNumber;
    }
}