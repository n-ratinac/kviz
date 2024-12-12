using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kviz
{
    internal class QuestionBank
    {
        public List<Question> QList { get; set; }

        public QuestionBank()
        {
            QList = new List<Question>();
        }

        public void AddQuestion(Question q)
        {
            QList.Add(q);
        }

        public void DeleteQuestion(int ID)
        {
            Question q = QList.Where(x => x.ID == ID).First();
            QList.Remove(q);
        }

        public void ListQuestions()
        {
            foreach (Question q in QList)
            {
                Console.WriteLine(q.ToString());
            }
        }

        public List<Question> RandomQuestions(int n, int m)
        {


        }
    }
