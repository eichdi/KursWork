using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DialogModel;
using Provider;

namespace LogMove
{
    class AnswerMove : AnswerElem
    {
        private bool selected=false;
        public bool Selected
        {
            get
            {
                return selected;
            }
            set{
                if(value !=true)
                {
                    selected = value;
                }
            }
        }

        public override bool Equals(AnswerElem obj)
        {
            return obj.Answer == this.Answer && obj.JumpTo == this.JumpTo;
        }
    }
    class QuestionMove
    {
        private string question;
        private AnswerMove[] answer;

        public string Question
        {
            get
            {
                return question;
            }
        }
        public AnswerElem[] Answer
        {
            get
            {
                if(answer!=null)
                    return answer;
                else
                    return null;
            }
        }
        public QuestionMove(QuestionElem quest)
        {
            if (quest != null)
            {
                this.answer = (AnswerMove[]) quest.Answers.Answer;
                this.question = quest.Question;
            }
            else 
            {
                throw new ArgumentNullException("quest");
            }
        }
        public QuestionMove(QuestionElem quest, AnswerElem selected)
        {
            if (quest != null)
            {
                this.answer = (AnswerMove[])quest.Answers.Answer;
                this.question = quest.Question;
                SelectAnser(selected);
            }
            else
            {
                throw new ArgumentNullException("quest");
            }
        }
        public bool SelectAnser(int index)
        {
            return answer[index].Select(this);
        }
        public bool SelectAnser(AnswerElem answer)
        {
            AnswerMove result = null;
            foreach (AnswerMove ansMove in this.answer)
            {
                if (ansMove.Equals(answer))
                {
                    if(result == null)
                        result = ansMove;
                    else
                        return false;
                }
                if (ansMove.Selected == true)
                {
                    return false;
                }
            }
            if(result !=null)
            {
                result.Selected=true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class LogDialog
    {
        private QuestionMove[] questions;
        public QuestionMove[] Questions
        {
            get
            {
                return questions;
            }
        }
        public void AddQuestion(QuestionElem question)
        {
            List<QuestionMove> temp = questions.ToList();
            temp.Add(new QuestionMove(question));
            questions = temp.ToArray();
        }
        public void AddQuestion(QuestionMove question)
        {
            List<QuestionMove> temp = questions.ToList();
            temp.Add(question);
            questions = temp.ToArray();
        }
        
    }
}
