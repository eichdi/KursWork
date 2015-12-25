using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AnswerClass
    {
        private string answer=null;
        private string jumpTo="";
        public string Answer
        {
            set
            {
                if (!(value == null))
                {
                    answer = value;
                }
            }
            get
            {
                return answer;
            }
        }
        public string JumpTo
        {
            set
            {
                jumpTo = value;
            }
            get
            {
                return jumpTo;
            }
        }
    }

    public class QuestionClass
    {
        private AnswerClass[] answers=null;
        private string question=null;
        public AnswerClass[] Answers
        {
            set
            {

                answers = value;



            }
            get
            {
                return answers;
            }
        }
        public AnswerClass AddAnswer
        {
            set
            {
                List<AnswerClass> tempList;
                if(answers!=null)
                    tempList = answers.ToList<AnswerClass>();
                else
                    tempList = new List<AnswerClass>();
                AnswerClass tempAnswer = new AnswerClass();
                tempAnswer = value;
                tempList.Add(tempAnswer);
                answers = tempList.ToArray();
            }
        }
        public string Question
        {
            set
            {
                if (value != null)
                {
                    question = value;
                }
            }
            get
            {
                return question;
            }
        }

        /*public QuestionClass(string[] Answers, string Question)
        {
            this.Answers = Answers;
            this.Question = Question;
        }
        public QuestionClass(string Question)
        {
            this.Question = Question;
        }*/
    }

    public class DialogClass
    {

        private string name=null;
        private QuestionClass[] questions=null;
        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }

            }
            get
            {
                return name;
            }
        }
        public QuestionClass[] Questions
        {
            set
            {
                if (value != null)
                {
                    questions = value;
                }

            }
            get
            {
                return questions;
            }
        }
        //public DialogClass(QuestionClass[] Questions, string Name)
        //{
        //    this.Questions = Questions;
        //    this.Name = Name;
        //}
        //public DialogClass(string Name)
        //{
        //    this.Name = Name;
        //    this.Questions = null;
        //}
   }

    public class DialogsClass
    {
        private DialogClass[] dialogs=null;
        public DialogClass[] Dialogs
        {
            set
            {
                dialogs = value;
            }
            get
            {
                return dialogs;
            }
        }
    }
