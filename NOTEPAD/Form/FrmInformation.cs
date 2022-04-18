using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTEPAD
{
    public partial class FrmInformation : BaseForm
    {
        public FrmInformation()
        {
            InitializeComponent();
        }

        protected override void InitData()
        {
            base.InitData();
        }

        protected override void InitUI()
        {
            this.Text = "메모장 정보";

            label2.Text = "ⓒ gijoongjang. All rights reserved.";
            label3.Text = "제품 상세정보는";
            label4.Text = "서 확인 할 수 있습니다.";
            label5.Text = "문제 발견시 rlwnd0000@gmail.com로 연락 주세요.";
            label6.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Image = Properties.Resources.window;
            pictureBox2.Image = Properties.Resources.notepad.ToBitmap();
        }

        protected override void InitEvent()
        {
            linkLabel1.LinkClicked += Event_LinkClicked;

            button1.Click += Event_Confirm;
        }

        private void Event_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ProcessStartInfo psi = new ProcessStartInfo("https://github.com/gijoongjang/NOTEPAD");
            Process.Start(((LinkLabel)sender).Text);

            linkLabel1.LinkVisited = true;
        }

        private void Event_Confirm(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool Popup()
        {
            using (FrmInformation form = new FrmInformation())
            {
                var result = form.ShowDialog() == DialogResult.Yes;

                return result;
            }
        }
    }
}
