using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public string Subject { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }

    public class Quiz
    {
        public List<QuizQuestion> Questions { get; set; } = new List<QuizQuestion>();
    }
}