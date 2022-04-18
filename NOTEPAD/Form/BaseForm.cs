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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(Event_LoadForm);
            this.FormClosed += new FormClosedEventHandler(Event_ClosedForm);

            //Bitmap bitmap = new Bitmap(Properties.Resources.notepad);
            //Icon = Properties.Resources.
            this.Icon = Properties.Resources.notepad;
        }

        protected virtual void InitUI()
        {
            
        }

        protected virtual void InitEvent()
        {

        }

        protected virtual void InitData()
        {

        }

        private void Event_LoadForm(object sender, EventArgs e)
        {
            InitData();
            InitUI();
            InitEvent();
        }

        private void Event_ClosedForm(object sender, FormClosedEventArgs e)
        {

        }
    }
}
