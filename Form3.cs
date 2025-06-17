using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private Quiz quiz;
        private string selectedSubject;
        private List<string> selectedTopic = new List<string>();
        private readonly Random random = new Random();
        private HashSet<int> usedQuestionIds = new HashSet<int>(); // Для отслеживания использованных вопросов

        private List<List<QuizQuestion>> generatedTickets = new List<List<QuizQuestion>>();

        public Form3(Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadSubjects();
            loadTopics(null);
        }

        private void loadSubjects()
        {
            HashSet<string> setSubjects = new HashSet<string>();//Удаляет дубликаты 
            //var question = quiz.Questions[currentQuestionIndex];

            foreach (var subject in quiz.Questions)
            {
                setSubjects.Add(subject.Subject);
            }

            for(int i = 0; i < setSubjects.Count; i ++)
            {
                RadioButton radioButton = new RadioButton
                {
                    Text = setSubjects.ToList()[i],
                    Location = new System.Drawing.Point(10, 20 + i * 15),
                    AutoSize = true,
                    
                };
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                groupBox1.Controls.Add(radioButton);
            }

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRatio = sender as RadioButton;
            if(selectedRatio != null && selectedRatio.Checked)
            {
                selectedSubject = selectedRatio.Text;
            }
            loadTopics(selectedSubject);
            //throw new NotImplementedException();
        }

        private void loadTopics(string subjectSelected)
        {
            checkedListBoxTopics.Items.Clear();

            checkedListBoxTopics.DisplayMember = "Topic"; // Показываем текст вопроса

            var filter = quiz.GetTopicBySubject(subjectSelected);
            filter = filter.Distinct().ToList();//Удаляет дубликаты (да, также)
            
            checkedListBoxTopics.Items.AddRange(filter.ToArray());
            
            //if(checkedListBoxSubjects.SelectedItems.Contains())

        }


        private void buttonSaveToRTF_Click(object sender, EventArgs e)
        {
            // 1. Инициализация
            generatedTickets.Clear();

            // 2. Сбор выбранных тем (без очистки usedQuestionIds здесь!)
            selectedTopic.Clear();
            foreach (var item in checkedListBoxTopics.CheckedItems)
            {
                selectedTopic.Add(item.ToString());
            }

            // 3. Проверка ввода
            if (string.IsNullOrEmpty(selectedSubject) || selectedTopic.Count == 0)
            {
                MessageBox.Show("Выберите предмет и хотя бы одну тему!");
                return;
            }

            int testsCount = (int)numericUpDownTestsNumber.Value;
            int questionsPerTopic = (int)numericUpDownQuesNumber.Value;
            bool allowDuplicates = true;

            if (testsCount <= 0 || questionsPerTopic <= 0)
            {
                MessageBox.Show("Количество билетов и вопросов должно быть больше 0!");
                return;
            }

            // 4. Генерация билетов
            for (int i = 0; i < testsCount; i++)
            {
                var testQuestions = GenerateTestQuestions(questionsPerTopic, true);

                if (testQuestions.Count == 0)
                {
                    MessageBox.Show($"Не удалось сгенерировать билет №{i + 1}. Вопросы закончились!");
                    break;
                }

                generatedTickets.Add(testQuestions);
            }

            // 5. Сохранение в файл
            SaveTicketsToFile(generatedTickets);
        }

        private void SaveTicketsToFile(List<List<QuizQuestion>> tickets)
        {
            var withAnswerVariants = false;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Файлы RTF (*.rtf)|*.rtf|Все файлы (*.*)|*.*",
                Title = "Сохранить билеты"
            };


            if (MessageBox.Show("Создать билеты с вариантами ответов?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                withAnswerVariants = true;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var lines = new List<string>();

                    for (int i = 0; i < tickets.Count; i++)
                    {
                        lines.Add($"=== Билет №{i + 1} ===");
                        lines.Add($"Предмет: {selectedSubject}");
                        lines.Add($"Темы: {string.Join(", ", selectedTopic)}");
                        lines.Add("");

                        foreach (var question in tickets[i])
                        {
                            lines.Add($"Вопрос: {question.Question}");
                            lines.Add($"Тема: {question.Topic}");
                            if(withAnswerVariants)
                            {
                                lines.Add($"Варианты: {string.Join(", ", question.Options)}");
                            }
                            //lines.Add($"Правильный ответ: {question.Options[question.CorrectAnswerIndex]}");
                            lines.Add("");
                        }

                        lines.Add(new string('-', 40));
                        lines.Add("");
                    }

                    File.WriteAllLines(saveFileDialog.FileName, lines);
                    MessageBox.Show($"Сохранено {tickets.Count} билетов в файл!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                }
            }
        }

        /*private List<QuizQuestion> GenerateRandomQuestions(int questionsPerTopic)
        {
            var result = new List<QuizQuestion>();
            Random random = new Random();

            foreach (var topic in selectedTopic)
            {
                var topicQuestions = quiz.Questions
                    .Where(q => q.Subject == selectedSubject && q.Topic == topic)
                    .OrderBy(q => random.Next())
                    .Take(questionsPerTopic)
                    .ToList();

                result.AddRange(topicQuestions);
            }

            return result.OrderBy(q => random.Next()).ToList();
        }*/

        private void SetLimits()
        {
            var filter = quiz.GetTopicCount(selectedSubject, selectedTopic);
            Console.WriteLine(filter);

            numericUpDownQuesNumber.Maximum = filter;

            if (numericUpDownQuesNumber.Value > numericUpDownQuesNumber.Maximum)
            {
                numericUpDownQuesNumber.Value = numericUpDownQuesNumber.Maximum;
            }
        }


     


        private void checkedListBoxTopics_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Console.WriteLine("Клик по квадратику!");
            //setLimits();
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            generatedTickets.Clear();
            usedQuestionIds.Clear();
            // Сбор выбранных тем
            selectedTopic.Clear();
            foreach (var item in checkedListBoxTopics.CheckedItems)
            {
                selectedTopic.Add(item.ToString());
            }

            // Проверка ввода
            if (string.IsNullOrEmpty(selectedSubject) || selectedTopic.Count == 0)
            {
                MessageBox.Show("Выберите предмет и хотя бы одну тему!");
                return;
            }

            int testsCount = (int)numericUpDownTestsNumber.Value;
            int questionsPerTopic = (int)numericUpDownQuesNumber.Value;
            bool allowDuplicates = true;

            if (testsCount <= 0 || questionsPerTopic <= 0)
            {
                MessageBox.Show("Количество билетов и вопросов должно быть больше 0!");
                return;
            }

            // Сброс списка использованных вопросов, если разрешены повторы или при новом запуске
            if (allowDuplicates) usedQuestionIds.Clear();

            // Генерация билетов
            for (int i = 0; i < testsCount; i++)
            {
                var testQuestions = GenerateTestQuestions(questionsPerTopic, true);

                Console.WriteLine($"\nБилет №{i + 1}:");
                foreach (var q in testQuestions)
                {
                    Console.WriteLine($"- Вопрос: {q.Question} (Тема: {q.Topic})");
                    if (!allowDuplicates) usedQuestionIds.Add(q.Id); // Запоминаем использованные вопросы
                }
                generatedTickets.Add(testQuestions);
            }

            //Создаём окно с тестами и закрываем нынешнее
            var newForm = new Form4(generatedTickets);
            newForm.Show();
            this.Hide();
        }

        private List<QuizQuestion> GenerateTestQuestions(int questionsPerTopic, bool allowDuplicates)
        {
            var testQuestions = new List<QuizQuestion>();
            var questionsByTopic = new Dictionary<string, List<QuizQuestion>>();

            // Группируем вопросы по темам
            foreach (var topic in selectedTopic)
            {
                var topicQuestions = quiz.Questions
                    .Where(q => q.Subject == selectedSubject &&
                               q.Topic == topic &&
                               (allowDuplicates || !usedQuestionIds.Contains(q.Id)))
                    .OrderBy(q => random.Next())
                    .Take(questionsPerTopic)
                    .ToList();

                questionsByTopic[topic] = topicQuestions;
            }

            // Проверяем, хватает ли вопросов
            foreach (var topic in questionsByTopic)
            {
                if (topic.Value.Count < questionsPerTopic)
                {
                    MessageBox.Show($"Недостаточно вопросов по теме '{topic.Key}'. Доступно: {topic.Value.Count}, требуется: {questionsPerTopic}");
                    return new List<QuizQuestion>();
                }
            }

            // Формируем билет
            foreach (var topic in questionsByTopic)
            {
                testQuestions.AddRange(topic.Value.Take(questionsPerTopic));
            }

            // Перемешиваем вопросы в билете
            return testQuestions.OrderBy(q => random.Next()).ToList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
