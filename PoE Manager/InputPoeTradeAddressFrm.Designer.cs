namespace PoE_Manager
{
    partial class InputPoeTradeAddressFrm
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
            this.lbl_input = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_poetrade_web = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(12, 9);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(306, 13);
            this.lbl_input.TabIndex = 3;
            this.lbl_input.Text = "Input your poe.trade address. If you don\'t have it yet, check out";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(15, 57);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(303, 20);
            this.txt_input.TabIndex = 0;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Enabled = false;
            this.btn_submit.Location = new System.Drawing.Point(133, 92);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "&Ok";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_poetrade_web
            // 
            this.lbl_poetrade_web.AutoSize = true;
            this.lbl_poetrade_web.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_poetrade_web.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poetrade_web.Location = new System.Drawing.Point(74, 29);
            this.lbl_poetrade_web.Name = "lbl_poetrade_web";
            this.lbl_poetrade_web.Size = new System.Drawing.Size(193, 16);
            this.lbl_poetrade_web.TabIndex = 2;
            this.lbl_poetrade_web.Text = "http://poe.trade/online.html";
            this.lbl_poetrade_web.Click += new System.EventHandler(this.lbl_poetrade_web_Click);
            this.lbl_poetrade_web.MouseEnter += new System.EventHandler(this.lbl_poetrade_web_MouseEnter);
            this.lbl_poetrade_web.MouseLeave += new System.EventHandler(this.lbl_poetrade_web_MouseLeave);
            // 
            // InputPoeTradeAddressFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 127);
            this.Controls.Add(this.lbl_poetrade_web);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputPoeTradeAddressFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input poe.trade address";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_poetrade_web;
    }
}