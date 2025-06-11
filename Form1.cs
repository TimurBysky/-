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
            UptadeUI(question);

            // Очищаем предыдущие варианты
            foreach (Control control in groupBoxOptions.Controls)
            {
                if (control is RadioButton) control.Visible = false;
            }

            // Добавляем новые варианты
            for (int i = 0; i < question.Options.Count; i++)
            {
                RadioButton radioButton;
                if (i < groupBoxOptions.Controls.Count)
                {
                    radioButton = (RadioButton)groupBoxOptions.Controls[i];
                }
                else
                {
                    radioButton = new RadioButton();
                    radioButton.AutoSize = true;
                    radioButton.Location = new System.Drawing.Point(10, 20 + i * 30);
                    groupBoxOptions.Controls.Add(radioButton);
                }

                radioButton.Text = question.Options[i];
                radioButton.Visible = true;
                radioButton.Checked = false;
            }

            labelResult.Text = "";
        }


        public void UptadeUI(QuizQuestion question)
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
            for (int i = 0; i < groupBoxOptions.Controls.Count; i++)
            {
                if (groupBoxOptions.Controls[i] is RadioButton radio && radio.Checked)
                {
                    selectedIndex = i;
                    break;
                }
            }

            if (selectedIndex == -1)
            {
                labelResult.Text = "Выберите ответ!";
                return;
            }

            bool isCorrect = selectedIndex == quiz.Questions[currentQuestionIndex].CorrectAnswerIndex;
            labelResult.Text = isCorrect ? "Правильно!" : "Неправильно!";
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

            UptadeUI(question);

            // Очищаем предыдущие варианты
            groupBoxOptions.Controls.Clear();

            // Добавляем новые варианты
            for (int i = 0; i < question.Options.Count; i++)
            {
                RadioButton radioButton = new RadioButton
                {
                    Text = question.Options[i],
                    Location = new System.Drawing.Point(10, 20 + i * 30),
                    AutoSize = true
                };
                groupBoxOptions.Controls.Add(radioButton);
            }

            labelResult.Text = "";

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
    }
}