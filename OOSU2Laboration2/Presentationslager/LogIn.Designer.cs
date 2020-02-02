namespace Presentationslager
{
    partial class LogIn
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
            this.anställningsnummerTextbox = new System.Windows.Forms.TextBox();
            this.lösenordTextbox = new System.Windows.Forms.TextBox();
            this.LoggaInKnapp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.felINLOG = new System.Windows.Forms.Label();
            this.labelLOGIN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anställningsnummerTextbox
            // 
            this.anställningsnummerTextbox.Location = new System.Drawing.Point(317, 166);
            this.anställningsnummerTextbox.Name = "anställningsnummerTextbox";
            this.anställningsnummerTextbox.Size = new System.Drawing.Size(100, 20);
            this.anställningsnummerTextbox.TabIndex = 0;
            this.anställningsnummerTextbox.TextChanged += new System.EventHandler(this.anställningsnummerTextbox_TextChanged);
            // 
            // lösenordTextbox
            // 
            this.lösenordTextbox.Location = new System.Drawing.Point(317, 202);
            this.lösenordTextbox.Name = "lösenordTextbox";
            this.lösenordTextbox.PasswordChar = '*';
            this.lösenordTextbox.Size = new System.Drawing.Size(100, 20);
            this.lösenordTextbox.TabIndex = 1;
            this.lösenordTextbox.TextChanged += new System.EventHandler(this.lösenordTextbox_TextChanged);
            // 
            // LoggaInKnapp
            // 
            this.LoggaInKnapp.Location = new System.Drawing.Point(317, 263);
            this.LoggaInKnapp.Name = "LoggaInKnapp";
            this.LoggaInKnapp.Size = new System.Drawing.Size(100, 23);
            this.LoggaInKnapp.TabIndex = 2;
            this.LoggaInKnapp.Text = "Logga in";
            this.LoggaInKnapp.UseVisualStyleBackColor = true;
            this.LoggaInKnapp.Click += new System.EventHandler(this.LoggaInKnapp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anställningsnummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lösenord:";
            // 
            // felINLOG
            // 
            this.felINLOG.AutoSize = true;
            this.felINLOG.ForeColor = System.Drawing.Color.Fuchsia;
            this.felINLOG.Location = new System.Drawing.Point(314, 238);
            this.felINLOG.Name = "felINLOG";
            this.felINLOG.Size = new System.Drawing.Size(0, 13);
            this.felINLOG.TabIndex = 5;
            // 
            // labelLOGIN
            // 
            this.labelLOGIN.AutoSize = true;
            this.labelLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLOGIN.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelLOGIN.Location = new System.Drawing.Point(193, 345);
            this.labelLOGIN.Name = "labelLOGIN";
            this.labelLOGIN.Size = new System.Drawing.Size(16, 24);
            this.labelLOGIN.TabIndex = 6;
            this.labelLOGIN.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Välkommen till bibblan!";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLOGIN);
            this.Controls.Add(this.felINLOG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoggaInKnapp);
            this.Controls.Add(this.lösenordTextbox);
            this.Controls.Add(this.anställningsnummerTextbox);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox anställningsnummerTextbox;
        private System.Windows.Forms.TextBox lösenordTextbox;
        private System.Windows.Forms.Button LoggaInKnapp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label felINLOG;
        private System.Windows.Forms.Label labelLOGIN;
        private System.Windows.Forms.Label label3;
    }
}

