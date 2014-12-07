using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoE_Manager
{
    public partial class YesNoFrm : Form
    {

        private MainFrm _mainFrm;

        //We don't want any topbar in our window
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0xC00000; //WS_CAPTION;  
                return cp;
            }
        }
        
        public bool Confirm { get { return _confirm; } }

        
        private bool _confirm = false;

        
        public YesNoFrm(MainFrm mainFrm, string Title, string Question)
        {
            InitializeComponent();

            _mainFrm = mainFrm;

            Generic.initStyle(this);
            this.Location = _mainFrm.Location;
            lbl_title.Text = Title;
            lbl_question.Text = Question;

            lbl_title.Location = new Point(_mainFrm.Size.Width - lbl_title.Width - 5, lbl_title.Location.Y);
            lbl_question.Location = new Point(_mainFrm.Size.Width / 2 - lbl_question.Width /2, lbl_question.Location.Y);

            btn_yes.Location = new Point(_mainFrm.Size.Width / 2 - 70 - btn_yes.Width /2, btn_yes.Location.Y);
            btn_no.Location = new Point(_mainFrm.Size.Width / 2 + 70 - btn_no.Width /2, btn_no.Location.Y);

            _mainFrm.TopMost = false;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            _confirm = true;
            _mainFrm.TopMost = true;
            this.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            _confirm = false;
            _mainFrm.TopMost = true;
            this.Close();
        }
    }
}
