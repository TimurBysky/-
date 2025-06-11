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
    public partial class Form2 : Form
    {
        private Quiz quiz;

        public Form2(Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
   
        }

        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                var options = new List<string>
                {
                textBoxOption1.Text,
                textBoxOption2.Text,
                textBoxOption3.Text,
                textBoxOption4.Text
                }.FindAll(opt => !string.IsNullOrEmpty(opt));

                if (options.Count < 2)
                {
                    MessageBox.Show("Должно быть хотя бы 2 варианта ответа");
                    return;
                }

                if (!int.TryParse(textBoxCorrectIndex.Text, out int correctIndex) ||
                    correctIndex < 0 || correctIndex >= options.Count)
                {
                    MessageBox.Show("Некорректный индекс правильного ответа");
                    return;
                }

                var newQuestion = new QuizQuestion
                {
                    Question = textBoxQuestion.Text,
                    Subject = textBoxSubject.Text,
                    Topic = textBoxTopic.Text,
                    Options = options,
                    CorrectAnswerIndex = correctIndex
                };

                quiz.Questions.Add(newQuestion);
                MessageBox.Show("Вопрос добавлен!");
                this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
