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
    public partial class HelpFrm : Form
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
        
        public HelpFrm(MainFrm mainFrm)
        {
            InitializeComponent();

            _mainFrm = mainFrm;

            Generic.initStyle(this);
            this.Location = _mainFrm.Location;

            lbl_title.Text = "&Got it!";
            lbl_title.Location = new Point(_mainFrm.Size.Width - lbl_title.Width - 5, lbl_title.Location.Y);

            lbl_poemanager_hotkey.Location = new Point(_mainFrm.Width / 2 - lbl_poemanager_hotkey.Width / 2, lbl_poemanager_hotkey.Location.Y);
            lbl_helper_hotkeys.Location = new Point(_mainFrm.Width / 2 - lbl_helper_hotkeys.Width / 2, lbl_helper_hotkeys.Location.Y);
            lbl_helper_quit_hotkey.Location = new Point(_mainFrm.Width / 2 - lbl_helper_quit_hotkey.Width / 2, lbl_helper_quit_hotkey.Location.Y);
            lbl_helper_remaining_hotkey.Location = new Point(_mainFrm.Width / 2 - lbl_helper_remaining_hotkey.Width / 2, lbl_helper_remaining_hotkey.Location.Y);
            lbl_helper_itemlevel_hotkey.Location = new Point(_mainFrm.Width / 2 - lbl_helper_itemlevel_hotkey.Width / 2, lbl_helper_itemlevel_hotkey.Location.Y);
            lbl_helper_oos_hotkey.Location = new Point(_mainFrm.Width / 2 - lbl_helper_oos_hotkey.Width / 2, lbl_helper_oos_hotkey.Location.Y);

            _mainFrm.TopMost = false;
        }

        private void btn_close_help_Click(object sender, EventArgs e)
        {
            _mainFrm.TopMost = true;
            this.Close();
        }

        private void lbl_title_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

    }
}
