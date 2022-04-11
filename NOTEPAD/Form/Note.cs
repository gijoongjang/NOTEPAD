using NOTEPAD.Lib.Util;
using NOTEPAD.Popup;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

using System.Windows.Forms;

namespace NOTEPAD
{
    public partial class Note : BaseForm
    {
        private const string CST_DEFAULT_TEXT = "제목 없음";
        private const string quote = "\"";

        private bool isModfied;

        //private PrintDocument printDocument;
        private PageSetupDialog pageSetupDialog;

        private FrmFind frmFind = null;

        private enum CloseType
        {
            SaveBefor
            , Exit
        }

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
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;

            undo.Enabled = false;
            cut.Enabled = false;
            copy.Enabled = false;
            delete.Enabled = false;
            find.Enabled = false;
        }

        protected override void InitEvent()
        {
            textBox1.TextChanged += Event_TextChanged;

            printDocument1.PrintPage += Event_PrintPage;

            //파일
            make.Click += Event_Make;
            open.Click += Event_Open;
            save.Click += Event_Save;
            saveAs.Click += Event_SaveAs;
            pageSet.Click += Event_PrintSet;
            print.Click += Event_Print;
            exit.Click += Event_Exit;

            //편집
            undo.Click += Event_Undo;
            cut.Click += Event_Cut;
            copy.Click += Event_Copy;
            paste.Click += Event_Paste;
            delete.Click += Event_Delete;
            find.Click += Event_Find;
            nextFind.Click += Event_NextFind;
        }

        private void Event_TextChanged(object sender, EventArgs e)
        {
            isModfied       = true;
            undo.Enabled  = true;
            cut.Enabled     = true;
            copy.Enabled   = true;
            delete.Enabled = true;
            find.Enabled    = true;
        }

        private void Event_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font(textBox1.Font.Name, textBox1.Font.Size, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
        }

        private void Event_Make(object sender, EventArgs e)
        {
            if (isModfied)
                CloseBeforeProcess(CloseType.SaveBefor);
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

        private void Event_Save(object sender, EventArgs e)
        {
            Save();
        }

        private void Event_SaveAs(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog1.FileName);
            }
        }

        private void Event_PrintSet(object sender, EventArgs e)
        {
            //printDocument = new PrintDocument();
            //printDocument.DocumentName = textBox1.Text;
            printDocument1.DocumentName = textBox1.Text;

            pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.Document = printDocument1;
            pageSetupDialog.Document.DefaultPageSettings.Color = false;

            pageSetupDialog.ShowDialog();
        }

        private void Event_Print(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            try
            {
                printDocument1.Print();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Event_Exit(object sender, EventArgs e)
        {
            if (isModfied)
                CloseBeforeProcess(CloseType.Exit);
            else
                this.Close();
        }

        private void Event_Undo(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
            {
                textBox1.Undo();
                //textBox1.ClearUndo();
            }
        }
        
        private void Event_Cut(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != string.Empty)
                textBox1.Cut();
        }

        private void Event_Copy(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.Copy();
        }

        private void Event_Paste(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                textBox1.Paste();
        }

        private void Event_Delete(object sender, EventArgs e)
        {
            textBox1.SelectedText = string.Empty;
        }

        private void Event_Find(object sender, EventArgs e)
        {
            Find();
            //frmFind.Popup(this);
            //FrmFind form = new FrmFind(this);

            //form.Show();
        }

        private void Event_NextFind(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LastFindText))
                Find();

            if (!frmFind.FindAndSelectText(LastFindText, LastMachCase, LastSearchup))
            {
                MessageBox.Show($"{quote}{LastFindText}{quote}을(를) 찾을 수 없습니다." 
                                        , "메모장"
                                        , MessageBoxButtons.OK);
            }
        }

        private void Find()
        {
            if (textBox1.Text.Length < 1)
                return;

            if (frmFind == null)
            {
                frmFind = new FrmFind(this);
            }

            if (!frmFind.Visible)
                frmFind.Show(this);
            else
                frmFind.Show();
        }

        private void ClearTextBox()
        {
            textBox1.Text = string.Empty;
            this.Text = CST_DEFAULT_TEXT;
            isModfied = false;
        }

        private void CloseBeforeProcess(CloseType type)
        {
            DialogResult dialogResult = MessageBox.Show($"변경 내용을 {this.Text}에 저장하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel);

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    Save();
                    if (type == CloseType.SaveBefor)
                        ClearTextBox();
                    else
                        this.Close();
                    break;
                case DialogResult.No:
                    if (type == CloseType.SaveBefor)
                        ClearTextBox();
                    else
                        this.Close();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void Save()
        {
            if ( ( this.Text.Equals(CST_DEFAULT_TEXT) ) && 
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
                this.Text = FileUtil.GetFileName(fileName);
                saveFileDialog1.FileName = this.Text;
            }
        }

        public string LastFindText { get; set; }
        public bool LastMachCase  { get; set; }
        public bool LastSearchup { get; set; }

    }

    //public interface IFindNotify
    //{
    //    void Notify(string text);
    //}
}
