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
    public partial class Form5 : Form
    {
        private List<List<QuizQuestion>> _tickets;
        private List<UserAnswer> _userAnswers;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        public Form5(List<List<QuizQuestion>> tickets, List<UserAnswer> userAnswers)
        {
            InitializeComponent();
            ShowResults(tickets, userAnswers);
            _tickets = tickets;
            _userAnswers = userAnswers;


            // Подписываемся на событие двойного клика
            treeViewResults.NodeMouseDoubleClick += treeViewResults_NodeMouseDoubleClick;
        }

        private void ShowResults(List<List<QuizQuestion>> tickets, List<UserAnswer> userAnswers)
        {
            int totalQuestions = tickets.Sum(t => t.Count);
            int answeredQuestions = userAnswers.Count(a => a.SelectedOptionIndex != -1);
            int correctAnswers = 0;

            // Подсчет правильных ответов
            foreach (var answer in userAnswers)
            {
                if (answer.SelectedOptionIndex == tickets[answer.TicketIndex][answer.QuestionIndex].CorrectAnswerIndex)
                {
                    correctAnswers++;
                }
            }

            // Отображение общей статистики
            labelTotalQuestions.Text = $"Всего вопросов: {totalQuestions}";
            labelAnswered.Text = $"Отвечено: {answeredQuestions}";
            labelCorrect.Text = $"Правильных ответов: {correctAnswers}";
           //labelPercentage.Text = $"Процент правильных ответов: {Math.Round((double)correctAnswers / answeredQuestions * 100, 2)}%";

            // Детализация по билетам
            for (int ticketIndex = 0; ticketIndex < tickets.Count; ticketIndex++)
            {
                var ticket = tickets[ticketIndex];
                var ticketAnswers = userAnswers.Where(a => a.TicketIndex == ticketIndex).ToList();

                var ticketNode = treeViewResults.Nodes.Add($"Билет {ticketIndex + 1}");

                for (int questionIndex = 0; questionIndex < ticket.Count; questionIndex++)
                {
                    var question = ticket[questionIndex];
                    var answer = ticketAnswers.FirstOrDefault(a => a.QuestionIndex == questionIndex);

                    string status;
                    if (answer == null || answer.SelectedOptionIndex == -1)
                    {
                        status = "Не отвечено";
                    }
                    else if (answer.SelectedOptionIndex == question.CorrectAnswerIndex)
                    {
                        status = "Правильно";
                    }
                    else
                    {
                        status = "Неправильно";
                    }

                    ticketNode.Nodes.Add($"Вопрос {questionIndex + 1}: {status}");
                }
            }
        }

        private void treeViewResults_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Проверяем, что кликнули по вопросу (а не по билету)
            if (e.Node.Parent == null) return;

            // Получаем индексы билета и вопроса
            int ticketIndex = e.Node.Parent.Index;
            int questionIndex = e.Node.Index;

            // Получаем вопрос и ответ
            var question = _tickets[ticketIndex][questionIndex];
            var answer = _userAnswers.FirstOrDefault(a =>
                a.TicketIndex == ticketIndex &&
                a.QuestionIndex == questionIndex);

            // Формируем сообщение
            string message = $"Вопрос: {question.Question}\n\n" +
                            $"Варианты ответов:\n{string.Join("\n", question.Options.Select((o, i) => $"{i + 1}. {o}"))}\n\n";

            if (answer == null || answer.SelectedOptionIndex == -1)
            {
                message += "Вы не ответили на этот вопрос\n";
            }
            else
            {
                message += $"Ваш ответ: {question.Options[answer.SelectedOptionIndex]}\n";
            }

            message += $"Правильный ответ: {question.Options[question.CorrectAnswerIndex]}";

            // Показываем диалоговое окно
            MessageBox.Show(message, "Детали вопроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
