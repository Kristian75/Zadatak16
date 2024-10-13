namespace Zadatak16
{
    partial class Unos_novog_studenta
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxBrojIndeksa = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSmjer = new System.Windows.Forms.ComboBox();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(48, 61);
            this.textBoxIme.Multiline = true;
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(169, 26);
            this.textBoxIme.TabIndex = 0;
            // 
            // textBoxBrojIndeksa
            // 
            this.textBoxBrojIndeksa.Location = new System.Drawing.Point(314, 61);
            this.textBoxBrojIndeksa.Multiline = true;
            this.textBoxBrojIndeksa.Name = "textBoxBrojIndeksa";
            this.textBoxBrojIndeksa.Size = new System.Drawing.Size(179, 26);
            this.textBoxBrojIndeksa.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(48, 145);
            this.textBoxPrezime.Multiline = true;
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(169, 26);
            this.textBoxPrezime.TabIndex = 2;
            // 
            // dateTimePickerDatumRodjenja
            // 
            this.dateTimePickerDatumRodjenja.Location = new System.Drawing.Point(314, 145);
            this.dateTimePickerDatumRodjenja.Name = "dateTimePickerDatumRodjenja";
            this.dateTimePickerDatumRodjenja.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerDatumRodjenja.TabIndex = 3;
            // 
            // comboBoxSmjer
            // 
            this.comboBoxSmjer.FormattingEnabled = true;
            this.comboBoxSmjer.Location = new System.Drawing.Point(48, 213);
            this.comboBoxSmjer.Name = "comboBoxSmjer";
            this.comboBoxSmjer.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSmjer.TabIndex = 4;
            this.comboBoxSmjer.SelectedIndexChanged += new System.EventHandler(this.comboBoxSmjer_SelectedIndexChanged);
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSnimi.Location = new System.Drawing.Point(48, 288);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(121, 29);
            this.buttonSnimi.TabIndex = 5;
            this.buttonSnimi.Text = "Snimi";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOtkazi.Location = new System.Drawing.Point(372, 288);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(121, 29);
            this.buttonOtkazi.TabIndex = 6;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(311, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Broj indeksa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(45, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(311, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum rodjenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(45, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Smjer:";
            // 
            // Unos_novog_studenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.comboBoxSmjer);
            this.Controls.Add(this.dateTimePickerDatumRodjenja);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxBrojIndeksa);
            this.Controls.Add(this.textBoxIme);
            this.Name = "Unos_novog_studenta";
            this.Text = "Unos novog studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxBrojIndeksa;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodjenja;
        private System.Windows.Forms.ComboBox comboBoxSmjer;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}