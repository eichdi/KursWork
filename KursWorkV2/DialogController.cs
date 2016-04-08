using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DialogModel;
using Provider;

namespace KursWorkV2
{
    class DialogController
    {
        private DialogClass head;
        private DialogElem nowDialog;
        private QuestionElem nowQuestion;
        private AnswerElem nowAnswer;
        private string nowJumpTo;
        
        private string _path;

        public const string dialogState = "DIALOG";
        public const string questionState = "QUESTION";
        public const string answersState = "ANSWER";
        public const string jumpToState = "JUMPTO";

        private string state;

        //Свойства
        public string NowState
        {
            get
            {
                return state;
            }
        }
        public DialogClass Head
        {
            get
            {
                return new DialogClass(head.Dialogs);
            }
        }
        public DialogElem NowDialog
        {
            get
            {
                return nowDialog;
            }
        }
        public QuestionElem NowQuestion
        {
            get
            {
                return nowQuestion;
            }
        }
        public AnswerElem NowAnswer
        {
            get
            {
                return nowAnswer;
            }
        }
        public string NowJumpTo
        {
            get
            {
                return nowJumpTo;
            }
        }


        public DialogController(string _path, DialogClass head)
        {
            this._path = _path;
            if (head == null)
            {
                this.head = new DialogClass(null);
            }
            else
            {
                this.head = head;
            }
            state = dialogState;
        }
        

        //Показ содержимого по состоянию
        public string[] Show()
        {
            return Show(state);
        }
        public string[] Show(string state)
        {
            switch (state)
            {
                case dialogState:
                    return ShowDialog(head);
                case questionState:
                    return ShowQuestion(nowDialog.Questions);
                case answersState:
                    return ShowAnswer(nowQuestion.Answers);
                case jumpToState:
                    return ShowJumpTo(nowAnswer);
            }
            return null;
        }

        public void Load(string path)
        {
            head = DialogProvider.Open(path);
        }
        public void Load()
        {
            Load(this._path);
        }
        public void Save(string path)
        {
            DialogProvider.Save(path, head);
        }
        public void Save()
        {
            Save(_path);
        }

        //Выполняет переход к другому состоянию контроллера

        public bool DownToState(string toState, int index)
        {
            try
            {
                switch (toState)
                {
                    case dialogState:
                        if (head.Dialogs[index] != null)
                        {
                            nowDialog = head.Dialogs[index];
                            this.state = toState;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case questionState:
                        if (nowDialog.Questions != null)
                        {
                            this.state = toState;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case answersState:
                        if (nowQuestion.Answers != null)
                        {
                            this.state = toState;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case jumpToState:
                        if (nowAnswer!=null)
                        {
                            nowJumpTo = nowAnswer.JumpTo;
                            this.state = toState;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool DownToState(int index)
        {
            switch (this.state)
            {
                case dialogState:
                    return DownToState(questionState, index);
                case questionState:
                    return DownToState(answersState, index);
                case answersState:
                    return DownToState(jumpToState, index);
                case jumpToState:
                    return true;
            }
            return false;
        }
        public void UpToState(string toState)
        {
            this.state = toState;
        }
        public void UpToState()
        {
            switch (this.state)
            {
                case dialogState:
                    this.state = dialogState; //выше незя
                    break;
                case questionState:
                    this.state = dialogState;
                    break;
                case answersState:
                    this.state = questionState;
                    break;
                case jumpToState:
                    this.state = answersState;
                    break;
            }
        }

        //Функция определяет какой элемент сделать рабочим
        //Работает при любом состоянии контроллера 
        public bool ChoseEnterByNowState(int index)
        {
            try
            {
                switch (this.state)
                {
                    case dialogState:
                        if (Head.Dialogs[index] != null)
                        {
                            nowDialog = Head.Dialogs[index];
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case questionState:
                        if (nowDialog.Questions.Question[index] != null)
                        {
                            nowQuestion = nowDialog.Questions.Question[index];
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case answersState:
                        if (nowQuestion.Answers.Answer[index] != null)
                        {
                            nowAnswer = nowQuestion.Answers.Answer[index];
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case jumpToState:
                        if (NowAnswer != null)
                        {
                            nowJumpTo = nowAnswer.JumpTo;
                            return true;
                        }
                        else
                        {

                            return false;
                        }
                }
                return false;
            }
            catch
            {
                return false;
            }
           
        }

        //Переобразование информации классов в строки
        protected string[] ShowDialog(DialogClass nowDialogs)
        {
            try
            {
                string[] toList = new string[nowDialogs.Dialogs.Length];
                for (int i = 0; i < toList.Length; i++)
                {
                    toList[i] = nowDialogs.Dialogs[i].Name;
                }
                
                return toList;
            }
            catch (Exception)
            {
                return null;
            }
        }
        protected string[] ShowQuestion(QuestionClass nowQuestions)
        {
            try
            {
                string[] toList = new string[nowQuestions.Question.Length];
                for (int i = 0; i < toList.Length; i++)
                {
                    toList[i] = nowQuestions.Question[i].Question;
                }

                return toList;
            }
            catch (Exception)
            {
                return null;
            }

        }
        protected string[] ShowAnswer(AnswerClass nowAnswers)
        {
            try
            {
                string[] toList = new string[nowAnswers.Answer.Length];
                for (int i = 0; i < toList.Length; i++)
                {
                    toList[i] = nowAnswers.Answer[i].Answer;
                }
                
                return toList;
            }
            catch (Exception)
            {
                return null;
            }
        }
        protected string[] ShowJumpTo(AnswerElem answer)
        {
            string[] toList = new string[1];
            toList[0] = answer.JumpTo;
            return toList;
        }

        //nocomments
        public void Add(string text)
        {
            switch (NowState)
            {
                case DialogController.dialogState:
                    Head.Add(new DialogElem(null, text));
                    break;
                case DialogController.questionState:
                    NowDialog.Questions.Add(new QuestionElem(null, text));
                    break;
                case DialogController.answersState:
                    NowQuestion.Answers.Add(new AnswerElem(text, ""));
                    break;
                case DialogController.jumpToState:
                    break;
            }
        }
        public bool Delete()
        {
            switch (this.state)
            {
                case DialogController.dialogState:
                    return Head.Delete(nowDialog);
                case DialogController.questionState:
                    return NowDialog.Questions.Delete(nowQuestion);
                case DialogController.answersState:
                    return NowQuestion.Answers.Delete(nowAnswer);
                case DialogController.jumpToState:
                    nowAnswer = new AnswerElem(nowAnswer.Answer, "");
                    return nowAnswer != null;
            }
            return false;
        }
        public bool Edit(string text)
        {
            switch (NowState)
            {
                case DialogController.dialogState:
                    return Head.Edit(nowDialog, new DialogElem(nowDialog.Questions, text));
                case DialogController.questionState:
                    return NowDialog.Questions.Edit(nowQuestion, new QuestionElem(nowQuestion.Answers, text));
                case DialogController.answersState:
                    return NowQuestion.Answers.Edit(nowAnswer, new AnswerElem(text, nowAnswer.JumpTo));
                case DialogController.jumpToState:
                    NowAnswer.JumpTo = text;
                    return true;
            }
            return false;
        }

        //не сбылись мечты с интерфесом Т_Т
        /*
        public void Add(IADE<T> classParam, T parametr)
        {
            classParam.Add(parametr);
        }
        public bool Delete(IADE<T> classParam, int index)
        {
            return classParam.Delete(index);
        }
        public bool Delete(IADE<T> classParam, T parametr)
        {
            return classParam.Delete(parametr);
        }
        public bool Edit(IADE<T> classParam, T changed, T edit)
        {
            return classParam.Edit(changed, edit);
        }
        public T Get(IADE<T> classParam, int index)
        {
            return classParam.Get(index);
        }
        */
    }
}
