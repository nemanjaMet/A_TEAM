namespace A_TEAM
{
    partial class FNovi_Projekat
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
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.BtnKreirajRazvoj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIzbrisiRazvojIzListe = new System.Windows.Forms.Button();
            this.BtnDodajRazvojUListu = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnRazvoj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnBrojLjudi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CbBrojRadnika = new System.Windows.Forms.ComboBox();
            this.CbRazvoj = new System.Windows.Forms.ComboBox();
            this.BtnRemoveFromListView = new System.Windows.Forms.Button();
            this.BtnSubmitToListView = new System.Windows.Forms.Button();
            this.LvPJezikZnanje = new System.Windows.Forms.ListView();
            this.ColumnProgramskiJezik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnMinZnanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CbProgramskiJezik = new System.Windows.Forms.ComboBox();
            this.CbZnanje = new System.Windows.Forms.ComboBox();
            this.BtnSubmitDataPoject = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TbImeProjekta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIzbrisiRadnika = new System.Windows.Forms.Button();
            this.BtnIzbrisiRazvoj = new System.Windows.Forms.Button();
            this.BtnVeze = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPerson.Location = new System.Drawing.Point(31, 18);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(122, 30);
            this.BtnAddPerson.TabIndex = 0;
            this.BtnAddPerson.Text = "Novi radnik";
            this.BtnAddPerson.UseVisualStyleBackColor = true;
            this.BtnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // BtnKreirajRazvoj
            // 
            this.BtnKreirajRazvoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKreirajRazvoj.Location = new System.Drawing.Point(31, 106);
            this.BtnKreirajRazvoj.Name = "BtnKreirajRazvoj";
            this.BtnKreirajRazvoj.Size = new System.Drawing.Size(127, 28);
            this.BtnKreirajRazvoj.TabIndex = 1;
            this.BtnKreirajRazvoj.Text = "Kreiraj razvoj";
            this.BtnKreirajRazvoj.UseVisualStyleBackColor = true;
            this.BtnKreirajRazvoj.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnIzbrisiRazvojIzListe);
            this.panel1.Controls.Add(this.BtnDodajRazvojUListu);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.CbBrojRadnika);
            this.panel1.Controls.Add(this.CbRazvoj);
            this.panel1.Controls.Add(this.BtnRemoveFromListView);
            this.panel1.Controls.Add(this.BtnSubmitToListView);
            this.panel1.Controls.Add(this.LvPJezikZnanje);
            this.panel1.Controls.Add(this.CbProgramskiJezik);
            this.panel1.Controls.Add(this.CbZnanje);
            this.panel1.Controls.Add(this.BtnSubmitDataPoject);
            this.panel1.Controls.Add(this.DatePicker);
            this.panel1.Controls.Add(this.TbImeProjekta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 389);
            this.panel1.TabIndex = 2;
            // 
            // BtnIzbrisiRazvojIzListe
            // 
            this.BtnIzbrisiRazvojIzListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiRazvojIzListe.Location = new System.Drawing.Point(26, 168);
            this.BtnIzbrisiRazvojIzListe.Name = "BtnIzbrisiRazvojIzListe";
            this.BtnIzbrisiRazvojIzListe.Size = new System.Drawing.Size(264, 27);
            this.BtnIzbrisiRazvojIzListe.TabIndex = 15;
            this.BtnIzbrisiRazvojIzListe.Text = "Izbrisi selektovani razvoj";
            this.BtnIzbrisiRazvojIzListe.UseVisualStyleBackColor = true;
            // 
            // BtnDodajRazvojUListu
            // 
            this.BtnDodajRazvojUListu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodajRazvojUListu.Location = new System.Drawing.Point(26, 133);
            this.BtnDodajRazvojUListu.Name = "BtnDodajRazvojUListu";
            this.BtnDodajRazvojUListu.Size = new System.Drawing.Size(264, 29);
            this.BtnDodajRazvojUListu.TabIndex = 14;
            this.BtnDodajRazvojUListu.Text = "Dodaj razvoj i broj ljudi";
            this.BtnDodajRazvojUListu.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnRazvoj,
            this.ColumnBrojLjudi});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(26, 201);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(264, 92);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnRazvoj
            // 
            this.ColumnRazvoj.Text = "Razvoj";
            this.ColumnRazvoj.Width = 162;
            // 
            // ColumnBrojLjudi
            // 
            this.ColumnBrojLjudi.Text = "Broj ljudi";
            this.ColumnBrojLjudi.Width = 75;
            // 
            // CbBrojRadnika
            // 
            this.CbBrojRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBrojRadnika.FormattingEnabled = true;
            this.CbBrojRadnika.Location = new System.Drawing.Point(169, 106);
            this.CbBrojRadnika.Name = "CbBrojRadnika";
            this.CbBrojRadnika.Size = new System.Drawing.Size(121, 24);
            this.CbBrojRadnika.TabIndex = 12;
            this.CbBrojRadnika.Text = "Broj radnika";
            // 
            // CbRazvoj
            // 
            this.CbRazvoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRazvoj.FormattingEnabled = true;
            this.CbRazvoj.Location = new System.Drawing.Point(26, 106);
            this.CbRazvoj.Name = "CbRazvoj";
            this.CbRazvoj.Size = new System.Drawing.Size(121, 24);
            this.CbRazvoj.TabIndex = 11;
            this.CbRazvoj.Text = "Izaberi razvoj";
            // 
            // BtnRemoveFromListView
            // 
            this.BtnRemoveFromListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveFromListView.Location = new System.Drawing.Point(393, 90);
            this.BtnRemoveFromListView.Name = "BtnRemoveFromListView";
            this.BtnRemoveFromListView.Size = new System.Drawing.Size(198, 23);
            this.BtnRemoveFromListView.TabIndex = 10;
            this.BtnRemoveFromListView.Text = "Izbrisi iz osobu iz liste";
            this.BtnRemoveFromListView.UseVisualStyleBackColor = true;
            this.BtnRemoveFromListView.Click += new System.EventHandler(this.BtnRemoveFromListView_Click);
            // 
            // BtnSubmitToListView
            // 
            this.BtnSubmitToListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitToListView.Location = new System.Drawing.Point(393, 60);
            this.BtnSubmitToListView.Name = "BtnSubmitToListView";
            this.BtnSubmitToListView.Size = new System.Drawing.Size(198, 23);
            this.BtnSubmitToListView.TabIndex = 9;
            this.BtnSubmitToListView.Text = "Dodaj trazenu osobu";
            this.BtnSubmitToListView.UseVisualStyleBackColor = true;
            this.BtnSubmitToListView.Click += new System.EventHandler(this.BtnSubmitToListView_Click);
            // 
            // LvPJezikZnanje
            // 
            this.LvPJezikZnanje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnProgramskiJezik,
            this.ColumnMinZnanje});
            this.LvPJezikZnanje.FullRowSelect = true;
            this.LvPJezikZnanje.GridLines = true;
            this.LvPJezikZnanje.Location = new System.Drawing.Point(393, 130);
            this.LvPJezikZnanje.MultiSelect = false;
            this.LvPJezikZnanje.Name = "LvPJezikZnanje";
            this.LvPJezikZnanje.Size = new System.Drawing.Size(198, 146);
            this.LvPJezikZnanje.TabIndex = 8;
            this.LvPJezikZnanje.UseCompatibleStateImageBehavior = false;
            this.LvPJezikZnanje.View = System.Windows.Forms.View.Details;
            // 
            // ColumnProgramskiJezik
            // 
            this.ColumnProgramskiJezik.Text = "Programski jezik";
            this.ColumnProgramskiJezik.Width = 94;
            // 
            // ColumnMinZnanje
            // 
            this.ColumnMinZnanje.Text = "Minimalno znanje";
            this.ColumnMinZnanje.Width = 93;
            // 
            // CbProgramskiJezik
            // 
            this.CbProgramskiJezik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProgramskiJezik.FormattingEnabled = true;
            this.CbProgramskiJezik.Items.AddRange(new object[] {
            "C",
            "C#",
            "C++",
            "Java",
            "JavaScript",
            "PHP"});
            this.CbProgramskiJezik.Location = new System.Drawing.Point(393, 32);
            this.CbProgramskiJezik.Name = "CbProgramskiJezik";
            this.CbProgramskiJezik.Size = new System.Drawing.Size(121, 24);
            this.CbProgramskiJezik.TabIndex = 7;
            this.CbProgramskiJezik.Text = "Programski jezik";
            // 
            // CbZnanje
            // 
            this.CbZnanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbZnanje.FormattingEnabled = true;
            this.CbZnanje.Items.AddRange(new object[] {
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
            this.CbZnanje.Location = new System.Drawing.Point(520, 31);
            this.CbZnanje.Name = "CbZnanje";
            this.CbZnanje.Size = new System.Drawing.Size(71, 24);
            this.CbZnanje.TabIndex = 6;
            this.CbZnanje.Text = "Znanje";
            // 
            // BtnSubmitDataPoject
            // 
            this.BtnSubmitDataPoject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitDataPoject.Location = new System.Drawing.Point(242, 351);
            this.BtnSubmitDataPoject.Name = "BtnSubmitDataPoject";
            this.BtnSubmitDataPoject.Size = new System.Drawing.Size(135, 31);
            this.BtnSubmitDataPoject.TabIndex = 5;
            this.BtnSubmitDataPoject.Text = "Kreiraj novi projekat";
            this.BtnSubmitDataPoject.UseVisualStyleBackColor = true;
            this.BtnSubmitDataPoject.Click += new System.EventHandler(this.BtnSubmitDataPoject_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(129, 71);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(100, 22);
            this.DatePicker.TabIndex = 4;
            // 
            // TbImeProjekta
            // 
            this.TbImeProjekta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbImeProjekta.Location = new System.Drawing.Point(129, 34);
            this.TbImeProjekta.Name = "TbImeProjekta";
            this.TbImeProjekta.Size = new System.Drawing.Size(194, 22);
            this.TbImeProjekta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok zavrsetka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime projekta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kreiranje novog projekta";
            // 
            // BtnIzbrisiRadnika
            // 
            this.BtnIzbrisiRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiRadnika.Location = new System.Drawing.Point(31, 54);
            this.BtnIzbrisiRadnika.Name = "BtnIzbrisiRadnika";
            this.BtnIzbrisiRadnika.Size = new System.Drawing.Size(122, 29);
            this.BtnIzbrisiRadnika.TabIndex = 3;
            this.BtnIzbrisiRadnika.Text = "Izbrisi radnika";
            this.BtnIzbrisiRadnika.UseVisualStyleBackColor = true;
            this.BtnIzbrisiRadnika.Click += new System.EventHandler(this.BtnIzbrisiRadnika_Click);
            // 
            // BtnIzbrisiRazvoj
            // 
            this.BtnIzbrisiRazvoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiRazvoj.Location = new System.Drawing.Point(31, 140);
            this.BtnIzbrisiRazvoj.Name = "BtnIzbrisiRazvoj";
            this.BtnIzbrisiRazvoj.Size = new System.Drawing.Size(127, 32);
            this.BtnIzbrisiRazvoj.TabIndex = 4;
            this.BtnIzbrisiRazvoj.Text = "Izbrisi razvoj";
            this.BtnIzbrisiRazvoj.UseVisualStyleBackColor = true;
            this.BtnIzbrisiRazvoj.Click += new System.EventHandler(this.BtnIzbrisiRazvoj_Click);
            // 
            // BtnVeze
            // 
            this.BtnVeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVeze.Location = new System.Drawing.Point(31, 199);
            this.BtnVeze.Name = "BtnVeze";
            this.BtnVeze.Size = new System.Drawing.Size(127, 44);
            this.BtnVeze.TabIndex = 5;
            this.BtnVeze.Text = "Kreiraj veze izmedju radnila";
            this.BtnVeze.UseVisualStyleBackColor = true;
            this.BtnVeze.Click += new System.EventHandler(this.BtnVeze_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtnAddPerson);
            this.panel2.Controls.Add(this.BtnVeze);
            this.panel2.Controls.Add(this.BtnIzbrisiRadnika);
            this.panel2.Controls.Add(this.BtnIzbrisiRazvoj);
            this.panel2.Controls.Add(this.BtnKreirajRazvoj);
            this.panel2.Location = new System.Drawing.Point(653, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 387);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "SAMO ZA DARKA";
            // 
            // FNovi_Projekat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FNovi_Projekat";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddPerson;
        private System.Windows.Forms.Button BtnKreirajRazvoj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSubmitDataPoject;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox TbImeProjekta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LvPJezikZnanje;
        private System.Windows.Forms.ComboBox CbProgramskiJezik;
        private System.Windows.Forms.ComboBox CbZnanje;
        private System.Windows.Forms.Button BtnRemoveFromListView;
        private System.Windows.Forms.Button BtnSubmitToListView;
        private System.Windows.Forms.ColumnHeader ColumnProgramskiJezik;
        private System.Windows.Forms.ColumnHeader ColumnMinZnanje;
        private System.Windows.Forms.Button BtnIzbrisiRazvojIzListe;
        private System.Windows.Forms.Button BtnDodajRazvojUListu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox CbBrojRadnika;
        private System.Windows.Forms.ComboBox CbRazvoj;
        private System.Windows.Forms.ColumnHeader ColumnRazvoj;
        private System.Windows.Forms.ColumnHeader ColumnBrojLjudi;
        private System.Windows.Forms.Button BtnIzbrisiRadnika;
        private System.Windows.Forms.Button BtnIzbrisiRazvoj;
        private System.Windows.Forms.Button BtnVeze;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

