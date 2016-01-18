namespace A_TEAM
{
    partial class FDodavanje_Radnika
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbIme = new System.Windows.Forms.TextBox();
            this.TbPrezime = new System.Windows.Forms.TextBox();
            this.TbAdresa = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.CbProgrammingLanguages = new System.Windows.Forms.ComboBox();
            this.LvPJ_Z = new System.Windows.Forms.ListView();
            this.ColumnPJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnZnanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CbZnanjePJ = new System.Windows.Forms.ComboBox();
            this.BtnSubmitPJ = new System.Windows.Forms.Button();
            this.BtnDeletePJFromList = new System.Windows.Forms.Button();
            this.BtnSubmitData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TbObrazovanje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godina rodjenja:";
            // 
            // TbIme
            // 
            this.TbIme.Location = new System.Drawing.Point(152, 42);
            this.TbIme.Name = "TbIme";
            this.TbIme.Size = new System.Drawing.Size(163, 20);
            this.TbIme.TabIndex = 4;
            // 
            // TbPrezime
            // 
            this.TbPrezime.Location = new System.Drawing.Point(152, 77);
            this.TbPrezime.Name = "TbPrezime";
            this.TbPrezime.Size = new System.Drawing.Size(163, 20);
            this.TbPrezime.TabIndex = 5;
            // 
            // TbAdresa
            // 
            this.TbAdresa.Location = new System.Drawing.Point(152, 114);
            this.TbAdresa.Name = "TbAdresa";
            this.TbAdresa.Size = new System.Drawing.Size(163, 20);
            this.TbAdresa.TabIndex = 6;
            // 
            // DatePicker
            // 
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(152, 153);
            this.DatePicker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(102, 24);
            this.DatePicker.TabIndex = 7;
            // 
            // CbProgrammingLanguages
            // 
            this.CbProgrammingLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProgrammingLanguages.FormattingEnabled = true;
            this.CbProgrammingLanguages.Items.AddRange(new object[] {
            "C",
            "C#",
            "C++",
            "Java",
            "JavaScript",
            "PHP"});
            this.CbProgrammingLanguages.Location = new System.Drawing.Point(412, 30);
            this.CbProgrammingLanguages.Name = "CbProgrammingLanguages";
            this.CbProgrammingLanguages.Size = new System.Drawing.Size(143, 24);
            this.CbProgrammingLanguages.Sorted = true;
            this.CbProgrammingLanguages.TabIndex = 8;
            this.CbProgrammingLanguages.Text = "Programski jezik";
            // 
            // LvPJ_Z
            // 
            this.LvPJ_Z.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnPJ,
            this.ColumnZnanje});
            this.LvPJ_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvPJ_Z.FullRowSelect = true;
            this.LvPJ_Z.GridLines = true;
            this.LvPJ_Z.Location = new System.Drawing.Point(412, 153);
            this.LvPJ_Z.MultiSelect = false;
            this.LvPJ_Z.Name = "LvPJ_Z";
            this.LvPJ_Z.Size = new System.Drawing.Size(239, 175);
            this.LvPJ_Z.TabIndex = 9;
            this.LvPJ_Z.UseCompatibleStateImageBehavior = false;
            this.LvPJ_Z.View = System.Windows.Forms.View.Details;
            // 
            // ColumnPJ
            // 
            this.ColumnPJ.Text = "Programski jezik";
            this.ColumnPJ.Width = 112;
            // 
            // ColumnZnanje
            // 
            this.ColumnZnanje.Text = "Znanje [1-10]";
            this.ColumnZnanje.Width = 122;
            // 
            // CbZnanjePJ
            // 
            this.CbZnanjePJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbZnanjePJ.FormattingEnabled = true;
            this.CbZnanjePJ.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CbZnanjePJ.Location = new System.Drawing.Point(581, 30);
            this.CbZnanjePJ.Name = "CbZnanjePJ";
            this.CbZnanjePJ.Size = new System.Drawing.Size(70, 24);
            this.CbZnanjePJ.TabIndex = 10;
            this.CbZnanjePJ.Text = "Znanje";
            // 
            // BtnSubmitPJ
            // 
            this.BtnSubmitPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitPJ.Location = new System.Drawing.Point(412, 67);
            this.BtnSubmitPJ.Name = "BtnSubmitPJ";
            this.BtnSubmitPJ.Size = new System.Drawing.Size(239, 30);
            this.BtnSubmitPJ.TabIndex = 11;
            this.BtnSubmitPJ.Text = "Dodaj programski jezik";
            this.BtnSubmitPJ.UseVisualStyleBackColor = true;
            this.BtnSubmitPJ.Click += new System.EventHandler(this.BtnSubmitPJ_Click);
            // 
            // BtnDeletePJFromList
            // 
            this.BtnDeletePJFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletePJFromList.Location = new System.Drawing.Point(412, 107);
            this.BtnDeletePJFromList.Name = "BtnDeletePJFromList";
            this.BtnDeletePJFromList.Size = new System.Drawing.Size(239, 32);
            this.BtnDeletePJFromList.TabIndex = 12;
            this.BtnDeletePJFromList.Text = "Izbrisi jezik iz liste";
            this.BtnDeletePJFromList.UseVisualStyleBackColor = true;
            this.BtnDeletePJFromList.Click += new System.EventHandler(this.BtnDeletePJFromList_Click);
            // 
            // BtnSubmitData
            // 
            this.BtnSubmitData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitData.Location = new System.Drawing.Point(26, 381);
            this.BtnSubmitData.Name = "BtnSubmitData";
            this.BtnSubmitData.Size = new System.Drawing.Size(625, 23);
            this.BtnSubmitData.TabIndex = 13;
            this.BtnSubmitData.Text = "Dodaj";
            this.BtnSubmitData.UseVisualStyleBackColor = true;
            this.BtnSubmitData.Click += new System.EventHandler(this.BtnSubmitData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Obrazovanje:";
            // 
            // TbObrazovanje
            // 
            this.TbObrazovanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbObrazovanje.Location = new System.Drawing.Point(36, 240);
            this.TbObrazovanje.Multiline = true;
            this.TbObrazovanje.Name = "TbObrazovanje";
            this.TbObrazovanje.Size = new System.Drawing.Size(279, 88);
            this.TbObrazovanje.TabIndex = 15;
            // 
            // Adding_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 416);
            this.Controls.Add(this.TbObrazovanje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSubmitData);
            this.Controls.Add(this.BtnDeletePJFromList);
            this.Controls.Add(this.BtnSubmitPJ);
            this.Controls.Add(this.CbZnanjePJ);
            this.Controls.Add(this.LvPJ_Z);
            this.Controls.Add(this.CbProgrammingLanguages);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.TbAdresa);
            this.Controls.Add(this.TbPrezime);
            this.Controls.Add(this.TbIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Adding_Person";
            this.Text = "Adding_Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbIme;
        private System.Windows.Forms.TextBox TbPrezime;
        private System.Windows.Forms.TextBox TbAdresa;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ComboBox CbProgrammingLanguages;
        private System.Windows.Forms.ListView LvPJ_Z;
        private System.Windows.Forms.ColumnHeader ColumnPJ;
        private System.Windows.Forms.ColumnHeader ColumnZnanje;
        private System.Windows.Forms.ComboBox CbZnanjePJ;
        private System.Windows.Forms.Button BtnSubmitPJ;
        private System.Windows.Forms.Button BtnDeletePJFromList;
        private System.Windows.Forms.Button BtnSubmitData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbObrazovanje;
    }
}