using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

namespace KursWorkV2
{
    public partial class DialogForm : Form
    {
        string _path;

        int index_ndialog = -2;
        int index_dialog;
        int index_question=-1;
        //int id_answer;
        DialogsClass dialogs;
        QuestionClass question;
        DialogClass dialog;
        
        public DialogForm()
        {
            
            InitializeComponent();
            DataColumn colq = new DataColumn("Вопрос", typeof(String));
            DataColumn cola = new DataColumn("Ответ", typeof(String));
            DataTable dt = new DataTable();
            dt.Columns.Add(colq);
            dt.Columns.Add(cola);
            qaTable.DataSource = dt;


        }
        // SATRT CONTROL TEST DOCSYS RATE SAVE END
        string[] namedialogs = { "START", "CONTROL", "TEST", "DOCSYS", "RATE", "SAVE", "END" };
        public int serarchindex(string a)
        {
            for (int i = 0; i < namedialogs.Length; i++)
            {
                if (namedialogs[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }
        public int serarchindex(string a, string[] b)
        {
            for (int i = 0; i < namedialogs.Length; i++)
            {
                if (b[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool searchdialog(string a)
        {
            if (serarchindex(a) == -1)
                return false;
           return true;
        }
        public int searchdialog(DialogsClass d, string t)
        {
            for (int i = 0; i < d.Dialogs.Length; i++)
            {
                if (d.Dialogs[i].Name == t)
                {
                    return i;
                }
            }
            return -1;
        }
        public void ShowToForm(QuestionClass q)
        {
            questBox.Text = q.Question;
            string a;
            if (q.Answers != null)
            {
                a = q.Answers[0].Answer;
                for (int i = 1; i < q.Answers.Length; i++)
                {
                    a = a + "\n" + q.Answers[i].Answer;
                }
            }
            else
            {
                a = "Свободный выбор ответа";
            }
            ansBox.Text = a;

        }
        public void ClearForm()
        {
            ansBox.Text = "";
            questBox.Text = "";
            errBox.Text= "";
            ansText.Text = "";
        }
        public DialogClass NextDialog()
        {
            if (index_ndialog == -2)
            {
                index_ndialog = 0;
            }
            else
            {
                if (index_ndialog != 6)
                    index_ndialog++;
            }
            index_dialog = searchdialog(dialogs, namedialogs[index_ndialog]);
            if (index_dialog != -1)
                return dialogs.Dialogs[index_dialog];
            else
            {
                MessageBox.Show("Неверно создан диалог, попробуйте открыть другой, либо создайте другой");
                return new DialogClass();
            }
            
        }
        public void NextQuestion()
        {
            
            if (dialog == null || index_question == dialog.Questions.Length-1 || index_question == -1)
            {
                dialog = NextDialog();
                index_question = 0;
            }
            else
            {
                index_question++;
            }
            ShowToForm(dialog.Questions[index_question]);

        }
        public void SaveToTable()
        {
            DataTable dt = (DataTable)qaTable.DataSource;
            DataRow newrow =  dt.NewRow();
            newrow["Вопрос"] = questBox.Text;
            newrow["Ответ"] = ansText.Text;
            dt.Rows.Add(newrow);
            qaTable.DataSource = dt;
        }

        public bool AnsTrue()
        {
            if (ansBox.Text != "Свободный выбор ответа")
            {
                return ansBox.Text.Contains(ansText.Text);
            }
            else return true;
        }
        private void новыйДиалогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
            
                _path = FileDialog.FileName;
                StreamReader sr = new StreamReader(_path);

                dialogs = JsonConvert.DeserializeObject<DialogsClass>(sr.ReadToEnd());
                sr.Close();
                NextQuestion();

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Такого файла нет");
            //}
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (index_ndialog != -2)
            {
                if (AnsTrue())
                {
                    if (!(questBox.Text == "Завершить работу?" && ansText.Text == "Да"))
                    {
                        MetodAfterQuestion(questBox.Text);
                        SaveToTable();
                        ClearForm();
                        NextQuestion();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    errBox.Text = "Неверный ответ";
                }
            }
            else
            {
                errBox.Text = "Ошибка ввода";
            }
        }

        private void новыйДиалогToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CreateDialog temp = new CreateDialog();
            temp.Show();
        }

        private void сохранитьДиалогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В стадии разработки");
        }

        private void какВводитьВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpDialog temp = new HelpDialog();
            temp.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа демонстрирует реализацию реляционной модели данных.\n\nПрограмма была создана как практическая часть курсовой работы по дисциплине \"Проектирование человеко-машинного интерфейса\" (ПЧМИ)\nВерсия программы 1.0 \nРазработчик: студент КФУ ИВМиИТ 2 курса гр. 09-411 Хайрутдинов С.З\nПроверил: старший преподаватель кафедры технологий программирования Георгиев В.О.", "Информация о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
