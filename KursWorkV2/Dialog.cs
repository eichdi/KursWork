using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace DialogModel
{
    public interface IADE<T>
    {
        void Add(T parametr);
        bool Delete(int index);
        bool Delete(T parametr);
        bool Edit(T changed, T edit);
        T Get(int index);
    }

    public class AnswerElem
    {
        private string answer;
        private string jumpTo;

        public string Answer
        {
            //set
            //{
            //    if (!(value == null))
            //    {
            //        answer = value;
            //    }
            //}
            get
            {
                return answer;
            }
        }
        public string JumpTo
        {
            set
            {
                if (value != null)
                {
                    jumpTo = value;
                }
            }
            get
            {
                return jumpTo;
            }
        }
        public AnswerElem(string answer, string jumpTo)
        {
            this.answer = answer;
            this.jumpTo = jumpTo;
        }
        //public override string ToString()
        //{
        //    UnitS answerUnit = new UnitS("answer", answer);
        //    UnitS jumpToUnit = new UnitS("jumpTo", jumpTo);
        //    UnitS[] allUnit = { answerUnit, jumpToUnit };
        //    ObjectS obj = new ObjectS("AnswerClass", allUnit);
        //    return obj.ToString();
        //}
    }

    public class AnswerClass:IADE<AnswerElem>
    {
        private List<AnswerElem> answer;
        public AnswerElem[] Answer
        {
            get
            {
                return answer.ToArray();
            }
        }
        public void Add(AnswerElem parametr)
        {
            if (parametr != null)
            {
                if (this.answer == null)
                {
                    this.answer = new List<AnswerElem>();
                }
                this.answer.Add(parametr);
            }
            else
            {
                throw new ArgumentNullException("answer null");
            }
        }
        public bool Delete(int index)
        {
            AnswerElem a = Get(index);
            return Delete(a);
        }
        public bool Delete(AnswerElem parametr)
        {
            return this.answer.Remove(parametr);
        }
        public bool Edit(AnswerElem changed, AnswerElem edit)
        {
            if (Delete(changed))
            {
                Add(edit);
                return true;
            }
            else
                return false;
        }
        public AnswerElem Get(int index)
        {
            return answer[index];
        }
        public AnswerClass(AnswerElem[] answer)
        {
            if (answer != null)
                this.answer = answer.ToList();
            else
                this.answer = new List<AnswerElem>();
        }

        //public override string ToString()
        //{
        //    UnitS answerUnit = new UnitS("answer", answer.ToArray());
        //    UnitS[] allUnit = { answerUnit };
        //    ObjectS obj = new ObjectS("AnswerClass", allUnit);
        //    return obj.ToString();
        //}
    }

    public class QuestionElem
    {
        private AnswerClass answers;
        private string question ;

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
        public AnswerClass Answers
        {
            get
            {
                return this.answers;
            }
        }
        public QuestionElem(AnswerClass answers,string question)
        {
            if (answers == null)
            {
                this.answers = new AnswerClass(null);
            }
            else
            {
                this.answers = answers;
            }
            this.question = question;
        }
        //public override string ToString()
        //{
        //    UnitS answersUnit = new UnitS("answer", answers);
        //    UnitS questionUnit = new UnitS("jumpTo", question);
        //    UnitS[] allUnit = { answersUnit, questionUnit };
        //    ObjectS obj = new ObjectS("Question", allUnit);
        //    return obj.ToString();
        //}

    }

    public class QuestionClass:IADE<QuestionElem>
    {
        private List<QuestionElem> question;
        public QuestionClass(QuestionElem[] question)
        {
            if (question != null)
                this.question = question.ToList();
            else
                this.question = new List<QuestionElem>();
        }
        public QuestionElem[] Question
        {
            get
            {
                return question.ToArray();
            }
        }

        public void Add(QuestionElem parametr)
        {
            if (parametr != null)
            {
                if (this.question == null)
                {
                    this.question = new List<QuestionElem>();
                }
                this.question.Add(parametr);
            }
            else
            {
                throw new ArgumentNullException("question null");
            }
        }
        public bool Delete(int index)
        {
            QuestionElem q = Get(index);
            return Delete(q);
        }
        public bool Delete(QuestionElem parametr)
        {
            return this.question.Remove(parametr);
        }
        public bool Edit(QuestionElem changed, QuestionElem edit)
        {
            if (Delete(changed))
            {
                Add(edit);
                return true;
            }
            else
                return false;
        }
        public QuestionElem Get(int index)
        {
            return question[index];
        }

        //public override string ToString()
        //{
        //    UnitS questionUnit = new UnitS("answer", question.ToArray());
        //    UnitS[] allUnit = { questionUnit };
        //    ObjectS obj = new ObjectS("AnswerClass", allUnit);
        //    return obj.ToString();
        //}
    }


    public class DialogElem
    {
        private string name;
        private QuestionClass questions;
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
        public QuestionClass Questions
        {
            get
            {
                return questions;
            }
        }
        public DialogElem(QuestionClass questions, string name)
        {
            if (questions != null)
                this.questions = questions;
            else
                this.questions = new QuestionClass(null);
            this.name = name;
        }
        //public override string ToString()
        //{
        //    UnitS nameUnit = new UnitS("name", name);
        //    UnitS questionsUnit = new UnitS("questions", questions);
        //    UnitS[] allUnit = { nameUnit, nameUnit };
        //    ObjectS obj = new ObjectS("Question", allUnit);
        //    return obj.ToString();
        //}
    }

    public class DialogClass:IADE<DialogElem>
    {
        private List<DialogElem> dialogs = null;
        public DialogClass(DialogElem[] dialogs)
        {
            if (dialogs == null)
            {
                this.dialogs = new List<DialogElem>();
            }
            else
                this.dialogs = dialogs.ToList();
        }

        public void Add(DialogElem parametr)
        {
            if (parametr != null)
            {
                if (this.dialogs == null)
                {
                    this.dialogs = new List<DialogElem>();
                }
                this.dialogs.Add(parametr);
            }
            else
            {
                throw new ArgumentNullException("Dialog null");
            }
        }
        public bool Delete(int index)
        {
            DialogElem d = Get(index);
            return Delete(d);
        }
        public bool Delete(DialogElem parametr)
        {
            return this.dialogs.Remove(parametr);
        }
        public bool Edit(DialogElem changed, DialogElem edit)
        {
            if (Delete(changed))
            {
                Add(edit);
                return true;
            }
            else
                return false;
        }
        public DialogElem Get(int index)
        {
            return dialogs[index];
        }

        public DialogElem[] Dialogs
        {
            get
            {
                return dialogs.ToArray();
            }
        }
        //public override string ToString()
        //{
        //    UnitS dialogsUnit = new UnitS("dialogs", dialogs.ToArray());
        //    UnitS[] allUnit = { dialogsUnit };
        //    ObjectS obj = new ObjectS("DialogClass", allUnit);
        //    return obj.ToString();
        //}
    }
}

