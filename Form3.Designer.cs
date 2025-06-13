
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
            this.checkedListBoxTopics = new System.Windows.Forms.CheckedListBox();
            this.numericUpDownQuesNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTopicsNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTestsNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveToRTF = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxAllowDuplicates = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopicsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(436, 202);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(109, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Начать тест";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // checkedListBoxTopics
            // 
            this.checkedListBoxTopics.FormattingEnabled = true;
            this.checkedListBoxTopics.Location = new System.Drawing.Point(196, 12);
            this.checkedListBoxTopics.Name = "checkedListBoxTopics";
            this.checkedListBoxTopics.Size = new System.Drawing.Size(207, 244);
            this.checkedListBoxTopics.TabIndex = 2;
            this.checkedListBoxTopics.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxTopics_ItemCheck);
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonSaveToRTF
            // 
            this.buttonSaveToRTF.Location = new System.Drawing.Point(436, 232);
            this.buttonSaveToRTF.Name = "buttonSaveToRTF";
            this.buttonSaveToRTF.Size = new System.Drawing.Size(109, 23);
            this.buttonSaveToRTF.TabIndex = 7;
            this.buttonSaveToRTF.Text = "Сохранить билеты";
            this.buttonSaveToRTF.UseVisualStyleBackColor = true;
            this.buttonSaveToRTF.Click += new System.EventHandler(this.buttonSaveToRTF_Click);
            // 
            // checkBoxAllowDuplicates
            // 
            this.checkBoxAllowDuplicates.AutoSize = true;
            this.checkBoxAllowDuplicates.Location = new System.Drawing.Point(425, 131);
            this.checkBoxAllowDuplicates.Name = "checkBoxAllowDuplicates";
            this.checkBoxAllowDuplicates.Size = new System.Drawing.Size(133, 17);
            this.checkBoxAllowDuplicates.TabIndex = 8;
            this.checkBoxAllowDuplicates.Text = "Повторять вопросы?";
            this.checkBoxAllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 281);
            this.Controls.Add(this.checkBoxAllowDuplicates);
            this.Controls.Add(this.buttonSaveToRTF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownTestsNumber);
            this.Controls.Add(this.numericUpDownTopicsNumber);
            this.Controls.Add(this.numericUpDownQuesNumber);
            this.Controls.Add(this.checkedListBoxTopics);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopicsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.CheckedListBox checkedListBoxTopics;
        private System.Windows.Forms.NumericUpDown numericUpDownQuesNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownTopicsNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownTestsNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveToRTF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxAllowDuplicates;
    }
}