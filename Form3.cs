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

        void loadSubjects()
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

        void loadTopics(string subjectSelected)
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
            var select = sender as CheckedListBox;
            //selectedTopic.Clear();

            foreach (var item in select.CheckedItems) // Проверяем только отмеченные
            {
                selectedTopic.Add(item.ToString()); // Добавляем в список
                Console.WriteLine(item); // Выводим в консоль (для отладки)
            }

            //SaveLinesToTxtFile(selectedTopic);
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

        }
    }
}
