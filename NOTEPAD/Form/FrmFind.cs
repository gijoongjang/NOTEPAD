using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NOTEPAD.Note;

namespace NOTEPAD.Popup
{
    public partial class FrmFind : BaseForm
    {
        private const string quote = "\"";

        private Note note;

        public FrmFind()
        {
            InitializeComponent();
        }

        public FrmFind(Note note)
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

            textBox1.TextChanged += Event_TextChanged;

            button1.Enabled = false;
            button2.Click += Event_Close;
            radioButton2.Checked = true;
        }

        protected override void InitEvent()
        {
            base.InitEvent();

            button1.Click += Event_Search;
        }

        private void Event_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length > 0;
        }

        private void Event_Search(object sender, EventArgs e)
        {
            var findText     = textBox1.Text;
            var matchCase = checkBox1.Checked;
            var searchUp   = radioButton1.Checked;
            
            if (!FindAndSelectText(findText, matchCase, searchUp))
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

        public bool FindAndSelectText(string findText, bool matchCase, bool searchUp)
        {
            int index;
            var mode = matchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;

            if (searchUp)
                index = note.textBox1.Text.LastIndexOf(findText, SelectionStart-SelectionLength, mode);
            else
                index = note.textBox1.Text.IndexOf(findText, SelectionEnd, mode);

            if (index == -1)
                return false;

            SelectionStart = index;
            SelectionLength = findText.Length;
            note.textBox1.Focus();

            note.LastFindText   = findText;          
            note.LastMachCase = matchCase;
            note.LastSearchup  = searchUp;

            return true;
        }

        public int SelectionStart
        {
            get
            {
                return note.textBox1.SelectionStart;
            }
            set
            {
                note.textBox1.SelectionStart = value;
                note.textBox1.ScrollToCaret();
            }
        }

        public int SelectionLength 
        {
            get 
            {
                return note.textBox1.SelectionLength;
            }
            set
            {
                note.textBox1.SelectionLength = value;
            } 
        }

        public int SelectionEnd 
        { 
            get { return SelectionStart + SelectionLength; }
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
