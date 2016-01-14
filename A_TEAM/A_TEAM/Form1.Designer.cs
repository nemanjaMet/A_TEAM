namespace A_TEAM
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
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbImeProjekta = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnSubmitDataPoject = new System.Windows.Forms.Button();
            this.CbZnanje = new System.Windows.Forms.ComboBox();
            this.CbProgramskiJezik = new System.Windows.Forms.ComboBox();
            this.LvPJezikZnanje = new System.Windows.Forms.ListView();
            this.ColumnProgramskiJezik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnMinZnanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnSubmitToListView = new System.Windows.Forms.Button();
            this.BtnRemoveFromListView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPerson.Location = new System.Drawing.Point(51, 31);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(105, 23);
            this.BtnAddPerson.TabIndex = 0;
            this.BtnAddPerson.Text = "Add Person";
            this.BtnAddPerson.UseVisualStyleBackColor = true;
            this.BtnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(492, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Development";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.panel1.Location = new System.Drawing.Point(42, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 389);
            this.panel1.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime projekta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok zavrsetka:";
            // 
            // TbImeProjekta
            // 
            this.TbImeProjekta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbImeProjekta.Location = new System.Drawing.Point(136, 49);
            this.TbImeProjekta.Name = "TbImeProjekta";
            this.TbImeProjekta.Size = new System.Drawing.Size(194, 22);
            this.TbImeProjekta.TabIndex = 3;
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(136, 86);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(100, 22);
            this.DatePicker.TabIndex = 4;
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
            // 
            // CbZnanje
            // 
            this.CbZnanje.FormattingEnabled = true;
            this.CbZnanje.Location = new System.Drawing.Point(515, 44);
            this.CbZnanje.Name = "CbZnanje";
            this.CbZnanje.Size = new System.Drawing.Size(71, 21);
            this.CbZnanje.TabIndex = 6;
            this.CbZnanje.Text = "Znanje";
            // 
            // CbProgramskiJezik
            // 
            this.CbProgramskiJezik.FormattingEnabled = true;
            this.CbProgramskiJezik.Location = new System.Drawing.Point(388, 45);
            this.CbProgramskiJezik.Name = "CbProgramskiJezik";
            this.CbProgramskiJezik.Size = new System.Drawing.Size(121, 21);
            this.CbProgramskiJezik.TabIndex = 7;
            this.CbProgramskiJezik.Text = "Programski jezik";
            // 
            // LvPJezikZnanje
            // 
            this.LvPJezikZnanje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnProgramskiJezik,
            this.ColumnMinZnanje});
            this.LvPJezikZnanje.FullRowSelect = true;
            this.LvPJezikZnanje.GridLines = true;
            this.LvPJezikZnanje.Location = new System.Drawing.Point(388, 143);
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
            // BtnSubmitToListView
            // 
            this.BtnSubmitToListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitToListView.Location = new System.Drawing.Point(388, 73);
            this.BtnSubmitToListView.Name = "BtnSubmitToListView";
            this.BtnSubmitToListView.Size = new System.Drawing.Size(198, 23);
            this.BtnSubmitToListView.TabIndex = 9;
            this.BtnSubmitToListView.Text = "Dodaj trazenu osobu";
            this.BtnSubmitToListView.UseVisualStyleBackColor = true;
            this.BtnSubmitToListView.Click += new System.EventHandler(this.BtnSubmitToListView_Click);
            // 
            // BtnRemoveFromListView
            // 
            this.BtnRemoveFromListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveFromListView.Location = new System.Drawing.Point(388, 103);
            this.BtnRemoveFromListView.Name = "BtnRemoveFromListView";
            this.BtnRemoveFromListView.Size = new System.Drawing.Size(198, 23);
            this.BtnRemoveFromListView.TabIndex = 10;
            this.BtnRemoveFromListView.Text = "Izbrisi iz osobu iz liste";
            this.BtnRemoveFromListView.UseVisualStyleBackColor = true;
            this.BtnRemoveFromListView.Click += new System.EventHandler(this.BtnRemoveFromListView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 476);
            this.Controls.Add(this.BtnAddPerson);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddPerson;
        private System.Windows.Forms.Button button2;
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
    }
}

