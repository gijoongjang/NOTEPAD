using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTEPAD
{
    public partial class FrmReplaces : BaseForm
    {
        private const string quote = "\"";

        private FrmNote note;

        public FrmReplaces()
        {
            InitializeComponent();
        }

        public FrmReplaces(FrmNote note)
        {
            this.note = note;

            InitializeComponent();
        }

        protected override void InitData()
        {
            base.InitData();
        }

        protected override void InitUI()
        {
            this.Text = "바꾸기";
        }

        protected override void InitEvent()
        {
           button1.Click += Event_Next;
           button2.Click += Event_Replace;
           button3.Click += Event_ReplaceAll;
           button4.Click += Event_Close;

           textBox1.KeyDown += Event_FindEnter;
           textBox2.KeyDown += Event_ReplaceEnter;

        }

        private void Event_FindEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void Event_ReplaceEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2.PerformClick();
        }

        private void Event_Next(object sender, EventArgs e)
        {
            var findText = textBox1.Text;
            var matchCase = checkBox1.Checked;

            if (!note.FindAndSelectText(findText, matchCase, false))
            {
                MessageBox.Show($"{quote}{findText}{quote}을(를) 찾을 수 없습니다."
                                        , "메모장"
                                        , MessageBoxButtons.OK);
            }
        }

        private void Event_Replace(object sender, EventArgs e)
        {
            var findText = textBox1.Text;
            var matchCase = checkBox1.Checked;

            if (!note.FindAndSelectText(findText, matchCase, false))
            {
                MessageBox.Show($"{quote}{findText}{quote}을(를) 찾을 수 없습니다."
                                        , "메모장"
                                        , MessageBoxButtons.OK);
            }
            else
            {
                note.textBox1.SelectedText = textBox2.Text;
                note.textBox1.SelectionStart = textBox2.SelectionStart - textBox2.Text.Length;
                note.textBox1.SelectionLength = textBox2.Text.Length;
            }
        }

        private void Event_ReplaceAll(object sender, EventArgs e)
        {
            while (note.FindAndSelectText(textBox1.Text, checkBox1.Checked, false))
            {
                note.textBox1.SelectedText = textBox2.Text;
            }
        }

        private void Event_Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
