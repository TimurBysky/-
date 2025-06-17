
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
            this.SuspendLayout();
            // 
            // treeViewResults
            // 
            this.treeViewResults.Location = new System.Drawing.Point(12, 139);
            this.treeViewResults.Name = "treeViewResults";
            this.treeViewResults.Size = new System.Drawing.Size(297, 237);
            this.treeViewResults.TabIndex = 0;
            this.treeViewResults.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewResults_NodeMouseDoubleClick);
            // 
            // labelTotalQuestions
            // 
            this.labelTotalQuestions.AutoSize = true;
            this.labelTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalQuestions.Location = new System.Drawing.Point(12, 9);
            this.labelTotalQuestions.Name = "labelTotalQuestions";
            this.labelTotalQuestions.Size = new System.Drawing.Size(51, 20);
            this.labelTotalQuestions.TabIndex = 1;
            this.labelTotalQuestions.Text = "label1";
            // 
            // labelAnswered
            // 
            this.labelAnswered.AutoSize = true;
            this.labelAnswered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswered.Location = new System.Drawing.Point(12, 34);
            this.labelAnswered.Name = "labelAnswered";
            this.labelAnswered.Size = new System.Drawing.Size(51, 20);
            this.labelAnswered.TabIndex = 2;
            this.labelAnswered.Text = "label1";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorrect.Location = new System.Drawing.Point(12, 59);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(51, 20);
            this.labelCorrect.TabIndex = 3;
            this.labelCorrect.Text = "label2";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 384);
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
    }
}