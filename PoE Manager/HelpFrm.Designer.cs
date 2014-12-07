namespace PoE_Manager
{
    partial class HelpFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_poemanager_hotkey = new System.Windows.Forms.Label();
            this.lbl_helper_hotkeys = new System.Windows.Forms.Label();
            this.lbl_helper_quit_hotkey = new System.Windows.Forms.Label();
            this.lbl_helper_remaining_hotkey = new System.Windows.Forms.Label();
            this.lbl_helper_itemlevel_hotkey = new System.Windows.Forms.Label();
            this.lbl_helper_oos_hotkey = new System.Windows.Forms.Label();
            this.pnl_topbar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_poemanager_hotkey
            // 
            this.lbl_poemanager_hotkey.AutoSize = true;
            this.lbl_poemanager_hotkey.Location = new System.Drawing.Point(222, 55);
            this.lbl_poemanager_hotkey.Name = "lbl_poemanager_hotkey";
            this.lbl_poemanager_hotkey.Size = new System.Drawing.Size(0, 13);
            this.lbl_poemanager_hotkey.TabIndex = 1;
            this.lbl_poemanager_hotkey.Tag = "POEMANAGER_HOTKEY";
            // 
            // lbl_helper_hotkeys
            // 
            this.lbl_helper_hotkeys.AutoSize = true;
            this.lbl_helper_hotkeys.Location = new System.Drawing.Point(222, 90);
            this.lbl_helper_hotkeys.Name = "lbl_helper_hotkeys";
            this.lbl_helper_hotkeys.Size = new System.Drawing.Size(0, 13);
            this.lbl_helper_hotkeys.TabIndex = 2;
            this.lbl_helper_hotkeys.Tag = "HELPER_HOTKEYS";
            // 
            // lbl_helper_quit_hotkey
            // 
            this.lbl_helper_quit_hotkey.AutoSize = true;
            this.lbl_helper_quit_hotkey.Location = new System.Drawing.Point(222, 120);
            this.lbl_helper_quit_hotkey.Name = "lbl_helper_quit_hotkey";
            this.lbl_helper_quit_hotkey.Size = new System.Drawing.Size(0, 13);
            this.lbl_helper_quit_hotkey.TabIndex = 3;
            this.lbl_helper_quit_hotkey.Tag = "HELPER_QUIT_HOTKEY";
            // 
            // lbl_helper_remaining_hotkey
            // 
            this.lbl_helper_remaining_hotkey.AutoSize = true;
            this.lbl_helper_remaining_hotkey.Location = new System.Drawing.Point(222, 145);
            this.lbl_helper_remaining_hotkey.Name = "lbl_helper_remaining_hotkey";
            this.lbl_helper_remaining_hotkey.Size = new System.Drawing.Size(0, 13);
            this.lbl_helper_remaining_hotkey.TabIndex = 4;
            this.lbl_helper_remaining_hotkey.Tag = "HELPER_REMAINING_HOTKEY";
            // 
            // lbl_helper_itemlevel_hotkey
            // 
            this.lbl_helper_itemlevel_hotkey.AutoSize = true;
            this.lbl_helper_itemlevel_hotkey.Location = new System.Drawing.Point(222, 170);
            this.lbl_helper_itemlevel_hotkey.Name = "lbl_helper_itemlevel_hotkey";
            this.lbl_helper_itemlevel_hotkey.Size = new System.Drawing.Size(0, 13);
            this.lbl_helper_itemlevel_hotkey.TabIndex = 5;
            this.lbl_helper_itemlevel_hotkey.Tag = "HELPER_ITEMLEVEL_HOTKEY";
            // 
            // lbl_helper_oos_hotkey
            // 
            this.lbl_helper_oos_hotkey.AutoSize = true;
            this.lbl_helper_oos_hotkey.Location = new System.Drawing.Point(222, 195);
            this.lbl_helper_oos_hotkey.Name = "lbl_helper_oos_hotkey";
            this.lbl_helper_oos_hotkey.Size = new System.Drawing.Size(0, 13);
            this.lbl_helper_oos_hotkey.TabIndex = 6;
            this.lbl_helper_oos_hotkey.Tag = "HELPER_OOS_HOTKEY";
            // 
            // pnl_topbar
            // 
            this.pnl_topbar.Controls.Add(this.lbl_title);
            this.pnl_topbar.Location = new System.Drawing.Point(0, -4);
            this.pnl_topbar.Name = "pnl_topbar";
            this.pnl_topbar.Size = new System.Drawing.Size(420, 33);
            this.pnl_topbar.TabIndex = 44;
            this.pnl_topbar.Tag = "TOPBAR_LONG";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(287, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 13);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Tag = "TITLE";
            this.lbl_title.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_title_MouseClick);
            // 
            // HelpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 212);
            this.Controls.Add(this.pnl_topbar);
            this.Controls.Add(this.lbl_helper_oos_hotkey);
            this.Controls.Add(this.lbl_helper_itemlevel_hotkey);
            this.Controls.Add(this.lbl_helper_remaining_hotkey);
            this.Controls.Add(this.lbl_helper_quit_hotkey);
            this.Controls.Add(this.lbl_helper_hotkeys);
            this.Controls.Add(this.lbl_poemanager_hotkey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HelpFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HelpFrm";
            this.pnl_topbar.ResumeLayout(false);
            this.pnl_topbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_poemanager_hotkey;
        private System.Windows.Forms.Label lbl_helper_hotkeys;
        private System.Windows.Forms.Label lbl_helper_quit_hotkey;
        private System.Windows.Forms.Label lbl_helper_remaining_hotkey;
        private System.Windows.Forms.Label lbl_helper_itemlevel_hotkey;
        private System.Windows.Forms.Label lbl_helper_oos_hotkey;
        private System.Windows.Forms.Panel pnl_topbar;
        private System.Windows.Forms.Label lbl_title;
    }
}