namespace Presentationslager
{
    partial class Meny
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
            this.TillbakaKnapp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SkapaBokningKnapp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TillbakaKnapp
            // 
            this.TillbakaKnapp.Location = new System.Drawing.Point(12, 404);
            this.TillbakaKnapp.Name = "TillbakaKnapp";
            this.TillbakaKnapp.Size = new System.Drawing.Size(135, 34);
            this.TillbakaKnapp.TabIndex = 0;
            this.TillbakaKnapp.Text = "< Tillbaka";
            this.TillbakaKnapp.UseVisualStyleBackColor = true;
            this.TillbakaKnapp.Click += new System.EventHandler(this.TillbakaKnapp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bibblos 2.0";
            // 
            // SkapaBokningKnapp
            // 
            this.SkapaBokningKnapp.BackColor = System.Drawing.Color.Plum;
            this.SkapaBokningKnapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkapaBokningKnapp.Location = new System.Drawing.Point(125, 150);
            this.SkapaBokningKnapp.Name = "SkapaBokningKnapp";
            this.SkapaBokningKnapp.Size = new System.Drawing.Size(168, 128);
            this.SkapaBokningKnapp.TabIndex = 2;
            this.SkapaBokningKnapp.Text = "Skapa bokning";
            this.SkapaBokningKnapp.UseVisualStyleBackColor = false;
            this.SkapaBokningKnapp.Click += new System.EventHandler(this.SkapaBokningKnapp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(503, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 128);
            this.button1.TabIndex = 3;
            this.button1.Text = "Återlämning av bok";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SkapaBokningKnapp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TillbakaKnapp);
            this.Name = "Meny";
            this.Text = "Meny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TillbakaKnapp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SkapaBokningKnapp;
        private System.Windows.Forms.Button button1;
    }
}