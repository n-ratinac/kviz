using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kviz
{
    class Question
    {
        public string Text { get; private set; }
        public List<string> Answers { get; private set; }
        public int CorrectIndex { get; private set; }
        public int PointValue { get; private set; }

        public string Display(int n)
        {
            List<char> ABCD = new List<char> {'a', 'b', 'c', 'd'};
            int NumberOfAnswers = Answers.Count();
            string WholeText = "Pitanje broj :" + n + "\n" + Text + "\n";
            for (int i = 0; i < NumberOfAnswers; i++)
            {
                WholeText += ABCD[i];
                WholeText += Answers[i];
                WholeText += "\n";
            }
            return WholeText;
        
        
        }





    }
}
