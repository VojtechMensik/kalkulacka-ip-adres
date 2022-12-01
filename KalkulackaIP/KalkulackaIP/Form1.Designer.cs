namespace PrevodSoustav
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxVstup = new System.Windows.Forms.ComboBox();
            this.comboBoxVystup = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxVstup = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVystup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxIp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxVstup
            // 
            this.comboBoxVstup.FormattingEnabled = true;
            this.comboBoxVstup.Items.AddRange(new object[] {
            "decimální",
            "binární",
            "hexadecimální"});
            this.comboBoxVstup.Location = new System.Drawing.Point(13, 35);
            this.comboBoxVstup.Name = "comboBoxVstup";
            this.comboBoxVstup.Size = new System.Drawing.Size(183, 23);
            this.comboBoxVstup.TabIndex = 0;
            this.comboBoxVstup.SelectedIndexChanged += new System.EventHandler(this.comboBoxVstup_SelectedIndexChanged);
            // 
            // comboBoxVystup
            // 
            this.comboBoxVystup.FormattingEnabled = true;
            this.comboBoxVystup.Items.AddRange(new object[] {
            "decimální",
            "binární",
            "hexadecimální"});
            this.comboBoxVystup.Location = new System.Drawing.Point(278, 35);
            this.comboBoxVystup.Name = "comboBoxVystup";
            this.comboBoxVystup.Size = new System.Drawing.Size(168, 23);
            this.comboBoxVystup.TabIndex = 1;
            this.comboBoxVystup.SelectedIndexChanged += new System.EventHandler(this.comboBoxVystup_SelectedIndexChanged);
            // 
            // maskedTextBoxVstup
            // 
            this.maskedTextBoxVstup.Location = new System.Drawing.Point(12, 142);
            this.maskedTextBoxVstup.Name = "maskedTextBoxVstup";
            this.maskedTextBoxVstup.Size = new System.Drawing.Size(676, 23);
            this.maskedTextBoxVstup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Převod z soustavy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Převod do soustavy:";
            // 
            // textBoxVystup
            // 
            this.textBoxVystup.Location = new System.Drawing.Point(13, 196);
            this.textBoxVystup.Name = "textBoxVystup";
            this.textBoxVystup.ReadOnly = true;
            this.textBoxVystup.Size = new System.Drawing.Size(675, 23);
            this.textBoxVystup.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vstup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Výstup";
            // 
            // comboBoxIp
            // 
            this.comboBoxIp.FormattingEnabled = true;
            this.comboBoxIp.Items.AddRange(new object[] {
            "IPv4",
            "IPv6"});
            this.comboBoxIp.Location = new System.Drawing.Point(517, 35);
            this.comboBoxIp.Name = "comboBoxIp";
            this.comboBoxIp.Size = new System.Drawing.Size(168, 23);
            this.comboBoxIp.TabIndex = 8;
            this.comboBoxIp.SelectedIndexChanged += new System.EventHandler(this.comboBoxIp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Druh IP adresy:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 263);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxIp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVystup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxVstup);
            this.Controls.Add(this.comboBoxVystup);
            this.Controls.Add(this.comboBoxVstup);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(717, 302);
            this.MinimumSize = new System.Drawing.Size(717, 302);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kalkulačka převodu IP adresy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxVstup;
        private ComboBox comboBoxVystup;
        private MaskedTextBox maskedTextBoxVstup;
        private Label label1;
        private Label label2;
        private TextBox textBoxVystup;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxIp;
        private Label label5;
    }
}