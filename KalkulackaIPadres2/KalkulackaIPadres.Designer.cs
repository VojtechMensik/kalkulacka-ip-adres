namespace KalkulackaIPadres2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVstup = new System.Windows.Forms.ComboBox();
            this.comboBoxVystup = new System.Windows.Forms.ComboBox();
            this.comboBoxIp = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxVstup = new System.Windows.Forms.MaskedTextBox();
            this.textBoxVystup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formátovat z soustavy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formátovat do soustavy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Typ ip adresy:";
            // 
            // comboBoxVstup
            // 
            this.comboBoxVstup.FormattingEnabled = true;
            this.comboBoxVstup.Items.AddRange(new object[] {
            "decimální",
            "binární",
            "hexadecimální"});
            this.comboBoxVstup.Location = new System.Drawing.Point(27, 56);
            this.comboBoxVstup.Name = "comboBoxVstup";
            this.comboBoxVstup.Size = new System.Drawing.Size(139, 23);
            this.comboBoxVstup.TabIndex = 3;
            this.comboBoxVstup.SelectedIndexChanged += new System.EventHandler(this.comboBoxVstup_SelectedIndexChanged);
            // 
            // comboBoxVystup
            // 
            this.comboBoxVystup.FormattingEnabled = true;
            this.comboBoxVystup.Items.AddRange(new object[] {
            "decimální",
            "binární",
            "hexadecimální"});
            this.comboBoxVystup.Location = new System.Drawing.Point(527, 56);
            this.comboBoxVystup.Name = "comboBoxVystup";
            this.comboBoxVystup.Size = new System.Drawing.Size(137, 23);
            this.comboBoxVystup.TabIndex = 4;
            this.comboBoxVystup.SelectedIndexChanged += new System.EventHandler(this.comboBoxVystup_SelectedIndexChanged);
            // 
            // comboBoxIp
            // 
            this.comboBoxIp.FormattingEnabled = true;
            this.comboBoxIp.Items.AddRange(new object[] {
            "IPv4",
            "IPv6"});
            this.comboBoxIp.Location = new System.Drawing.Point(293, 56);
            this.comboBoxIp.Name = "comboBoxIp";
            this.comboBoxIp.Size = new System.Drawing.Size(121, 23);
            this.comboBoxIp.TabIndex = 5;
            this.comboBoxIp.SelectedIndexChanged += new System.EventHandler(this.comboBoxIp_SelectedIndexChanged);
            // 
            // maskedTextBoxVstup
            // 
            this.maskedTextBoxVstup.Location = new System.Drawing.Point(28, 170);
            this.maskedTextBoxVstup.Name = "maskedTextBoxVstup";
            this.maskedTextBoxVstup.Size = new System.Drawing.Size(667, 23);
            this.maskedTextBoxVstup.TabIndex = 6;
            // 
            // textBoxVystup
            // 
            this.textBoxVystup.Location = new System.Drawing.Point(29, 245);
            this.textBoxVystup.Name = "textBoxVystup";
            this.textBoxVystup.ReadOnly = true;
            this.textBoxVystup.Size = new System.Drawing.Size(667, 23);
            this.textBoxVystup.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vstup:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Výstup:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVystup);
            this.Controls.Add(this.maskedTextBoxVstup);
            this.Controls.Add(this.comboBoxIp);
            this.Controls.Add(this.comboBoxVystup);
            this.Controls.Add(this.comboBoxVstup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(737, 327);
            this.MinimumSize = new System.Drawing.Size(737, 327);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kalkulačka IP adres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxVstup;
        private ComboBox comboBoxVystup;
        private ComboBox comboBoxIp;
        private MaskedTextBox maskedTextBoxVstup;
        private TextBox textBoxVystup;
        private Label label4;
        private Label label5;
    }
}