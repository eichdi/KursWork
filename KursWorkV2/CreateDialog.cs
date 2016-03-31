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
using DialogModel;

namespace KursWorkV2
{

    public partial class CreateDialog : Form
    {
        
        private DialogController controller;


        public CreateDialog()
        {
            InitializeComponent();
            FileDialog.DefaultExt = "*.json";
            string directory = Application.StartupPath;
            FileDialog.InitialDirectory = directory;
            controller = new DialogController("", null);
            Show();
        }
        


        public void Show()
        {
            DataTable dt = new DataTable();
            string nameCol = controller.NowState;
            string[] elements = controller.Show();
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
            switch (controller.NowState)
            {
                case DialogController.dialogState:
                    State_Dialog();
                    break;
                case DialogController.questionState:
                    State_Question();
                    break;
                case DialogController.answersState:
                    State_Answer();
                    break;
                case DialogController.jumpToState:
                    State_JumpTo();
                    break;
            }
            Grid.Refresh();
        }
        

        /// 
        
        
        public void OpenJson()
        {

        }

        //true
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
            //todo
            //LableText.Text = "Вопросы диалога - "+;
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
            //todo
            delete.Visible = true;
            //LableText.Text = "Ответы вопроса - "+ NowQuestion.Question;
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
            //todo
            //LableText.Text = "После ответа \"" + NowAnswer.Answer + "\" переходить в какой диалог";
            LableText.Visible = true;
            textBox.Visible = true;
            textBox.Text = "";
            add.Visible = false;
            edit.Visible = true;
            enter.Visible = false;
            back.Visible = true;
            delete.Visible = true;
        }
        
        private void FileDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void созадтьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller = new DialogController("save.json", null);
            Show();
        }

        public void SaveJson()
        {
            //StreamWriter sw = new StreamWriter("/Saves/save.json");
            //sw.Write(controller.NowQuestion.Saves());
            //sw.Flush();
            //sw.Close();
            

            //work
            StreamWriter sw = new StreamWriter("/Saves/save.json");
            sw.Write(JsonConvert.SerializeObject(controller.Head));
            sw.Flush();
            sw.Close();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FileDialog.ShowDialog();
                try
                {

                    //StreamReader sr = new StreamReader("/Saves/save.json");
                    //controller.NowQuestion.Open(sr.ReadToEnd());
                    //sr.Close();
                    string _path = FileDialog.FileName;
                    StreamReader sr = new StreamReader("/Saves/save.json");
                    //todo  NOT WORK! WHY?!
                    controller = new DialogController(FileDialog.FileName, JsonConvert.DeserializeObject<DialogClass>(sr.ReadToEnd()));
                    Show();
                    sr.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Такого файла нет");
                }
                Show();
        }

        
        private void какСозаватьДиалогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpDialog temp = new HelpDialog();
            temp.Show();
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = controller.Head.ToString();
            SaveJson();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (Grid.CurrentRow!=null && controller.DownToState(Grid.CurrentRow.Index))
            {
                Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        //ADE
        private void add_Click(object sender, EventArgs e)
        {
            controller.Add(textBox.Text);
            Show();
		}
        private void delete_Click(object sender, EventArgs e)
        {
            if (!controller.Delete())
            {
                MessageBox.Show("Error");
            }
            Show();
        }
        private void edit_Click(object sender, EventArgs e)
        {
            if (!controller.Edit(textBox.Text))
            {
                MessageBox.Show("Error");
            }
            Show();
        }


        private void back_Click(object sender, EventArgs e)
        {
            controller.UpToState();
            this.Show();
        }

        private void DialogList_ItemActivate(object sender, EventArgs e)
        {

        }

        private void Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            controller.ChoseEnterByNowState(e.RowIndex);
        }

        
        //

        //public void AddDialog()
        //{
        //    List<DialogClass> dialoglist;
        //    if (dialogs.Dialogs != null)
        //    {
        //        dialoglist = dialogs.Dialogs.ToList<DialogClass>();
        //    }
        //    else
        //    {
        //        dialoglist = new List<DialogClass>();
        //    }
        //    DialogClass dio = new DialogClass();
        //    dio.Name = textBox.Text;
        //    dialoglist.Add(dio);
        //    dialogs.Dialogs = dialoglist.ToArray();
        //}
        //public void AddQuestion()
        //{
        //    List<Question> questlist;
        //    if (NowDialog.Questions!=null)
        //        questlist = NowDialog.Questions.ToList<Question>();
        //    else
        //    {
        //        questlist = new List<Question>();
        //    }
        //    Question que = new Question();
        //    que.Question = textBox.Text;
        //    questlist.Add(que);
        //    NowDialog.Questions = questlist.ToArray();
        //}
        //public void AddAnswer()
        //{
        //    List<AnswerClass> anslist;
        //    if (NowQuestion.Answers != null)
        //        anslist = NowQuestion.Answers.ToList<AnswerClass>();
        //    else
        //        anslist = new List<AnswerClass>();
        //    AnswerClass ans =  new AnswerClass();
        //    ans.Answer = textBox.Text;
        //    anslist.Add(ans);
        //    NowQuestion.Answers = anslist.ToArray();
        //}
        //public void AddJumpTo()
        //{
        //    NowAnswer.JumpTo = textBox.Text;
        //}
        

        
        
    }
}
