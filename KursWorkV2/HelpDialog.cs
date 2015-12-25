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

namespace KursWorkV2
{
    public partial class HelpDialog : Form
    {
        public HelpDialog()
        {
            InitializeComponent();
            try
            {
                StreamReader LableReader = new StreamReader("HelpCreateDialog.txt");
                richTextBox1.Text = LableReader.ReadToEnd();
                LableReader.Close();


            }
            catch (Exception)
            {
                richTextBox1.Text ="Фаил HelpCreateDialog.txt не найден";
            }
            
        }
    }
}
