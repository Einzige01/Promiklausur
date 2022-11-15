namespace PromiKlausur
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.tbAnrufer = new System.Windows.Forms.TextBox();
            this.pbFortschrittsbalken = new System.Windows.Forms.ProgressBar();
            this.lbSpender = new System.Windows.Forms.ListBox();
            this.nudBetrag = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudBetrag)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(54, 164);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(121, 22);
            this.btnSpeichern.TabIndex = 2;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // tbAnrufer
            // 
            this.tbAnrufer.Location = new System.Drawing.Point(54, 48);
            this.tbAnrufer.Name = "tbAnrufer";
            this.tbAnrufer.Size = new System.Drawing.Size(116, 20);
            this.tbAnrufer.TabIndex = 4;
            // 
            // pbFortschrittsbalken
            // 
            this.pbFortschrittsbalken.Location = new System.Drawing.Point(54, 330);
            this.pbFortschrittsbalken.Maximum = 2000;
            this.pbFortschrittsbalken.Name = "pbFortschrittsbalken";
            this.pbFortschrittsbalken.Size = new System.Drawing.Size(694, 31);
            this.pbFortschrittsbalken.TabIndex = 5;
            // 
            // lbSpender
            // 
            this.lbSpender.FormattingEnabled = true;
            this.lbSpender.Location = new System.Drawing.Point(568, 48);
            this.lbSpender.Name = "lbSpender";
            this.lbSpender.Size = new System.Drawing.Size(180, 225);
            this.lbSpender.TabIndex = 7;
            // 
            // nudBetrag
            // 
            this.nudBetrag.DecimalPlaces = 2;
            this.nudBetrag.Location = new System.Drawing.Point(54, 106);
            this.nudBetrag.Name = "nudBetrag";
            this.nudBetrag.Size = new System.Drawing.Size(143, 20);
            this.nudBetrag.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Anrufer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Spendenbetrag";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudBetrag);
            this.Controls.Add(this.lbSpender);
            this.Controls.Add(this.pbFortschrittsbalken);
            this.Controls.Add(this.tbAnrufer);
            this.Controls.Add(this.btnSpeichern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBetrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.TextBox tbAnrufer;
        private System.Windows.Forms.ProgressBar pbFortschrittsbalken;
        private System.Windows.Forms.ListBox lbSpender;
        private System.Windows.Forms.NumericUpDown nudBetrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

