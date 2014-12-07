namespace PoE_Manager
{
    partial class MainFrm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_autoonline_start = new System.Windows.Forms.Button();
            this.btn_helper_start = new System.Windows.Forms.Button();
            this.btn_poe_start = new System.Windows.Forms.Button();
            this.btn_procurement_start = new System.Windows.Forms.Button();
            this.btn_procurement_stop = new System.Windows.Forms.Button();
            this.btn_autoonline_stop = new System.Windows.Forms.Button();
            this.btn_helper_stop = new System.Windows.Forms.Button();
            this.btn_poe_stop = new System.Windows.Forms.Button();
            this.lbl_procurement_status = new System.Windows.Forms.Label();
            this.lbl_autoonline_status = new System.Windows.Forms.Label();
            this.lbl_helper_status = new System.Windows.Forms.Label();
            this.lbl_poe_status = new System.Windows.Forms.Label();
            this.chk_procurement_autolaunch = new System.Windows.Forms.CheckBox();
            this.chk_autoonline_autolaunch = new System.Windows.Forms.CheckBox();
            this.chk_helper_autolaunch = new System.Windows.Forms.CheckBox();
            this.chk_poe_autolaunch = new System.Windows.Forms.CheckBox();
            this.lbl_credits = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.chk_starthidden = new System.Windows.Forms.CheckBox();
            this.lbl_clear = new System.Windows.Forms.Label();
            this.dlg_poe_path = new System.Windows.Forms.OpenFileDialog();
            this.txt_poe_wiki = new System.Windows.Forms.TextBox();
            this.btn_poe_wiki_search = new System.Windows.Forms.Button();
            this.btn_procurement_minimize = new System.Windows.Forms.Button();
            this.btn_poe_minimize = new System.Windows.Forms.Button();
            this.btn_poe_trade_search = new System.Windows.Forms.Button();
            this.lbl_help = new System.Windows.Forms.Label();
            this.lbl_topbar = new System.Windows.Forms.Label();
            this.pnl_bottombar = new System.Windows.Forms.Panel();
            this.pnl_bottombar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_autoonline_start
            // 
            this.btn_autoonline_start.Location = new System.Drawing.Point(107, 38);
            this.btn_autoonline_start.Name = "btn_autoonline_start";
            this.btn_autoonline_start.Size = new System.Drawing.Size(100, 42);
            this.btn_autoonline_start.TabIndex = 2;
            this.btn_autoonline_start.Tag = "START";
            this.btn_autoonline_start.UseVisualStyleBackColor = true;
            this.btn_autoonline_start.Click += new System.EventHandler(this.btn_autoonline_start_Click);
            // 
            // btn_helper_start
            // 
            this.btn_helper_start.Location = new System.Drawing.Point(213, 38);
            this.btn_helper_start.Name = "btn_helper_start";
            this.btn_helper_start.Size = new System.Drawing.Size(100, 42);
            this.btn_helper_start.TabIndex = 3;
            this.btn_helper_start.Tag = "START";
            this.btn_helper_start.UseVisualStyleBackColor = true;
            this.btn_helper_start.Click += new System.EventHandler(this.btn_helper_start_Click);
            // 
            // btn_poe_start
            // 
            this.btn_poe_start.Location = new System.Drawing.Point(319, 38);
            this.btn_poe_start.Name = "btn_poe_start";
            this.btn_poe_start.Size = new System.Drawing.Size(100, 42);
            this.btn_poe_start.TabIndex = 4;
            this.btn_poe_start.Tag = "START";
            this.btn_poe_start.UseVisualStyleBackColor = true;
            this.btn_poe_start.Click += new System.EventHandler(this.btn_poe_start_Click);
            // 
            // btn_procurement_start
            // 
            this.btn_procurement_start.Location = new System.Drawing.Point(1, 38);
            this.btn_procurement_start.Name = "btn_procurement_start";
            this.btn_procurement_start.Size = new System.Drawing.Size(100, 42);
            this.btn_procurement_start.TabIndex = 1;
            this.btn_procurement_start.Tag = "START";
            this.btn_procurement_start.UseVisualStyleBackColor = true;
            this.btn_procurement_start.Click += new System.EventHandler(this.btn_procurement_start_Click);
            // 
            // btn_procurement_stop
            // 
            this.btn_procurement_stop.Location = new System.Drawing.Point(1, 115);
            this.btn_procurement_stop.Name = "btn_procurement_stop";
            this.btn_procurement_stop.Size = new System.Drawing.Size(100, 42);
            this.btn_procurement_stop.TabIndex = 6;
            this.btn_procurement_stop.Tag = "STOP";
            this.btn_procurement_stop.UseVisualStyleBackColor = true;
            this.btn_procurement_stop.Click += new System.EventHandler(this.btn_procurement_stop_Click);
            // 
            // btn_autoonline_stop
            // 
            this.btn_autoonline_stop.Location = new System.Drawing.Point(107, 115);
            this.btn_autoonline_stop.Name = "btn_autoonline_stop";
            this.btn_autoonline_stop.Size = new System.Drawing.Size(100, 42);
            this.btn_autoonline_stop.TabIndex = 7;
            this.btn_autoonline_stop.Tag = "STOP";
            this.btn_autoonline_stop.UseVisualStyleBackColor = true;
            this.btn_autoonline_stop.Click += new System.EventHandler(this.btn_autoonline_stop_Click);
            // 
            // btn_helper_stop
            // 
            this.btn_helper_stop.Location = new System.Drawing.Point(213, 115);
            this.btn_helper_stop.Name = "btn_helper_stop";
            this.btn_helper_stop.Size = new System.Drawing.Size(100, 42);
            this.btn_helper_stop.TabIndex = 8;
            this.btn_helper_stop.Tag = "STOP";
            this.btn_helper_stop.UseVisualStyleBackColor = true;
            this.btn_helper_stop.Click += new System.EventHandler(this.btn_helper_stop_Click);
            // 
            // btn_poe_stop
            // 
            this.btn_poe_stop.Location = new System.Drawing.Point(319, 115);
            this.btn_poe_stop.Name = "btn_poe_stop";
            this.btn_poe_stop.Size = new System.Drawing.Size(100, 42);
            this.btn_poe_stop.TabIndex = 10;
            this.btn_poe_stop.Tag = "STOP";
            this.btn_poe_stop.UseVisualStyleBackColor = true;
            this.btn_poe_stop.Click += new System.EventHandler(this.btn_poe_stop_Click);
            // 
            // lbl_procurement_status
            // 
            this.lbl_procurement_status.Location = new System.Drawing.Point(1, 88);
            this.lbl_procurement_status.Name = "lbl_procurement_status";
            this.lbl_procurement_status.Size = new System.Drawing.Size(100, 20);
            this.lbl_procurement_status.TabIndex = 8;
            this.lbl_procurement_status.Tag = "PROCUREMENT";
            // 
            // lbl_autoonline_status
            // 
            this.lbl_autoonline_status.Location = new System.Drawing.Point(95, 88);
            this.lbl_autoonline_status.Name = "lbl_autoonline_status";
            this.lbl_autoonline_status.Size = new System.Drawing.Size(122, 20);
            this.lbl_autoonline_status.TabIndex = 9;
            this.lbl_autoonline_status.Tag = "AUTOONLINE";
            // 
            // lbl_helper_status
            // 
            this.lbl_helper_status.Location = new System.Drawing.Point(213, 88);
            this.lbl_helper_status.Name = "lbl_helper_status";
            this.lbl_helper_status.Size = new System.Drawing.Size(100, 20);
            this.lbl_helper_status.TabIndex = 10;
            this.lbl_helper_status.Tag = "HELPER";
            // 
            // lbl_poe_status
            // 
            this.lbl_poe_status.Location = new System.Drawing.Point(319, 88);
            this.lbl_poe_status.Name = "lbl_poe_status";
            this.lbl_poe_status.Size = new System.Drawing.Size(100, 20);
            this.lbl_poe_status.TabIndex = 11;
            this.lbl_poe_status.Tag = "POE";
            // 
            // chk_procurement_autolaunch
            // 
            this.chk_procurement_autolaunch.Location = new System.Drawing.Point(1, 163);
            this.chk_procurement_autolaunch.Name = "chk_procurement_autolaunch";
            this.chk_procurement_autolaunch.Size = new System.Drawing.Size(100, 24);
            this.chk_procurement_autolaunch.TabIndex = 11;
            this.chk_procurement_autolaunch.Tag = "PROCUREMENT";
            this.chk_procurement_autolaunch.UseVisualStyleBackColor = true;
            this.chk_procurement_autolaunch.CheckedChanged += new System.EventHandler(this.chk_procurement_autolaunch_CheckedChanged);
            // 
            // chk_autoonline_autolaunch
            // 
            this.chk_autoonline_autolaunch.Location = new System.Drawing.Point(107, 163);
            this.chk_autoonline_autolaunch.Name = "chk_autoonline_autolaunch";
            this.chk_autoonline_autolaunch.Size = new System.Drawing.Size(100, 24);
            this.chk_autoonline_autolaunch.TabIndex = 12;
            this.chk_autoonline_autolaunch.Tag = "AUTOONLINE";
            this.chk_autoonline_autolaunch.UseVisualStyleBackColor = true;
            this.chk_autoonline_autolaunch.CheckedChanged += new System.EventHandler(this.chk_autoonline_autolaunch_CheckedChanged);
            // 
            // chk_helper_autolaunch
            // 
            this.chk_helper_autolaunch.Location = new System.Drawing.Point(213, 163);
            this.chk_helper_autolaunch.Name = "chk_helper_autolaunch";
            this.chk_helper_autolaunch.Size = new System.Drawing.Size(100, 24);
            this.chk_helper_autolaunch.TabIndex = 13;
            this.chk_helper_autolaunch.Tag = "HELPER";
            this.chk_helper_autolaunch.UseVisualStyleBackColor = true;
            this.chk_helper_autolaunch.CheckedChanged += new System.EventHandler(this.chk_helper_autolaunch_CheckedChanged);
            // 
            // chk_poe_autolaunch
            // 
            this.chk_poe_autolaunch.Location = new System.Drawing.Point(319, 163);
            this.chk_poe_autolaunch.Name = "chk_poe_autolaunch";
            this.chk_poe_autolaunch.Size = new System.Drawing.Size(100, 24);
            this.chk_poe_autolaunch.TabIndex = 14;
            this.chk_poe_autolaunch.Tag = "POE";
            this.chk_poe_autolaunch.UseVisualStyleBackColor = true;
            this.chk_poe_autolaunch.CheckedChanged += new System.EventHandler(this.chk_poe_autolaunch_CheckedChanged);
            // 
            // lbl_credits
            // 
            this.lbl_credits.AutoSize = true;
            this.lbl_credits.Location = new System.Drawing.Point(253, 5);
            this.lbl_credits.Name = "lbl_credits";
            this.lbl_credits.Size = new System.Drawing.Size(0, 13);
            this.lbl_credits.TabIndex = 16;
            this.lbl_credits.Tag = "CREDITS";
            // 
            // lbl_close
            // 
            this.lbl_close.Location = new System.Drawing.Point(403, -4);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(18, 23);
            this.lbl_close.TabIndex = 18;
            this.lbl_close.Tag = "CLOSE";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            this.lbl_close.MouseEnter += new System.EventHandler(this.lbl_close_MouseEnter);
            this.lbl_close.MouseLeave += new System.EventHandler(this.lbl_close_MouseLeave);
            // 
            // chk_starthidden
            // 
            this.chk_starthidden.Location = new System.Drawing.Point(3, 3);
            this.chk_starthidden.Name = "chk_starthidden";
            this.chk_starthidden.Size = new System.Drawing.Size(100, 18);
            this.chk_starthidden.TabIndex = 17;
            this.chk_starthidden.Tag = "STARTHIDDEN";
            this.chk_starthidden.UseVisualStyleBackColor = true;
            this.chk_starthidden.CheckedChanged += new System.EventHandler(this.chk_starthidden_CheckedChanged);
            // 
            // lbl_clear
            // 
            this.lbl_clear.Location = new System.Drawing.Point(284, -4);
            this.lbl_clear.Name = "lbl_clear";
            this.lbl_clear.Size = new System.Drawing.Size(84, 23);
            this.lbl_clear.TabIndex = 22;
            this.lbl_clear.Tag = "CLEAR";
            this.lbl_clear.Click += new System.EventHandler(this.lbl_clear_Click);
            this.lbl_clear.MouseEnter += new System.EventHandler(this.lbl_clear_MouseEnter);
            this.lbl_clear.MouseLeave += new System.EventHandler(this.lbl_clear_MouseLeave);
            // 
            // dlg_poe_path
            // 
            this.dlg_poe_path.FileName = "Path of Exile Executable";
            // 
            // txt_poe_wiki
            // 
            this.txt_poe_wiki.Location = new System.Drawing.Point(15, 207);
            this.txt_poe_wiki.Name = "txt_poe_wiki";
            this.txt_poe_wiki.Size = new System.Drawing.Size(227, 20);
            this.txt_poe_wiki.TabIndex = 0;
            this.txt_poe_wiki.Tag = "WIKI";
            this.txt_poe_wiki.Enter += new System.EventHandler(this.txt_poe_wiki_Enter);
            this.txt_poe_wiki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_poe_wiki_KeyPress);
            // 
            // btn_poe_wiki_search
            // 
            this.btn_poe_wiki_search.Location = new System.Drawing.Point(242, 207);
            this.btn_poe_wiki_search.Name = "btn_poe_wiki_search";
            this.btn_poe_wiki_search.Size = new System.Drawing.Size(60, 28);
            this.btn_poe_wiki_search.TabIndex = 15;
            this.btn_poe_wiki_search.Tag = "SEARCH_WIKI";
            this.btn_poe_wiki_search.UseVisualStyleBackColor = true;
            this.btn_poe_wiki_search.Click += new System.EventHandler(this.btn_poe_wiki_search_Click);
            // 
            // btn_procurement_minimize
            // 
            this.btn_procurement_minimize.Location = new System.Drawing.Point(1, 115);
            this.btn_procurement_minimize.Name = "btn_procurement_minimize";
            this.btn_procurement_minimize.Size = new System.Drawing.Size(50, 42);
            this.btn_procurement_minimize.TabIndex = 5;
            this.btn_procurement_minimize.Tag = "MINIMIZE";
            this.btn_procurement_minimize.UseVisualStyleBackColor = true;
            this.btn_procurement_minimize.Click += new System.EventHandler(this.btn_procurement_minimize_Click);
            // 
            // btn_poe_minimize
            // 
            this.btn_poe_minimize.Location = new System.Drawing.Point(319, 115);
            this.btn_poe_minimize.Name = "btn_poe_minimize";
            this.btn_poe_minimize.Size = new System.Drawing.Size(50, 42);
            this.btn_poe_minimize.TabIndex = 9;
            this.btn_poe_minimize.Tag = "MINIMIZE";
            this.btn_poe_minimize.UseVisualStyleBackColor = true;
            this.btn_poe_minimize.Click += new System.EventHandler(this.btn_poe_minimize_Click);
            // 
            // btn_poe_trade_search
            // 
            this.btn_poe_trade_search.Location = new System.Drawing.Point(307, 207);
            this.btn_poe_trade_search.Name = "btn_poe_trade_search";
            this.btn_poe_trade_search.Size = new System.Drawing.Size(92, 28);
            this.btn_poe_trade_search.TabIndex = 16;
            this.btn_poe_trade_search.Tag = "SEARCH_POETRADE";
            this.btn_poe_trade_search.UseVisualStyleBackColor = true;
            this.btn_poe_trade_search.Click += new System.EventHandler(this.btn_poe_trade_search_Click);
            // 
            // lbl_help
            // 
            this.lbl_help.Location = new System.Drawing.Point(368, -4);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(35, 23);
            this.lbl_help.TabIndex = 42;
            this.lbl_help.Tag = "HELP";
            this.lbl_help.Click += new System.EventHandler(this.lbl_help_Click);
            this.lbl_help.MouseEnter += new System.EventHandler(this.lbl_help_MouseEnter);
            this.lbl_help.MouseLeave += new System.EventHandler(this.lbl_help_MouseLeave);
            // 
            // lbl_topbar
            // 
            this.lbl_topbar.Location = new System.Drawing.Point(0, -4);
            this.lbl_topbar.Name = "lbl_topbar";
            this.lbl_topbar.Size = new System.Drawing.Size(284, 33);
            this.lbl_topbar.TabIndex = 43;
            this.lbl_topbar.Tag = "TOPBAR";
            this.lbl_topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_topbar_MouseDown);
            // 
            // pnl_bottombar
            // 
            this.pnl_bottombar.Controls.Add(this.lbl_credits);
            this.pnl_bottombar.Controls.Add(this.chk_starthidden);
            this.pnl_bottombar.Location = new System.Drawing.Point(0, 257);
            this.pnl_bottombar.Name = "pnl_bottombar";
            this.pnl_bottombar.Size = new System.Drawing.Size(420, 23);
            this.pnl_bottombar.TabIndex = 44;
            this.pnl_bottombar.Tag = "BOTTOMBAR";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 252);
            this.Controls.Add(this.pnl_bottombar);
            this.Controls.Add(this.lbl_topbar);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.btn_poe_trade_search);
            this.Controls.Add(this.btn_poe_minimize);
            this.Controls.Add(this.btn_procurement_minimize);
            this.Controls.Add(this.btn_poe_wiki_search);
            this.Controls.Add(this.txt_poe_wiki);
            this.Controls.Add(this.lbl_clear);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.chk_poe_autolaunch);
            this.Controls.Add(this.chk_helper_autolaunch);
            this.Controls.Add(this.chk_autoonline_autolaunch);
            this.Controls.Add(this.chk_procurement_autolaunch);
            this.Controls.Add(this.lbl_poe_status);
            this.Controls.Add(this.lbl_helper_status);
            this.Controls.Add(this.lbl_autoonline_status);
            this.Controls.Add(this.lbl_procurement_status);
            this.Controls.Add(this.btn_poe_stop);
            this.Controls.Add(this.btn_helper_stop);
            this.Controls.Add(this.btn_autoonline_stop);
            this.Controls.Add(this.btn_procurement_stop);
            this.Controls.Add(this.btn_poe_start);
            this.Controls.Add(this.btn_helper_start);
            this.Controls.Add(this.btn_autoonline_start);
            this.Controls.Add(this.btn_procurement_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PoE Manager";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Move += new System.EventHandler(this.MainFrm_Move);
            this.pnl_bottombar.ResumeLayout(false);
            this.pnl_bottombar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_autoonline_start;
        private System.Windows.Forms.Button btn_helper_start;
        private System.Windows.Forms.Button btn_poe_start;
        private System.Windows.Forms.Button btn_procurement_start;
        private System.Windows.Forms.Button btn_procurement_stop;
        private System.Windows.Forms.Button btn_autoonline_stop;
        private System.Windows.Forms.Button btn_helper_stop;
        private System.Windows.Forms.Button btn_poe_stop;
        private System.Windows.Forms.Label lbl_procurement_status;
        private System.Windows.Forms.Label lbl_autoonline_status;
        private System.Windows.Forms.Label lbl_helper_status;
        private System.Windows.Forms.Label lbl_poe_status;
        private System.Windows.Forms.CheckBox chk_procurement_autolaunch;
        private System.Windows.Forms.CheckBox chk_autoonline_autolaunch;
        private System.Windows.Forms.CheckBox chk_helper_autolaunch;
        private System.Windows.Forms.CheckBox chk_poe_autolaunch;
        private System.Windows.Forms.Label lbl_credits;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.CheckBox chk_starthidden;
        private System.Windows.Forms.Label lbl_clear;
        private System.Windows.Forms.OpenFileDialog dlg_poe_path;
        private System.Windows.Forms.TextBox txt_poe_wiki;
        private System.Windows.Forms.Button btn_poe_wiki_search;
        private System.Windows.Forms.Button btn_procurement_minimize;
        private System.Windows.Forms.Button btn_poe_minimize;
        private System.Windows.Forms.Button btn_poe_trade_search;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Label lbl_topbar;
        private System.Windows.Forms.Panel pnl_bottombar;
    }
}

