﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DialogModel;
using React;

namespace KursWorkV2
{
    
    class ProgressDialogController
    {
        //провайдер какой то
        private DialogClass dialogs;
        private int nowDialog=0;
        private int nowQuestion=0;
        private bool ready;
        private string _path;
        private ReactionToAnswer react = new ReactionToAnswer();

        public bool Ready
        {
            get
            {
                return ready;
            }
        }
        public DialogElem NowDialog
        {
            get 
            {
                try
                {
                    return dialogs.Dialogs[nowDialog];
                }
                catch
                {
                    return null;
                }
            }
        }
        public QuestionElem NowQuestion
        {
            get 
            {
                try
                {
                    return NowDialog.Questions.Question[nowQuestion];
                }
                catch
                {
                    return null;
                }
            }
        }

        public ProgressDialogController(DialogClass dialogs)
        {
            this.dialogs = dialogs;
        }
        public ProgressDialogController(DialogController controller)
        {
            this.dialogs = controller.Head;
        }
        public ProgressDialogController(string _path)
        {
            this._path = _path;
            //вызов провайдера по пути

            ready = dialogs!=null;

        }

        //к первому вопросу диалога
        private void ToStartNowDialog()
        {
            nowQuestion = 0;
        }
        //переход к следущему диалогу
        private bool NextDialog()
        {
            nowDialog++;
            if (NowDialog == null)
            {
                return false;
            }
            else
            {
                ToStartNowDialog();
                if (dialogs.Dialogs.Length > nowDialog && NowQuestion == null)
                {
                    return NextDialog();
                }
                else
                {
                    return true;
                }
            }
        }
        //переход к следущему вопросу
        private bool NextQuestion()
        {
            nowQuestion++;
            if (QuestonExistenceNext())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //существование следущего вопроса
        public bool QuestonExistenceNext()
        {
            if (NowQuestion == null)
            {
                if (NextDialog())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        //переход к следущему вопросу
        private void ToDialog(string nameDialog)
        {
            for (int i = 0; i < dialogs.Dialogs.Length; i++)
            {
                if (nameDialog == dialogs.Dialogs[i].Name)
                {
                    int save = nowDialog;
                    nowDialog = i;
                    if (NowDialog.Questions == null)
                    {
                        nowDialog = save;
                    }
                    else
                    {
                        ToStartNowDialog();
                    }
                    break;
                }
            }
        }

        public QuestionElem Next(AnswerElem answer)
        {
            string nextDialogName = react.Rection(answer.JumpTo);
            if (nextDialogName == null)
            {
                if (NextQuestion())
                {
                    return NowQuestion;
                }
                else
                {
                    ready = false;
                    return null;
                }
            }
            else
            {
                ToDialog(nextDialogName);
                if (QuestonExistenceNext())
                {
                    return NowQuestion;
                }
                else
                {
                    ready = false;
                    return null;
                }
            }
        }
    }
}
