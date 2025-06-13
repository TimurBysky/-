using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp2
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Subject { get; set; }
        public string Topic { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }

    public class Quiz
    {
        public List<QuizQuestion> Questions { get; set; } = new List<QuizQuestion>();

        public void RemoveQuestion(int index)
        {
            if (index >= 0 && index < Questions.Count)
            {
                Questions.RemoveAt(index);
            }
        }

        public List<string> GetTopicBySubject(string selectedSubjects)
        {
            return Questions
                .Where(q => selectedSubjects==q.Subject)
                .Select(q => q.Topic)
                .ToList();
        }

        public int GetTopicCount(string selectedSubjects,List<string> selectedTopics)
        {
            return Questions
                .Count(q => q.Subject == selectedSubjects &&
                       selectedTopics.Contains(q.Topic));
        }
    }
}