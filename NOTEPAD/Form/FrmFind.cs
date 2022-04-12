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
    public partial class FrmFind : BaseForm
    {
        private const string quote = "\"";

        private FrmNote note;

        public FrmFind()
        {
            InitializeComponent();
        }

        public FrmFind(FrmNote note)
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
            this.Text = "찾기";

            button1.Enabled = false;
            radioButton2.Checked = true;
        }

        protected override void InitEvent()
        {
            base.InitEvent();

            textBox1.TextChanged += Event_TextChanged;
            textBox1.KeyDown += Event_KeyDown;

            button1.Click += Event_Search;
            button2.Click += Event_Close;
        }

        private void Event_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length > 0;
        }

        private void Event_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void Event_Search(object sender, EventArgs e)
        {
            var findText = textBox1.Text;
            var matchCase = checkBox1.Checked;
            var searchUp = radioButton1.Checked;
            
            if (!note.FindAndSelectText(findText, matchCase, searchUp))
            {
                MessageBox.Show($"{quote}{findText}{quote}을(를) 찾을 수 없습니다."
                                        , "메모장"
                                        , MessageBoxButtons.OK);
            }
        }

        private void Event_Close(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //public static void Popup(Note note)
        //{
        //    using (frmFind form = new frmFind())
        //    {
        //        form.Note = note;
        //        //form.Notify = notify;
        //        form.ShowDialog();

        //    }
        //}

        //public Note Note { get; set; }
        //public IFindNotify Notify { get; set; }

    }
}
