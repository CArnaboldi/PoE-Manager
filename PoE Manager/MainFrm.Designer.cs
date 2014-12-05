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
            this.lbl_outline_top = new System.Windows.Forms.Label();
            this.lbl_outline_bottom = new System.Windows.Forms.Label();
            this.chk_starthidden = new System.Windows.Forms.CheckBox();
            this.lbl_clear = new System.Windows.Forms.Label();
            this.dlg_poe_path = new System.Windows.Forms.OpenFileDialog();
            this.lbl_outline_top_2 = new System.Windows.Forms.Label();
            this.lbl_outline_top_3 = new System.Windows.Forms.Label();
            this.lbl_outline_top_4 = new System.Windows.Forms.Label();
            this.lbl_outline_top_5 = new System.Windows.Forms.Label();
            this.lbl_outline_top_6 = new System.Windows.Forms.Label();
            this.lbl_outline_bottom_2 = new System.Windows.Forms.Label();
            this.lbl_outline_bottom_3 = new System.Windows.Forms.Label();
            this.lbl_outline_bottom_4 = new System.Windows.Forms.Label();
            this.lbl_outline_bottom_5 = new System.Windows.Forms.Label();
            this.txt_poe_wiki = new System.Windows.Forms.TextBox();
            this.btn_poe_wiki_search = new System.Windows.Forms.Button();
            this.lbl_shortcut_hint = new System.Windows.Forms.Label();
            this.lbl_poe_manager = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_autoonline_start
            // 
            this.btn_autoonline_start.Location = new System.Drawing.Point(107, 38);
            this.btn_autoonline_start.Name = "btn_autoonline_start";
            this.btn_autoonline_start.Size = new System.Drawing.Size(100, 42);
            this.btn_autoonline_start.TabIndex = 2;
            this.btn_autoonline_start.Tag = "start";
            this.btn_autoonline_start.UseVisualStyleBackColor = true;
            this.btn_autoonline_start.Click += new System.EventHandler(this.btn_autoonline_start_Click);
            // 
            // btn_helper_start
            // 
            this.btn_helper_start.Location = new System.Drawing.Point(213, 38);
            this.btn_helper_start.Name = "btn_helper_start";
            this.btn_helper_start.Size = new System.Drawing.Size(100, 42);
            this.btn_helper_start.TabIndex = 3;
            this.btn_helper_start.Tag = "start";
            this.btn_helper_start.UseVisualStyleBackColor = true;
            this.btn_helper_start.Click += new System.EventHandler(this.btn_helper_start_Click);
            // 
            // btn_poe_start
            // 
            this.btn_poe_start.Location = new System.Drawing.Point(319, 38);
            this.btn_poe_start.Name = "btn_poe_start";
            this.btn_poe_start.Size = new System.Drawing.Size(100, 42);
            this.btn_poe_start.TabIndex = 4;
            this.btn_poe_start.Tag = "start";
            this.btn_poe_start.UseVisualStyleBackColor = true;
            this.btn_poe_start.Click += new System.EventHandler(this.btn_poe_start_Click);
            // 
            // btn_procurement_start
            // 
            this.btn_procurement_start.Location = new System.Drawing.Point(1, 38);
            this.btn_procurement_start.Name = "btn_procurement_start";
            this.btn_procurement_start.Size = new System.Drawing.Size(100, 42);
            this.btn_procurement_start.TabIndex = 1;
            this.btn_procurement_start.Tag = "start";
            this.btn_procurement_start.UseVisualStyleBackColor = true;
            this.btn_procurement_start.Click += new System.EventHandler(this.btn_procurement_start_Click);
            // 
            // btn_procurement_stop
            // 
            this.btn_procurement_stop.Location = new System.Drawing.Point(1, 115);
            this.btn_procurement_stop.Name = "btn_procurement_stop";
            this.btn_procurement_stop.Size = new System.Drawing.Size(100, 42);
            this.btn_procurement_stop.TabIndex = 5;
            this.btn_procurement_stop.Tag = "stop";
            this.btn_procurement_stop.UseVisualStyleBackColor = true;
            this.btn_procurement_stop.Click += new System.EventHandler(this.btn_procurement_stop_Click);
            // 
            // btn_autoonline_stop
            // 
            this.btn_autoonline_stop.Location = new System.Drawing.Point(107, 115);
            this.btn_autoonline_stop.Name = "btn_autoonline_stop";
            this.btn_autoonline_stop.Size = new System.Drawing.Size(100, 42);
            this.btn_autoonline_stop.TabIndex = 6;
            this.btn_autoonline_stop.Tag = "stop";
            this.btn_autoonline_stop.UseVisualStyleBackColor = true;
            this.btn_autoonline_stop.Click += new System.EventHandler(this.btn_autoonline_stop_Click);
            // 
            // btn_helper_stop
            // 
            this.btn_helper_stop.Location = new System.Drawing.Point(213, 115);
            this.btn_helper_stop.Name = "btn_helper_stop";
            this.btn_helper_stop.Size = new System.Drawing.Size(100, 42);
            this.btn_helper_stop.TabIndex = 7;
            this.btn_helper_stop.Tag = "stop";
            this.btn_helper_stop.UseVisualStyleBackColor = true;
            this.btn_helper_stop.Click += new System.EventHandler(this.btn_helper_stop_Click);
            // 
            // btn_poe_stop
            // 
            this.btn_poe_stop.Location = new System.Drawing.Point(319, 115);
            this.btn_poe_stop.Name = "btn_poe_stop";
            this.btn_poe_stop.Size = new System.Drawing.Size(100, 42);
            this.btn_poe_stop.TabIndex = 8;
            this.btn_poe_stop.Tag = "stop";
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
            this.chk_procurement_autolaunch.TabIndex = 9;
            this.chk_procurement_autolaunch.Tag = "PROCUREMENT";
            this.chk_procurement_autolaunch.UseVisualStyleBackColor = true;
            this.chk_procurement_autolaunch.CheckedChanged += new System.EventHandler(this.chk_procurement_autolaunch_CheckedChanged);
            // 
            // chk_autoonline_autolaunch
            // 
            this.chk_autoonline_autolaunch.Location = new System.Drawing.Point(107, 163);
            this.chk_autoonline_autolaunch.Name = "chk_autoonline_autolaunch";
            this.chk_autoonline_autolaunch.Size = new System.Drawing.Size(100, 24);
            this.chk_autoonline_autolaunch.TabIndex = 10;
            this.chk_autoonline_autolaunch.Tag = "AUTOONLINE";
            this.chk_autoonline_autolaunch.UseVisualStyleBackColor = true;
            this.chk_autoonline_autolaunch.CheckedChanged += new System.EventHandler(this.chk_autoonline_autolaunch_CheckedChanged);
            // 
            // chk_helper_autolaunch
            // 
            this.chk_helper_autolaunch.Location = new System.Drawing.Point(213, 163);
            this.chk_helper_autolaunch.Name = "chk_helper_autolaunch";
            this.chk_helper_autolaunch.Size = new System.Drawing.Size(100, 24);
            this.chk_helper_autolaunch.TabIndex = 11;
            this.chk_helper_autolaunch.Tag = "HELPER";
            this.chk_helper_autolaunch.UseVisualStyleBackColor = true;
            this.chk_helper_autolaunch.CheckedChanged += new System.EventHandler(this.chk_helper_autolaunch_CheckedChanged);
            // 
            // chk_poe_autolaunch
            // 
            this.chk_poe_autolaunch.Location = new System.Drawing.Point(319, 163);
            this.chk_poe_autolaunch.Name = "chk_poe_autolaunch";
            this.chk_poe_autolaunch.Size = new System.Drawing.Size(100, 24);
            this.chk_poe_autolaunch.TabIndex = 12;
            this.chk_poe_autolaunch.Tag = "POE";
            this.chk_poe_autolaunch.UseVisualStyleBackColor = true;
            this.chk_poe_autolaunch.CheckedChanged += new System.EventHandler(this.chk_poe_autolaunch_CheckedChanged);
            // 
            // lbl_credits
            // 
            this.lbl_credits.AutoSize = true;
            this.lbl_credits.Location = new System.Drawing.Point(263, 262);
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
            this.lbl_close.Tag = "close";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            this.lbl_close.MouseEnter += new System.EventHandler(this.lbl_close_MouseEnter);
            this.lbl_close.MouseLeave += new System.EventHandler(this.lbl_close_MouseLeave);
            // 
            // lbl_outline_top
            // 
            this.lbl_outline_top.Location = new System.Drawing.Point(0, 0);
            this.lbl_outline_top.Name = "lbl_outline_top";
            this.lbl_outline_top.Size = new System.Drawing.Size(320, 4);
            this.lbl_outline_top.TabIndex = 19;
            this.lbl_outline_top.Tag = "outline";
            // 
            // lbl_outline_bottom
            // 
            this.lbl_outline_bottom.Location = new System.Drawing.Point(0, 277);
            this.lbl_outline_bottom.Name = "lbl_outline_bottom";
            this.lbl_outline_bottom.Size = new System.Drawing.Size(420, 3);
            this.lbl_outline_bottom.TabIndex = 20;
            this.lbl_outline_bottom.Tag = "outline";
            // 
            // chk_starthidden
            // 
            this.chk_starthidden.Location = new System.Drawing.Point(50, 259);
            this.chk_starthidden.Name = "chk_starthidden";
            this.chk_starthidden.Size = new System.Drawing.Size(100, 18);
            this.chk_starthidden.TabIndex = 21;
            this.chk_starthidden.Tag = "STARTHIDDEN";
            this.chk_starthidden.UseVisualStyleBackColor = true;
            this.chk_starthidden.CheckedChanged += new System.EventHandler(this.chk_starthidden_CheckedChanged);
            // 
            // lbl_clear
            // 
            this.lbl_clear.Location = new System.Drawing.Point(319, -4);
            this.lbl_clear.Name = "lbl_clear";
            this.lbl_clear.Size = new System.Drawing.Size(84, 23);
            this.lbl_clear.TabIndex = 22;
            this.lbl_clear.Tag = "clear";
            this.lbl_clear.Click += new System.EventHandler(this.lbl_clear_Click);
            this.lbl_clear.MouseEnter += new System.EventHandler(this.lbl_clear_MouseEnter);
            this.lbl_clear.MouseLeave += new System.EventHandler(this.lbl_clear_MouseLeave);
            // 
            // dlg_poe_path
            // 
            this.dlg_poe_path.FileName = "Path of Exile Executable";
            // 
            // lbl_outline_top_2
            // 
            this.lbl_outline_top_2.Location = new System.Drawing.Point(160, 3);
            this.lbl_outline_top_2.Name = "lbl_outline_top_2";
            this.lbl_outline_top_2.Size = new System.Drawing.Size(159, 3);
            this.lbl_outline_top_2.TabIndex = 23;
            this.lbl_outline_top_2.Tag = "outline";
            // 
            // lbl_outline_top_3
            // 
            this.lbl_outline_top_3.Location = new System.Drawing.Point(240, 6);
            this.lbl_outline_top_3.Name = "lbl_outline_top_3";
            this.lbl_outline_top_3.Size = new System.Drawing.Size(79, 3);
            this.lbl_outline_top_3.TabIndex = 24;
            this.lbl_outline_top_3.Tag = "outline";
            // 
            // lbl_outline_top_4
            // 
            this.lbl_outline_top_4.Location = new System.Drawing.Point(280, 9);
            this.lbl_outline_top_4.Name = "lbl_outline_top_4";
            this.lbl_outline_top_4.Size = new System.Drawing.Size(39, 3);
            this.lbl_outline_top_4.TabIndex = 25;
            this.lbl_outline_top_4.Tag = "outline";
            // 
            // lbl_outline_top_5
            // 
            this.lbl_outline_top_5.Location = new System.Drawing.Point(300, 12);
            this.lbl_outline_top_5.Name = "lbl_outline_top_5";
            this.lbl_outline_top_5.Size = new System.Drawing.Size(19, 3);
            this.lbl_outline_top_5.TabIndex = 26;
            this.lbl_outline_top_5.Tag = "outline";
            // 
            // lbl_outline_top_6
            // 
            this.lbl_outline_top_6.Location = new System.Drawing.Point(310, 15);
            this.lbl_outline_top_6.Name = "lbl_outline_top_6";
            this.lbl_outline_top_6.Size = new System.Drawing.Size(9, 2);
            this.lbl_outline_top_6.TabIndex = 27;
            this.lbl_outline_top_6.Tag = "outline";
            // 
            // lbl_outline_bottom_2
            // 
            this.lbl_outline_bottom_2.Location = new System.Drawing.Point(0, 274);
            this.lbl_outline_bottom_2.Name = "lbl_outline_bottom_2";
            this.lbl_outline_bottom_2.Size = new System.Drawing.Size(40, 3);
            this.lbl_outline_bottom_2.TabIndex = 28;
            this.lbl_outline_bottom_2.Tag = "outline";
            // 
            // lbl_outline_bottom_3
            // 
            this.lbl_outline_bottom_3.Location = new System.Drawing.Point(0, 271);
            this.lbl_outline_bottom_3.Name = "lbl_outline_bottom_3";
            this.lbl_outline_bottom_3.Size = new System.Drawing.Size(20, 3);
            this.lbl_outline_bottom_3.TabIndex = 29;
            this.lbl_outline_bottom_3.Tag = "outline";
            // 
            // lbl_outline_bottom_4
            // 
            this.lbl_outline_bottom_4.Location = new System.Drawing.Point(0, 268);
            this.lbl_outline_bottom_4.Name = "lbl_outline_bottom_4";
            this.lbl_outline_bottom_4.Size = new System.Drawing.Size(10, 4);
            this.lbl_outline_bottom_4.TabIndex = 30;
            this.lbl_outline_bottom_4.Tag = "outline";
            // 
            // lbl_outline_bottom_5
            // 
            this.lbl_outline_bottom_5.Location = new System.Drawing.Point(0, 264);
            this.lbl_outline_bottom_5.Name = "lbl_outline_bottom_5";
            this.lbl_outline_bottom_5.Size = new System.Drawing.Size(5, 5);
            this.lbl_outline_bottom_5.TabIndex = 31;
            this.lbl_outline_bottom_5.Tag = "outline";
            // 
            // txt_poe_wiki
            // 
            this.txt_poe_wiki.Location = new System.Drawing.Point(30, 207);
            this.txt_poe_wiki.Name = "txt_poe_wiki";
            this.txt_poe_wiki.Size = new System.Drawing.Size(297, 20);
            this.txt_poe_wiki.TabIndex = 0;
            this.txt_poe_wiki.Tag = "wiki";
            this.txt_poe_wiki.Enter += new System.EventHandler(this.txt_poe_wiki_Enter);
            this.txt_poe_wiki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_poe_wiki_KeyPress);
            // 
            // btn_poe_wiki_search
            // 
            this.btn_poe_wiki_search.Location = new System.Drawing.Point(327, 207);
            this.btn_poe_wiki_search.Name = "btn_poe_wiki_search";
            this.btn_poe_wiki_search.Size = new System.Drawing.Size(60, 28);
            this.btn_poe_wiki_search.TabIndex = 33;
            this.btn_poe_wiki_search.Tag = "wiki";
            this.btn_poe_wiki_search.UseVisualStyleBackColor = true;
            this.btn_poe_wiki_search.Click += new System.EventHandler(this.btn_poe_wiki_search_Click);
            // 
            // lbl_shortcut_hint
            // 
            this.lbl_shortcut_hint.AutoSize = true;
            this.lbl_shortcut_hint.Location = new System.Drawing.Point(130, 9);
            this.lbl_shortcut_hint.Name = "lbl_shortcut_hint";
            this.lbl_shortcut_hint.Size = new System.Drawing.Size(0, 13);
            this.lbl_shortcut_hint.TabIndex = 34;
            this.lbl_shortcut_hint.Tag = "shortcut";
            // 
            // lbl_poe_manager
            // 
            this.lbl_poe_manager.AutoSize = true;
            this.lbl_poe_manager.Location = new System.Drawing.Point(0, 7);
            this.lbl_poe_manager.Name = "lbl_poe_manager";
            this.lbl_poe_manager.Size = new System.Drawing.Size(0, 13);
            this.lbl_poe_manager.TabIndex = 35;
            this.lbl_poe_manager.Tag = "title";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 252);
            this.Controls.Add(this.lbl_poe_manager);
            this.Controls.Add(this.lbl_shortcut_hint);
            this.Controls.Add(this.btn_poe_wiki_search);
            this.Controls.Add(this.txt_poe_wiki);
            this.Controls.Add(this.lbl_outline_bottom_5);
            this.Controls.Add(this.lbl_outline_bottom_4);
            this.Controls.Add(this.lbl_outline_bottom_3);
            this.Controls.Add(this.lbl_outline_bottom_2);
            this.Controls.Add(this.lbl_outline_top_6);
            this.Controls.Add(this.lbl_outline_top_5);
            this.Controls.Add(this.lbl_outline_top_4);
            this.Controls.Add(this.lbl_outline_top_3);
            this.Controls.Add(this.lbl_outline_top_2);
            this.Controls.Add(this.lbl_clear);
            this.Controls.Add(this.chk_starthidden);
            this.Controls.Add(this.lbl_outline_bottom);
            this.Controls.Add(this.lbl_outline_top);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_credits);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoE Manager";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Label lbl_outline_top;
        private System.Windows.Forms.Label lbl_outline_bottom;
        private System.Windows.Forms.CheckBox chk_starthidden;
        private System.Windows.Forms.Label lbl_clear;
        private System.Windows.Forms.OpenFileDialog dlg_poe_path;
        private System.Windows.Forms.Label lbl_outline_top_2;
        private System.Windows.Forms.Label lbl_outline_top_3;
        private System.Windows.Forms.Label lbl_outline_top_4;
        private System.Windows.Forms.Label lbl_outline_top_5;
        private System.Windows.Forms.Label lbl_outline_top_6;
        private System.Windows.Forms.Label lbl_outline_top_7;
        private System.Windows.Forms.Label lbl_outline_bottom_2;
        private System.Windows.Forms.Label lbl_outline_bottom_3;
        private System.Windows.Forms.Label lbl_outline_bottom_4;
        private System.Windows.Forms.Label lbl_outline_bottom_5;
        private System.Windows.Forms.TextBox txt_poe_wiki;
        private System.Windows.Forms.Button btn_poe_wiki_search;
        private System.Windows.Forms.Label lbl_shortcut_hint;
        private System.Windows.Forms.Label lbl_poe_manager;
    }
}

