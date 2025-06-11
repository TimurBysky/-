using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private Quiz quiz;
        public Form3(Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadSubjects();
        }

        void loadSubjects()
        {
            checkedListBoxSubjects.DisplayMember = "Subject"; // Показываем текст вопроса

            foreach (var subject in quiz.Questions)
            {
                checkedListBoxSubjects.Items.Add(subject);
            }
        }
    }
}
