using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        private List<List<QuizQuestion>> tickets;
        private int currentTicketIndex = -1;
        private int currentQuestionIndex = 0;
        private List<UserAnswer> userAnswers = new List<UserAnswer>();

        public Form4(List<List<QuizQuestion>> generatedTickets)
        {
            InitializeComponent();
            tickets = generatedTickets ?? throw new ArgumentNullException(nameof(generatedTickets));
            LoadFirstTicket();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void LoadFirstTicket()
        {
            if (tickets.Count > 0)
            {
                currentTicketIndex = 0;
                LoadTicket(currentTicketIndex);
            }
            else
            {
                MessageBox.Show("Нет билетов для отображения");
                Close();
            }
        }

        private void LoadTicket(int ticketIndex)
        {
            if (ticketIndex < 0 || ticketIndex >= tickets.Count) return;

            // Обновляем номер билета
            labelTicket.Text = $"Билет №{ticketIndex + 1} из {tickets.Count}";

            // Загружаем вопросы текущего билета
            var currentTicket = tickets[ticketIndex];
            listBoxQuestions.Items.Clear();
            foreach (var question in currentTicket)
            {
                listBoxQuestions.Items.Add(question.Question);
            }

            // Показываем первый вопрос билета
            currentQuestionIndex = 0;
            ShowQuestion(currentTicket[currentQuestionIndex]);
        }

        private void ShowQuestion(QuizQuestion question)
        {
            // Обновляем информацию о вопросе
            labelQuestion.Text = question.Question;
            labelSubject.Text = $"Предмет: {question.Subject}";
            labelTopic.Text = $"Тема: {question.Topic}";

            // Выделяем текущий вопрос в ListBox
            if (currentQuestionIndex >= 0 && currentQuestionIndex < listBoxQuestions.Items.Count)
            {
                listBoxQuestions.SelectedIndex = currentQuestionIndex;
            }

            // Очищаем предыдущие варианты ответов
            groupBoxOptions.Controls.Clear();

            // Добавляем новые варианты ответов
            for (int i = 0; i < question.Options.Count; i++)
            {
                var radioButton = new RadioButton
                {
                    Text = question.Options[i],
                    Tag = i, // Сохраняем индекс правильного ответа
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 20 + i * 30)
                };
                groupBoxOptions.Controls.Add(radioButton);
            }

            // Восстанавливаем сохраненный ответ, если он есть
            var savedAnswer = userAnswers.Find(a =>
                a.TicketIndex == currentTicketIndex &&
                a.QuestionIndex == currentQuestionIndex);

            if (savedAnswer != null)
            {
                if (savedAnswer.SelectedOptionIndex >= 0 &&
                    savedAnswer.SelectedOptionIndex < groupBoxOptions.Controls.Count)
                {
                    ((RadioButton)groupBoxOptions.Controls[savedAnswer.SelectedOptionIndex]).Checked = true;
                }
            }
        }

        private void SaveCurrentAnswer()
        {
            int selectedOption = -1;
            foreach (Control control in groupBoxOptions.Controls)
            {
                if (control is RadioButton radio && radio.Checked)
                {
                    selectedOption = (int)radio.Tag;
                    break;
                }
            }

            // Обновляем или добавляем ответ пользователя
            var existingAnswer = userAnswers.FindIndex(a =>
                a.TicketIndex == currentTicketIndex &&
                a.QuestionIndex == currentQuestionIndex);

            if (existingAnswer >= 0)
            {
                userAnswers[existingAnswer].SelectedOptionIndex = selectedOption;
            }
            else
            {
                userAnswers.Add(new UserAnswer
                {
                    TicketIndex = currentTicketIndex,
                    QuestionIndex = currentQuestionIndex,
                    SelectedOptionIndex = selectedOption
                });
            }
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            // Сохраняем текущий ответ
            SaveCurrentAnswer();

            // Переходим к следующему вопросу или билету
            var currentTicket = tickets[currentTicketIndex];
            //currentQuestionIndex++;


            if (currentQuestionIndex >= currentTicket.Count -1 )
            {
                // Переходим к следующему билету
                currentTicketIndex++;
                currentQuestionIndex = 0;

                if (currentTicketIndex >= tickets.Count)
                {
                    currentTicketIndex = 0; // Зацикливаем или закрываем форму
                    MessageBox.Show("Вы ответили на все билеты!");
                    return;
                }

                LoadTicket(currentTicketIndex);
            }
            else
            {
                listBoxQuestions.SelectedIndex++;
                currentQuestionIndex = listBoxQuestions.SelectedIndex;
                // Показываем следующий вопрос в текущем билете
                ShowQuestion(currentTicket[currentQuestionIndex]);
            }
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentTicket = tickets[currentTicketIndex];

            if (listBoxQuestions.SelectedIndex >= 0 &&
                currentTicketIndex >= 0 &&
                currentTicketIndex < tickets.Count)
            {
                // Сохраняем текущий ответ
                SaveCurrentAnswer();

                // Показываем выбранный вопрос
                currentQuestionIndex = listBoxQuestions.SelectedIndex;
                ShowQuestion(currentTicket[currentQuestionIndex]);
            }
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer(); // Сохраняем текущий ответ перед показом результатов

            var resultsForm = new Form5(tickets, userAnswers);
            resultsForm.ShowDialog();
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }
    }



    public class UserAnswer
    {
        public int TicketIndex { get; set; }
        public int QuestionIndex { get; set; }
        public int SelectedOptionIndex { get; set; }
    }
}