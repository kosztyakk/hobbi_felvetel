namespace Hobbi_felvetel
{
    partial class Form1
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
            this.hozzad_button = new System.Windows.Forms.Button();
            this.megnyitas_button = new System.Windows.Forms.Button();
            this.mentes_button = new System.Windows.Forms.Button();
            this.FERFI_radioButton = new System.Windows.Forms.RadioButton();
            this.NO_radioButton = new System.Windows.Forms.RadioButton();
            this.nev_label = new System.Windows.Forms.Label();
            this.szuletes_label = new System.Windows.Forms.Label();
            this.nev_textBox = new System.Windows.Forms.TextBox();
            this.hobbi_listBox = new System.Windows.Forms.ListBox();
            this.hobbi_label = new System.Windows.Forms.Label();
            this.ujhobbi_textbox = new System.Windows.Forms.TextBox();
            this.ujhobbi_label = new System.Windows.Forms.Label();
            this.nem_groupbox = new System.Windows.Forms.GroupBox();
            this.szuletes_picker = new System.Windows.Forms.DateTimePicker();
            this.nem_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hozzad_button
            // 
            this.hozzad_button.Location = new System.Drawing.Point(397, 154);
            this.hozzad_button.Name = "hozzad_button";
            this.hozzad_button.Size = new System.Drawing.Size(75, 23);
            this.hozzad_button.TabIndex = 0;
            this.hozzad_button.Text = "Hozzáad";
            this.hozzad_button.UseVisualStyleBackColor = true;
            this.hozzad_button.Click += new System.EventHandler(this.hozzad_button_Click);
            // 
            // megnyitas_button
            // 
            this.megnyitas_button.Location = new System.Drawing.Point(397, 214);
            this.megnyitas_button.Name = "megnyitas_button";
            this.megnyitas_button.Size = new System.Drawing.Size(75, 23);
            this.megnyitas_button.TabIndex = 1;
            this.megnyitas_button.Text = "Megnyitás";
            this.megnyitas_button.UseVisualStyleBackColor = true;
            this.megnyitas_button.Click += new System.EventHandler(this.megnyitas_button_Click);
            // 
            // mentes_button
            // 
            this.mentes_button.Location = new System.Drawing.Point(279, 214);
            this.mentes_button.Name = "mentes_button";
            this.mentes_button.Size = new System.Drawing.Size(75, 23);
            this.mentes_button.TabIndex = 2;
            this.mentes_button.Text = "Mentés";
            this.mentes_button.UseVisualStyleBackColor = true;
            this.mentes_button.Click += new System.EventHandler(this.mentes_button_Click);
            // 
            // FERFI_radioButton
            // 
            this.FERFI_radioButton.AutoSize = true;
            this.FERFI_radioButton.Location = new System.Drawing.Point(53, 19);
            this.FERFI_radioButton.Name = "FERFI_radioButton";
            this.FERFI_radioButton.Size = new System.Drawing.Size(45, 17);
            this.FERFI_radioButton.TabIndex = 3;
            this.FERFI_radioButton.TabStop = true;
            this.FERFI_radioButton.Text = "Férfi";
            this.FERFI_radioButton.UseVisualStyleBackColor = true;
            // 
            // NO_radioButton
            // 
            this.NO_radioButton.AutoSize = true;
            this.NO_radioButton.Location = new System.Drawing.Point(8, 19);
            this.NO_radioButton.Name = "NO_radioButton";
            this.NO_radioButton.Size = new System.Drawing.Size(39, 17);
            this.NO_radioButton.TabIndex = 4;
            this.NO_radioButton.TabStop = true;
            this.NO_radioButton.Text = "Nő";
            this.NO_radioButton.UseVisualStyleBackColor = true;
            // 
            // nev_label
            // 
            this.nev_label.AutoSize = true;
            this.nev_label.Location = new System.Drawing.Point(32, 31);
            this.nev_label.Name = "nev_label";
            this.nev_label.Size = new System.Drawing.Size(30, 13);
            this.nev_label.TabIndex = 5;
            this.nev_label.Text = "Név:";
            // 
            // szuletes_label
            // 
            this.szuletes_label.AutoSize = true;
            this.szuletes_label.Location = new System.Drawing.Point(17, 57);
            this.szuletes_label.Name = "szuletes_label";
            this.szuletes_label.Size = new System.Drawing.Size(50, 13);
            this.szuletes_label.TabIndex = 6;
            this.szuletes_label.Text = "Születés:";
            // 
            // nev_textBox
            // 
            this.nev_textBox.Location = new System.Drawing.Point(73, 28);
            this.nev_textBox.Name = "nev_textBox";
            this.nev_textBox.Size = new System.Drawing.Size(100, 20);
            this.nev_textBox.TabIndex = 8;
            // 
            // hobbi_listBox
            // 
            this.hobbi_listBox.FormattingEnabled = true;
            this.hobbi_listBox.Items.AddRange(new object[] {
            "Suli",
            "Alvás",
            "Evés"});
            this.hobbi_listBox.Location = new System.Drawing.Point(279, 25);
            this.hobbi_listBox.Name = "hobbi_listBox";
            this.hobbi_listBox.Size = new System.Drawing.Size(184, 108);
            this.hobbi_listBox.TabIndex = 11;
            this.hobbi_listBox.SelectedIndexChanged += new System.EventHandler(this.hobbi_listBox_SelectedIndexChanged);
            // 
            // hobbi_label
            // 
            this.hobbi_label.AutoSize = true;
            this.hobbi_label.Location = new System.Drawing.Point(276, 9);
            this.hobbi_label.Name = "hobbi_label";
            this.hobbi_label.Size = new System.Drawing.Size(82, 13);
            this.hobbi_label.TabIndex = 12;
            this.hobbi_label.Text = "Kedvenc hobbi:";
            // 
            // ujhobbi_textbox
            // 
            this.ujhobbi_textbox.Location = new System.Drawing.Point(279, 156);
            this.ujhobbi_textbox.Name = "ujhobbi_textbox";
            this.ujhobbi_textbox.Size = new System.Drawing.Size(112, 20);
            this.ujhobbi_textbox.TabIndex = 13;
            // 
            // ujhobbi_label
            // 
            this.ujhobbi_label.AutoSize = true;
            this.ujhobbi_label.Location = new System.Drawing.Point(224, 159);
            this.ujhobbi_label.Name = "ujhobbi_label";
            this.ujhobbi_label.Size = new System.Drawing.Size(49, 13);
            this.ujhobbi_label.TabIndex = 14;
            this.ujhobbi_label.Text = "Új hobbi:";
            // 
            // nem_groupbox
            // 
            this.nem_groupbox.Controls.Add(this.NO_radioButton);
            this.nem_groupbox.Controls.Add(this.FERFI_radioButton);
            this.nem_groupbox.Location = new System.Drawing.Point(20, 80);
            this.nem_groupbox.Name = "nem_groupbox";
            this.nem_groupbox.Size = new System.Drawing.Size(200, 100);
            this.nem_groupbox.TabIndex = 15;
            this.nem_groupbox.TabStop = false;
            // 
            // szuletes_picker
            // 
            this.szuletes_picker.Location = new System.Drawing.Point(73, 57);
            this.szuletes_picker.Name = "szuletes_picker";
            this.szuletes_picker.Size = new System.Drawing.Size(200, 20);
            this.szuletes_picker.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 277);
            this.Controls.Add(this.szuletes_picker);
            this.Controls.Add(this.nem_groupbox);
            this.Controls.Add(this.ujhobbi_label);
            this.Controls.Add(this.ujhobbi_textbox);
            this.Controls.Add(this.hobbi_label);
            this.Controls.Add(this.hobbi_listBox);
            this.Controls.Add(this.nev_textBox);
            this.Controls.Add(this.szuletes_label);
            this.Controls.Add(this.nev_label);
            this.Controls.Add(this.mentes_button);
            this.Controls.Add(this.megnyitas_button);
            this.Controls.Add(this.hozzad_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.nem_groupbox.ResumeLayout(false);
            this.nem_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hozzad_button;
        private System.Windows.Forms.Button megnyitas_button;
        private System.Windows.Forms.Button mentes_button;
        private System.Windows.Forms.RadioButton FERFI_radioButton;
        private System.Windows.Forms.RadioButton NO_radioButton;
        private System.Windows.Forms.Label nev_label;
        private System.Windows.Forms.Label szuletes_label;
        private System.Windows.Forms.TextBox nev_textBox;
        private System.Windows.Forms.ListBox hobbi_listBox;
        private System.Windows.Forms.Label hobbi_label;
        private System.Windows.Forms.TextBox ujhobbi_textbox;
        private System.Windows.Forms.Label ujhobbi_label;
        private System.Windows.Forms.GroupBox nem_groupbox;
        private System.Windows.Forms.DateTimePicker szuletes_picker;
    }
}

