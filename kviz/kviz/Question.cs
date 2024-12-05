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


    }
}
