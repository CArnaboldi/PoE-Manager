using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace PoE_Manager
{
    public partial class InputPoeTradeAddressFrm : Form
    {
        public string PoeTradeAddress { get { return _poeTradeAddress; } set { _poeTradeAddress = value; } }
        public bool Submit { get { return _submit; } }

        private string _poeTradeAddress = "";
        private bool _submit = false;
        
        public InputPoeTradeAddressFrm()
        {
            InitializeComponent();
        }

        private void lbl_poetrade_web_Click(object sender, EventArgs e)
        {
            Process.Start("http://poe.trade/online.html");
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            if (txt_input.Text != String.Empty)
                btn_submit.Enabled = true;
            else
                btn_submit.Enabled = false;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            _poeTradeAddress = txt_input.Text;
            _submit = true;
            this.Close();
        }

        private void lbl_poetrade_web_MouseEnter(object sender, EventArgs e)
        {
            lbl_poetrade_web.ForeColor = Color.Red;
        }

        private void lbl_poetrade_web_MouseLeave(object sender, EventArgs e)
        {
            lbl_poetrade_web.ForeColor = Color.Black;
        }

    }
}
