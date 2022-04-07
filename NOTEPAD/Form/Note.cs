using NOTEPAD.Lib.Util;
using System;
using System.IO;

using System.Windows.Forms;

namespace NOTEPAD
{
    public partial class Note : BaseForm
    {
        private const string CST_DEFAULT_TEXT = "제목 없음";

        private bool isModfied;  

        public Note()
        {
            InitializeComponent();
        }

        protected override void InitData()
        {

        }

        protected override void InitUI()
        {
            this.Text = CST_DEFAULT_TEXT;

            textBox1.ScrollBars = ScrollBars.Vertical;

            saveFileDialog1.Title = "다른 이름으로 저장";
            saveFileDialog1.Filter = "텍스트 문서(.txt)|*.txt|모든 파일|*.*";
            saveFileDialog1.DefaultExt = "tet";
            saveFileDialog1.AddExtension = true;
        }

        protected override void InitEvent()
        {
            textBox1.TextChanged += Event_TextChanged;

            make.Click += Event_Make;
            open.Click += Event_Open;
        }
        
        private void Event_TextChanged(object sender, EventArgs e)
        {
            isModfied = true;
        }

        private void Event_Make(object sender, EventArgs e)
        {
            if (isModfied)
                CloseBeforeProcess();
            else
                ClearTextBox();
        }

        private void Event_Open(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
                return;

            string fileName = openFileDialog1.FileName;
            using (StreamReader sr = new StreamReader(fileName))
            {
                textBox1.Text = sr.ReadToEnd();
                this.Text = fileName;
                isModfied = false;
            }
        }

        private void ClearTextBox()
        {
            textBox1.Text = string.Empty;
            this.Text = CST_DEFAULT_TEXT;
            isModfied = false;
        }

        private void CloseBeforeProcess()
        {
            DialogResult dialogResult = MessageBox.Show($"변경 내용을 {this.Text}에 저장하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel);

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    Save();
                    ClearTextBox();
                    break;
                case DialogResult.No:
                    ClearTextBox();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void Save()
        {
            if ( ( this.Text.Equals(CST_DEFAULT_TEXT ) ) && 
                    ( saveFileDialog1.ShowDialog() == DialogResult.OK) )
            {
                SaveFile(saveFileDialog1.FileName);
            }
            else
            {
                SaveFile(this.Text);
            }
        }

        private void SaveFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(textBox1.Text);
                isModfied = false;
                this.Text = fileName;
            }
        }
    }
}
