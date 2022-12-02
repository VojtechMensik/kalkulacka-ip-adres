namespace KalkulackaIPadres
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxVstup = new System.Windows.Forms.ComboBox();
            this.comboBoxIp = new System.Windows.Forms.ComboBox();
            this.comboBoxVystup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxVstup = new System.Windows.Forms.MaskedTextBox();
            this.textBoxVystup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxVstup
            // 
            this.comboBoxVstup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVstup.FormattingEnabled = true;
            this.comboBoxVstup.Items.AddRange(new object[] {
            "Decimální",
            "Binární",
            "Hexadecimální"});
            this.comboBoxVstup.Location = new System.Drawing.Point(12, 28);
            this.comboBoxVstup.Name = "comboBoxVstup";
            this.comboBoxVstup.Size = new System.Drawing.Size(150, 21);
            this.comboBoxVstup.TabIndex = 0;
            this.comboBoxVstup.SelectedIndexChanged += new System.EventHandler(this.comboBoxVstup_SelectedIndexChanged);
            // 
            // comboBoxIp
            // 
            this.comboBoxIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIp.FormattingEnabled = true;
            this.comboBoxIp.Items.AddRange(new object[] {
            "IPv4",
            "IPv6"});
            this.comboBoxIp.Location = new System.Drawing.Point(246, 28);
            this.comboBoxIp.Name = "comboBoxIp";
            this.comboBoxIp.Size = new System.Drawing.Size(150, 21);
            this.comboBoxIp.TabIndex = 1;
            this.comboBoxIp.SelectedIndexChanged += new System.EventHandler(this.comboBoxIp_SelectedIndexChanged);
            // 
            // comboBoxVystup
            // 
            this.comboBoxVystup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVystup.FormattingEnabled = true;
            this.comboBoxVystup.Items.AddRange(new object[] {
            "Decimální",
            "Binární",
            "Hexadecimální"});
            this.comboBoxVystup.Location = new System.Drawing.Point(478, 28);
            this.comboBoxVystup.Name = "comboBoxVystup";
            this.comboBoxVystup.Size = new System.Drawing.Size(150, 21);
            this.comboBoxVystup.TabIndex = 2;
            this.comboBoxVystup.SelectedIndexChanged += new System.EventHandler(this.comboBoxVystup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Převod ze soustavy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Druh IP adresy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Převod do soustavy:";
            // 
            // maskedTextBoxVstup
            // 
            this.maskedTextBoxVstup.Location = new System.Drawing.Point(12, 114);
            this.maskedTextBoxVstup.Name = "maskedTextBoxVstup";
            this.maskedTextBoxVstup.Size = new System.Drawing.Size(616, 20);
            this.maskedTextBoxVstup.TabIndex = 6;
            // 
            // textBoxVystup
            // 
            this.textBoxVystup.Location = new System.Drawing.Point(12, 165);
            this.textBoxVystup.Name = "textBoxVystup";
            this.textBoxVystup.ReadOnly = true;
            this.textBoxVystup.Size = new System.Drawing.Size(616, 20);
            this.textBoxVystup.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vstup:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vystup:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 207);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVystup);
            this.Controls.Add(this.maskedTextBoxVstup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVystup);
            this.Controls.Add(this.comboBoxIp);
            this.Controls.Add(this.comboBoxVstup);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(659, 246);
            this.MinimumSize = new System.Drawing.Size(659, 246);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kalkulačka IP adres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVstup;
        private System.Windows.Forms.ComboBox comboBoxIp;
        private System.Windows.Forms.ComboBox comboBoxVystup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVstup;
        private System.Windows.Forms.TextBox textBoxVystup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

