namespace Presentationslager
{
    partial class SkapaBokning
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
            this.label1 = new System.Windows.Forms.Label();
            this.LedigaBöckerListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SökDatumKnapp = new System.Windows.Forms.Button();
            this.BokningsDatumVäljare = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.MedlemComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista på böcker som är tillgängliga för valt datum:";
            // 
            // LedigaBöckerListBox
            // 
            this.LedigaBöckerListBox.FormattingEnabled = true;
            this.LedigaBöckerListBox.Location = new System.Drawing.Point(42, 199);
            this.LedigaBöckerListBox.Name = "LedigaBöckerListBox";
            this.LedigaBöckerListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LedigaBöckerListBox.Size = new System.Drawing.Size(233, 199);
            this.LedigaBöckerListBox.TabIndex = 2;
            this.LedigaBöckerListBox.SelectedIndexChanged += new System.EventHandler(this.LedigaBöckerListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medlemsnummer för medlem som äger bokning:";
            // 
            // SökDatumKnapp
            // 
            this.SökDatumKnapp.Location = new System.Drawing.Point(229, 75);
            this.SökDatumKnapp.Name = "SökDatumKnapp";
            this.SökDatumKnapp.Size = new System.Drawing.Size(46, 23);
            this.SökDatumKnapp.TabIndex = 5;
            this.SökDatumKnapp.Text = "Sök";
            this.SökDatumKnapp.UseVisualStyleBackColor = true;
            this.SökDatumKnapp.Click += new System.EventHandler(this.SökDatumKnapp_Click);
            // 
            // BokningsDatumVäljare
            // 
            this.BokningsDatumVäljare.Location = new System.Drawing.Point(42, 77);
            this.BokningsDatumVäljare.Name = "BokningsDatumVäljare";
            this.BokningsDatumVäljare.Size = new System.Drawing.Size(162, 20);
            this.BokningsDatumVäljare.TabIndex = 6;
            this.BokningsDatumVäljare.ValueChanged += new System.EventHandler(this.BokningsDatumVäljare_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Böcker bokas i 14 dagar och du debiteras 10 kr per försenad dag";
            // 
            // MedlemComboBox
            // 
            this.MedlemComboBox.FormattingEnabled = true;
            this.MedlemComboBox.Location = new System.Drawing.Point(640, 81);
            this.MedlemComboBox.Name = "MedlemComboBox";
            this.MedlemComboBox.Size = new System.Drawing.Size(121, 21);
            this.MedlemComboBox.TabIndex = 8;
            this.MedlemComboBox.SelectedIndexChanged += new System.EventHandler(this.MedlemComboBox_SelectedIndexChanged);
            // 
            // SkapaBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MedlemComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BokningsDatumVäljare);
            this.Controls.Add(this.SökDatumKnapp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LedigaBöckerListBox);
            this.Controls.Add(this.label1);
            this.Name = "SkapaBokning";
            this.Text = "Skapa bokning";
            this.Load += new System.EventHandler(this.SkapaBokning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LedigaBöckerListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SökDatumKnapp;
        private System.Windows.Forms.DateTimePicker BokningsDatumVäljare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MedlemComboBox;
    }
}