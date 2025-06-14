using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Quiz quiz;
        private int currentQuestionIndex = -1;

        public Form1()
        {
            InitializeComponent();
            LoadQuizFromJson("quiz.json");
            ShowNextQuestion();
        }

        private void LoadQuizFromJson(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                quiz = JsonSerializer.Deserialize<Quiz>(jsonString);

                // Заполняем ListBox
                listBoxQuestions.Items.Clear();
                foreach (var question in quiz.Questions)
                {
                    listBoxQuestions.Items.Add(question.Question);
                }

                if (quiz.Questions.Count > 0)
                {
                    listBoxQuestions.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}");
            }
        }

        private void ShowNextQuestion()
        {
            if (quiz == null || quiz.Questions.Count == 0) return;

            currentQuestionIndex++;
            if (currentQuestionIndex >= quiz.Questions.Count)
            {
                currentQuestionIndex = 0; // Начать сначала
            }

            var question = quiz.Questions[currentQuestionIndex];

            // Обновляем UI
            UpdateUI(question);

        }


        public void UpdateUI(QuizQuestion question)
        {
            labelQuestion.Text = question.Question;
            labelSubject.Text = $"Предмет: {question.Subject}";
            labelTopic.Text = $"Тема: {question.Topic}";
            listBoxQuestions.SelectedIndex = currentQuestionIndex;
        }

        private void SaveQuizToJson(string filePath)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(quiz, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения файла: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Код загрузки формы, если нужен
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {
            // Обработчик клика по labelQuestion, если нужен
        }

        private void buttonCheckAnswer_Click_1(object sender, EventArgs e)
        {
            if (currentQuestionIndex < 0 || currentQuestionIndex >= quiz.Questions.Count) return;

            int selectedIndex = -1;

            if (selectedIndex == -1)
            {
                return;
            }

            bool isCorrect = selectedIndex == quiz.Questions[currentQuestionIndex].CorrectAnswerIndex;
            //ShowNextQuestion();
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            ShowNextQuestion();
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        { 
           if (listBoxQuestions.SelectedIndex >= 0)
            {
                currentQuestionIndex = listBoxQuestions.SelectedIndex;
                DisplayCurrentQuestion();
            }
        }

        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < 0 || currentQuestionIndex >= quiz.Questions.Count)
                return;

            var question = quiz.Questions[currentQuestionIndex];

            // Обновляем UI
            UpdateUI(question);

            // Очищаем и заполняем listBoxAnswers
            listBoxAnswers.Items.Clear();
            foreach (var option in question.Options)
            {
                listBoxAnswers.Items.Add(option);
            }

            // Показываем правильный ответ
            if (question.CorrectAnswerIndex >= 0 && question.CorrectAnswerIndex < question.Options.Count)
            {
                labelCorrectAnswer.Text = $"Правильный ответ: {question.Options[question.CorrectAnswerIndex]}";
            }
            else
            {
                labelCorrectAnswer.Text = "Правильный ответ не указан";
            }

            // Обновляем выделение в ListBox
            listBoxQuestions.SelectedIndex = currentQuestionIndex;
        }

        private void buttonAddForm_Click(object sender, EventArgs e)
        {
            var addForm = new Form2(quiz);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                SaveQuizToJson("quiz.json");
                LoadQuizFromJson("quiz.json");
                ShowNextQuestion();
            }

        }

        private void groupBoxOptions_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBoxQuestions.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите вопрос для удаления!");
                return;
            }

            var dialog = (MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.YesNoCancel));
            if(dialog == DialogResult.Yes)
            {
                quiz.RemoveQuestion(currentQuestionIndex);
                SaveQuizToJson("quiz.json");
                LoadQuizFromJson("quiz.json");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var addForm = new Form3(quiz);
            addForm.Show();
        }
    }
}