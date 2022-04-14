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
    public partial class FrmMoveLine : BaseForm
    {
        public FrmMoveLine()
        {
            InitializeComponent();
        }

        protected override void InitData()
        {
            base.InitData();
        }

        protected override void InitUI()
        {
            this.Text = "줄 이동";
        }

        protected override void InitEvent()
        {
            button1.Click += Event_Move;
        }

        private void Event_Move(object sender, EventArgs e)
        {
            int maxLine = int.Parse(textBox1.Text);

            if ( ( currentLine < 1 ) || 
                        ( maxLine > totalLineLength ) )
            {
                MessageBox.Show("줄 번호가 전체 줄 수를 넘습니다.", "메모장 - 줄 이동");
                return;
            }

            DialogResult = DialogResult.Yes;
        }

        public static int Popup(int totalLineLength, int currentLine)
        {
            using (FrmMoveLine form = new FrmMoveLine())
            {
                form.totalLineLength = totalLineLength;
                form.currentLine = currentLine;
                form.textBox1.Text = currentLine.ToString();

                if (form.ShowDialog() == DialogResult.Yes)
                    return int.Parse(form.textBox1.Text);

                return -1;
            }
        }

        public int totalLineLength { get; set; }
        public int currentLine { get; set; }
    }
}
