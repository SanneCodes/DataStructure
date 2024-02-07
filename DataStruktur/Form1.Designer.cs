namespace DataStruktur
{
    partial class frmArray
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtLeggTil = new System.Windows.Forms.TextBox();
            this.btnLeggTil = new System.Windows.Forms.Button();
            this.btnSlettSiste = new System.Windows.Forms.Button();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.txtArrayDisplay = new System.Windows.Forms.TextBox();
            this.btnNrLeggTil = new System.Windows.Forms.Button();
            this.txtTextLeggTil = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtNrLeggTil = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSlett = new System.Windows.Forms.Button();
            this.txtSlett = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(237, 68);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(190, 19);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Legg til noe nederst i array";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(275, 253);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(120, 19);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Slett siste index:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(66, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 19);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Min Array:";
            // 
            // txtLeggTil
            // 
            this.txtLeggTil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeggTil.Location = new System.Drawing.Point(279, 108);
            this.txtLeggTil.Name = "txtLeggTil";
            this.txtLeggTil.Size = new System.Drawing.Size(100, 26);
            this.txtLeggTil.TabIndex = 4;
            // 
            // btnLeggTil
            // 
            this.btnLeggTil.BackColor = System.Drawing.SystemColors.Control;
            this.btnLeggTil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggTil.Location = new System.Drawing.Point(291, 154);
            this.btnLeggTil.Name = "btnLeggTil";
            this.btnLeggTil.Size = new System.Drawing.Size(77, 27);
            this.btnLeggTil.TabIndex = 6;
            this.btnLeggTil.Text = "Legg til";
            this.btnLeggTil.UseVisualStyleBackColor = false;
            this.btnLeggTil.Click += new System.EventHandler(this.btnLeggTil_Click);
            // 
            // btnSlettSiste
            // 
            this.btnSlettSiste.BackColor = System.Drawing.SystemColors.Control;
            this.btnSlettSiste.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlettSiste.Location = new System.Drawing.Point(289, 300);
            this.btnSlettSiste.Name = "btnSlettSiste";
            this.btnSlettSiste.Size = new System.Drawing.Size(90, 27);
            this.btnSlettSiste.TabIndex = 8;
            this.btnSlettSiste.Text = "Slett siste";
            this.btnSlettSiste.UseVisualStyleBackColor = false;
            this.btnSlettSiste.Click += new System.EventHandler(this.btnSlettSiste_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAvslutt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvslutt.Location = new System.Drawing.Point(70, 411);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(77, 27);
            this.btnAvslutt.TabIndex = 9;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = false;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // txtArrayDisplay
            // 
            this.txtArrayDisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtArrayDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrayDisplay.Location = new System.Drawing.Point(16, 45);
            this.txtArrayDisplay.Multiline = true;
            this.txtArrayDisplay.Name = "txtArrayDisplay";
            this.txtArrayDisplay.ReadOnly = true;
            this.txtArrayDisplay.Size = new System.Drawing.Size(197, 359);
            this.txtArrayDisplay.TabIndex = 10;
            // 
            // btnNrLeggTil
            // 
            this.btnNrLeggTil.BackColor = System.Drawing.SystemColors.Control;
            this.btnNrLeggTil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNrLeggTil.Location = new System.Drawing.Point(569, 175);
            this.btnNrLeggTil.Name = "btnNrLeggTil";
            this.btnNrLeggTil.Size = new System.Drawing.Size(77, 27);
            this.btnNrLeggTil.TabIndex = 13;
            this.btnNrLeggTil.Text = "Legg til";
            this.btnNrLeggTil.UseVisualStyleBackColor = false;
            this.btnNrLeggTil.Click += new System.EventHandler(this.btnNrLeggTil_Click);
            // 
            // txtTextLeggTil
            // 
            this.txtTextLeggTil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextLeggTil.Location = new System.Drawing.Point(507, 124);
            this.txtTextLeggTil.Name = "txtTextLeggTil";
            this.txtTextLeggTil.Size = new System.Drawing.Size(80, 26);
            this.txtTextLeggTil.TabIndex = 12;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(461, 68);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(317, 19);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "Legg til text og velg hvor i arrayen det legges:";
            // 
            // txtNrLeggTil
            // 
            this.txtNrLeggTil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrLeggTil.Location = new System.Drawing.Point(642, 124);
            this.txtNrLeggTil.Name = "txtNrLeggTil";
            this.txtNrLeggTil.Size = new System.Drawing.Size(80, 26);
            this.txtNrLeggTil.TabIndex = 14;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(499, 104);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(96, 17);
            this.lbl6.TabIndex = 15;
            this.lbl6.Text = "Skriv inn text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Skriv inn nummer:";
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBack.CausesValidation = false;
            this.lblBack.Location = new System.Drawing.Point(234, 45);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(197, 173);
            this.lblBack.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(234, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 173);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(451, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 173);
            this.label3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(451, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 173);
            this.label4.TabIndex = 20;
            // 
            // btnSlett
            // 
            this.btnSlett.BackColor = System.Drawing.SystemColors.Control;
            this.btnSlett.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlett.Location = new System.Drawing.Point(569, 330);
            this.btnSlett.Name = "btnSlett";
            this.btnSlett.Size = new System.Drawing.Size(77, 27);
            this.btnSlett.TabIndex = 23;
            this.btnSlett.Text = "Slett";
            this.btnSlett.UseVisualStyleBackColor = false;
            this.btnSlett.Click += new System.EventHandler(this.btnSlett_Click);
            // 
            // txtSlett
            // 
            this.txtSlett.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlett.Location = new System.Drawing.Point(560, 289);
            this.txtSlett.Name = "txtSlett";
            this.txtSlett.Size = new System.Drawing.Size(100, 26);
            this.txtSlett.TabIndex = 22;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(469, 253);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(302, 19);
            this.lbl4.TabIndex = 21;
            this.lbl4.Text = "Skriv inn hvilket nr i listen som du vil slette:";
            // 
            // frmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSlett);
            this.Controls.Add(this.txtSlett);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txtNrLeggTil);
            this.Controls.Add(this.btnNrLeggTil);
            this.Controls.Add(this.txtTextLeggTil);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtArrayDisplay);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnSlettSiste);
            this.Controls.Add(this.btnLeggTil);
            this.Controls.Add(this.txtLeggTil);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBack);
            this.Name = "frmArray";
            this.Text = "Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtLeggTil;
        private System.Windows.Forms.Button btnLeggTil;
        private System.Windows.Forms.Button btnSlettSiste;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.TextBox txtArrayDisplay;
        private System.Windows.Forms.Button btnNrLeggTil;
        private System.Windows.Forms.TextBox txtTextLeggTil;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtNrLeggTil;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSlett;
        private System.Windows.Forms.TextBox txtSlett;
        private System.Windows.Forms.Label lbl4;
    }
}

