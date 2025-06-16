
namespace WindowsFormsApp2
{
    partial class Form5
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
            this.treeViewResults = new System.Windows.Forms.TreeView();
            this.labelTotalQuestions = new System.Windows.Forms.Label();
            this.labelAnswered = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewResults
            // 
            this.treeViewResults.Location = new System.Drawing.Point(12, 141);
            this.treeViewResults.Name = "treeViewResults";
            this.treeViewResults.Size = new System.Drawing.Size(512, 297);
            this.treeViewResults.TabIndex = 0;
            // 
            // labelTotalQuestions
            // 
            this.labelTotalQuestions.AutoSize = true;
            this.labelTotalQuestions.Location = new System.Drawing.Point(12, 9);
            this.labelTotalQuestions.Name = "labelTotalQuestions";
            this.labelTotalQuestions.Size = new System.Drawing.Size(35, 13);
            this.labelTotalQuestions.TabIndex = 1;
            this.labelTotalQuestions.Text = "label1";
            // 
            // labelAnswered
            // 
            this.labelAnswered.AutoSize = true;
            this.labelAnswered.Location = new System.Drawing.Point(12, 34);
            this.labelAnswered.Name = "labelAnswered";
            this.labelAnswered.Size = new System.Drawing.Size(35, 13);
            this.labelAnswered.TabIndex = 2;
            this.labelAnswered.Text = "label1";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Location = new System.Drawing.Point(12, 59);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(35, 13);
            this.labelCorrect.TabIndex = 3;
            this.labelCorrect.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(12, 112);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(35, 13);
            this.labelPercentage.TabIndex = 5;
            this.labelPercentage.Text = "label1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelAnswered);
            this.Controls.Add(this.labelTotalQuestions);
            this.Controls.Add(this.treeViewResults);
            this.Name = "Form5";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewResults;
        private System.Windows.Forms.Label labelTotalQuestions;
        private System.Windows.Forms.Label labelAnswered;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPercentage;
    }
}