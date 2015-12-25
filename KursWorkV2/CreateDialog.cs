using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace KursWorkV2
{

    public partial class CreateDialog : Form
    {
        private DialogsClass dialogs;
        private string _path;
        int id_dialog;
        int id_question;
        int id_answer;
        bool enterrow=false;
        int _state = 0;//0-dialogs //1 question // 2 answers //3 JumpTo
        public CreateDialog()
        {
            InitializeComponent();
            FileDialog.DefaultExt = "*.json";
            string directory = Application.StartupPath;
            FileDialog.InitialDirectory = directory;
        }
        public bool Enterrow()
        {
            if (!enterrow)
            {
                MessageBox.Show("Выберите строку");
            }
            return enterrow;
        }
        public void Show()
        {
            switch (_state)
            {
                case 0:
                    ShowDialogs();
                    break;
                case 1:
                    ShowQuestion(NowDialog);
                    break;
                case 2:
                    ShowAnswer(NowQuestion);
                    break;
                case 3:
                    ShowJump(NowAnswer);
                    break;

            }
        }
        public DialogClass NowDialog
        {
            get
            {
                return dialogs.Dialogs[id_dialog];
            }
            set
            {
                dialogs.Dialogs[id_dialog] = value;
            }
        }
        public QuestionClass NowQuestion
        {
            get
            {

                return NowDialog.Questions[id_question];
            }
            set
            {
                NowDialog.Questions[id_question] = value;
            }
        }
        public AnswerClass NowAnswer
        {
            get
            {
                return NowQuestion.Answers[id_answer];
            }
            set
            {
                NowQuestion.Answers[id_answer] = value;
            }
        
        }
        public void ShowToListBox(string[] elements)
        {
            DataTable dt = new DataTable();
            string nameCol = "";
            switch (_state)
            {
                case 0:
                    nameCol = "Dialogs";
                    break;
                case 1:
                    nameCol = "Questions";
                    break;
                case 2:
                    nameCol = "Answers";
                    break;
                case 3:
                    nameCol = "Jump To";
                    break;

            }
            DataColumn col = new DataColumn(nameCol, typeof(String));
            dt.Columns.Add(col);
            DataRow newRow = null;
            for (int i = 0; elements != null && i < elements.Length; i++)
            {
                newRow = dt.NewRow();
                newRow[nameCol] = elements[i];
                dt.Rows.Add(newRow);
            }


            Grid.DataSource = dt;
            enterrow = false;
        }
        
        public void ShowDialogs()
        {
            try
            {
                string[] toList = new string[dialogs.Dialogs.Length];
                for (int i = 0; i < toList.Length; i++)
                {
                    toList[i] = dialogs.Dialogs[i].Name;
                }
                ShowToListBox(toList);
            }
            catch (Exception)
            {
                ShowToListBox(null);
            }
            State_Dialog();
        }
        public void ShowQuestion(DialogClass dialog)
        {
            string[] toList;
            if (dialog.Questions != null) { 
                toList = new string[dialog.Questions.Length];
            
                for (int i = 0; i < toList.Length; i++)
                {
                    toList[i] = dialog.Questions[i].Question;
                }
                ShowToListBox(toList);
            }
            else 
            {
                ShowToListBox(null);
            }
            State_Question();
        
        }
        public void ShowAnswer(QuestionClass question)
        {
            if (question.Answers != null)
            {
                string[] toList = new string[question.Answers.Length];
                for (int i = 0; i < toList.Length; i++)
                {
                    toList[i] = question.Answers[i].Answer;
                }
                ShowToListBox(toList);
                State_Answer();
            }
            else
            {
                ShowToListBox(null);
                State_Answer();
                
            }
        }
        public void ShowJump(AnswerClass answer)
        {
            string[] toList = new string[1];
            toList[0] = NowAnswer.JumpTo;
            ShowToListBox(toList);
            State_JumpTo();
        }

        
        public void SaveJson()
        {
            StreamWriter sw = new StreamWriter(_path);
            sw.Write(JsonConvert.SerializeObject(dialogs));
            sw.Flush();
            sw.Close();
        }


        public void State_Dialog()
        {
            LableText.Text = "Диалоги";
            LableText.Visible = true;
            delete.Visible = true;
            textBox.Text = "";
            textBox.Visible = true;
            add.Visible = true;
            edit.Visible = true;
            enter.Visible = true;
            back.Visible = false;
        }
        public void State_Question()
        {
            LableText.Text = "Вопросы диалога - "+NowDialog.Name;
            LableText.Visible = true;
            textBox.Text = "";

            delete.Visible = true;
            textBox.Visible = true;
            add.Visible = true;
            edit.Visible = true;
            enter.Visible = true;
            back.Visible = true;
        }
        public void State_Answer()
        {
            delete.Visible = true;
            LableText.Text = "Ответы вопроса - "+ NowQuestion.Question;
            LableText.Visible = true;
            textBox.Visible = true;
            textBox.Text = "";
            add.Visible = true;
            edit.Visible = true;
            enter.Visible = true;
            back.Visible = true;
        }
        public void State_JumpTo()
        {
            LableText.Text = "После ответа \"" + NowAnswer.Answer + "\" переходить в какой диалог";
            LableText.Visible = true;
            textBox.Visible = true;
            textBox.Text = "";
            add.Visible = false;
            edit.Visible = true;
            enter.Visible = false;
            back.Visible = true;
        }


        public void AddDialog()
        {
            List<DialogClass> dialoglist;
            if (dialogs.Dialogs != null)
            {
                dialoglist = dialogs.Dialogs.ToList<DialogClass>();
            }
            else
            {
                dialoglist = new List<DialogClass>();
            }
            DialogClass dio = new DialogClass();
            dio.Name = textBox.Text;
            dialoglist.Add(dio);
            dialogs.Dialogs = dialoglist.ToArray();
        }
        public void AddQuestion()
        {
            List<QuestionClass> questlist;
            if (NowDialog.Questions!=null)
                questlist = NowDialog.Questions.ToList<QuestionClass>();
            else
            {
                questlist = new List<QuestionClass>();
            }
            QuestionClass que = new QuestionClass();
            que.Question = textBox.Text;
            questlist.Add(que);
            NowDialog.Questions = questlist.ToArray();
        }
        public void AddAnswer()
        {
            List<AnswerClass> anslist;
            if (NowQuestion.Answers != null)
                anslist = NowQuestion.Answers.ToList<AnswerClass>();
            else
                anslist = new List<AnswerClass>();
            AnswerClass ans =  new AnswerClass();
            ans.Answer = textBox.Text;
            anslist.Add(ans);
            NowQuestion.Answers = anslist.ToArray();
        }
        public void AddJumpTo()
        {
            NowAnswer.JumpTo = textBox.Text;
        }


        private void FileDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void созадтьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LableText.Visible = true;
            LableText.Text = "Введите имя файла";

            enter.Visible = true;
            textBox.Visible=  true;
        }
        //end
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FileDialog.ShowDialog();
                try
                {
                    _path = FileDialog.FileName;
                    StreamReader sr = new StreamReader(_path);
                    
                    dialogs = JsonConvert.DeserializeObject<DialogsClass>(sr.ReadToEnd());
                    ShowDialogs();
                    sr.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Такого файла нет");
                }
            
        }

        
        //end
        private void какСозаватьДиалогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpDialog temp = new HelpDialog();
            temp.Show();
        }
        //end
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveJson();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (LableText.Text == "Введите имя файла")
            {
                _path = textBox.Text;
                dialogs = new DialogsClass();
                _state = 0;
                ShowDialogs();

            }
            else
            {
                if (Enterrow())
                {
                    switch (_state)
                    {
                        case 0:
                            //if(NowDialog.Questions!=null)
                            _state = 1;
                            break;
                        case 1:
                            //if(NowQuestion.Answers!=null)
                            _state = 2;
                            break;
                        case 2:
                            //if(NowAnswer.JumpTo!=null)
                            _state = 3;
                            break;
                        case 3:
                            break;

                    }
                }
                Show();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            //0-dialogs //1 question // 2 answers //3 JumpTo
            switch (_state)
            {
                case 0:
                    AddDialog();
                    break;
                case 1:
                    AddQuestion();
                    break;
                case 2:
                    AddAnswer();
                    break;
                case 3:
                    AddJumpTo();
                    break;

            }
            Show();

        }
        
        public void DeleteDialog()
        {
            if (Enterrow())
            {
                List<DialogClass> deletelist = dialogs.Dialogs.ToList();
                deletelist.RemoveAt(id_dialog);
                dialogs.Dialogs = deletelist.ToArray();
            }
        }
        public void DeleteQuestion()
        {
            if (Enterrow())
            {
                List<QuestionClass> deletelist = NowDialog.Questions.ToList();
                deletelist.RemoveAt(id_question);
                NowDialog.Questions = deletelist.ToArray();
            }
        }
        public void DeleteAnswer()
        {

            if (Enterrow())
            {
                List<AnswerClass> deletelist = NowQuestion.Answers.ToList();
                deletelist.RemoveAt(id_answer);
                NowQuestion.Answers = deletelist.ToArray();
            }
        }
        public void DeleteJumpTo()
        {
                NowAnswer.JumpTo = "";
        }

        public void EditDialog()
        {

            if (Enterrow())
                NowDialog.Name = textBox.Text;
        }
        public void EditQuestion()
        {
            if (Enterrow())
                NowQuestion.Question = textBox.Text;
        }
        public void EditAnswer()
        {
            if (Enterrow())
                NowAnswer.Answer = textBox.Text;
        }
        public void EditJumpTo() 
        {
                NowAnswer.JumpTo = textBox.Text;
        }



        private void edit_Click(object sender, EventArgs e)
        {
            switch (_state)
            {
                case 0:
                    EditDialog();
                    break;
                case 1:
                    EditQuestion();
                    break;
                case 2:
                    EditAnswer();
                    break;
                case 3:
                    EditJumpTo();
                    break;

            }
            Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            switch (_state)
            {
                case 0:
                    //не доходит
                    break;
                case 1:
                    _state = 0;
                    break;
                case 2:
                    _state = 1;
                    break;
                case 3:
                    _state = 2;
                    break;

            }
            Show();
        }

        private void DialogList_ItemActivate(object sender, EventArgs e)
        {

        }

        private void Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            switch (_state)
            {
                case 0:
                    id_dialog = e.RowIndex;
                    break;
                case 1:
                    id_question = e.RowIndex;
                    break;
                case 2:
                    id_answer = e.RowIndex;
                    break;

            }
            enterrow = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            switch (_state)
            {
                case 0:
                    DeleteDialog();
                    break;
                case 1:
                    DeleteQuestion();
                    break;
                case 2:
                    DeleteAnswer();
                    break;
                case 3:
                    DeleteJumpTo();
                    break;

            }
            Show();
        }

        
    }
}
