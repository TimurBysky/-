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
            Console.WriteLine(selectedSubject);

            selectedTopic.Clear();
            foreach (var item in checkedListBoxTopics.CheckedItems) // Проверяем только отмеченные
            {
                selectedTopic.Add(item.ToString()); // Добавляем в список
                Console.WriteLine(item);
            }

            if (string.IsNullOrEmpty(selectedSubject) || selectedTopic.Count == 0 || selectedTopic.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Выберите предмет и хотя бы одну тему!");
                return;
            }

            var count = numericUpDownQuesNumber.Value;
            var randomQuestions= GenerateRandomQuestions((int)count);

            foreach(var q in randomQuestions)
            {
                Console.WriteLine("Вопрос: " + q.Question + "Тема :" + q.Topic);
            }
            
        }

        private List<QuizQuestion> GenerateRandomQuestions(int questionsPerTopic)
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
        }

        private void setLimits()
        {
            var filter = quiz.GetTopicCount(selectedSubject, selectedTopic);
            Console.WriteLine(filter);

            numericUpDownQuesNumber.Maximum = filter;

            if (numericUpDownQuesNumber.Value > numericUpDownQuesNumber.Maximum)
            {
                numericUpDownQuesNumber.Value = numericUpDownQuesNumber.Maximum;
            }
        }


        private void SaveLinesToTxtFile(IEnumerable<string> lines)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.Title = "Сохранить как текстовый файл";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, lines);
                    MessageBox.Show("Файл успешно сохранен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
                }
            }
        }


        private void checkedListBoxTopics_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Console.WriteLine("Клик по квадратику!");
            //setLimits();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Console.WriteLine(selectedSubject);

            selectedTopic.Clear();
            foreach (var item in checkedListBoxTopics.CheckedItems) // Проверяем только отмеченные
            {
                selectedTopic.Add(item.ToString()); // Добавляем в список
                Console.WriteLine(item);
            }

            if (string.IsNullOrEmpty(selectedSubject) || selectedTopic.Count == 0 || selectedTopic.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Выберите предмет и хотя бы одну тему!");
                return;
            }

            var billCount = numericUpDownTestsNumber.Value;
            var count = numericUpDownQuesNumber.Value;

            for(int i = 0; i <= billCount; i++)
            {
                var randomQuestions = GenerateRandomQuestions((int)count);

                Console.WriteLine("Билет №" + i + ":");

                foreach (var q in randomQuestions)
                {
                    Console.WriteLine("Вопрос: " + q.Question + "Тема :" + q.Topic);
                }
            }

        }
    }
}
