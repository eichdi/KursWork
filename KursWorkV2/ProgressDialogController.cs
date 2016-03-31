using System;
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
        private void ToStartNowDialog()
        {
            nowQuestion = 0;
        }


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
        public QuestionElem NextQuestion()
        {
            nowQuestion++;
            if (NowQuestion == null)
            {
                if (NextDialog())
                {
                    return NowQuestion;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return NowQuestion;
            }
        }
        public QuestionElem Next()
        {
            return NextQuestion();
        }
    }
}
