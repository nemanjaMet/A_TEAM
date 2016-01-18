namespace A_TEAM
{
    partial class FVeza_Radnik_Razvoj
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
            this.BtnKreirajVezu = new System.Windows.Forms.Button();
            this.LvSpisakRadnika = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDatumRodjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnObrazovanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnIskustvo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvSpisakRazvoja = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnKreirajVezu
            // 
            this.BtnKreirajVezu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKreirajVezu.Location = new System.Drawing.Point(615, 280);
            this.BtnKreirajVezu.Name = "BtnKreirajVezu";
            this.BtnKreirajVezu.Size = new System.Drawing.Size(127, 47);
            this.BtnKreirajVezu.TabIndex = 2;
            this.BtnKreirajVezu.Text = "Kreiraj vezu";
            this.BtnKreirajVezu.UseVisualStyleBackColor = true;
            this.BtnKreirajVezu.Click += new System.EventHandler(this.BtnKreirajVezu_Click);
            // 
            // LvSpisakRadnika
            // 
            this.LvSpisakRadnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.ColumnIme,
            this.ColumnPrezime,
            this.ColumnAdresa,
            this.ColumnDatumRodjenja,
            this.ColumnObrazovanje,
            this.ColumnIskustvo});
            this.LvSpisakRadnika.Enabled = false;
            this.LvSpisakRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvSpisakRadnika.FullRowSelect = true;
            this.LvSpisakRadnika.GridLines = true;
            this.LvSpisakRadnika.Location = new System.Drawing.Point(23, 12);
            this.LvSpisakRadnika.MultiSelect = false;
            this.LvSpisakRadnika.Name = "LvSpisakRadnika";
            this.LvSpisakRadnika.Size = new System.Drawing.Size(789, 193);
            this.LvSpisakRadnika.TabIndex = 3;
            this.LvSpisakRadnika.UseCompatibleStateImageBehavior = false;
            this.LvSpisakRadnika.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 0;
            // 
            // ColumnIme
            // 
            this.ColumnIme.Text = "Ime";
            this.ColumnIme.Width = 83;
            // 
            // ColumnPrezime
            // 
            this.ColumnPrezime.Text = "Prezime";
            this.ColumnPrezime.Width = 89;
            // 
            // ColumnAdresa
            // 
            this.ColumnAdresa.Text = "Adresa";
            this.ColumnAdresa.Width = 96;
            // 
            // ColumnDatumRodjenja
            // 
            this.ColumnDatumRodjenja.Text = "Datum rodjenja";
            this.ColumnDatumRodjenja.Width = 115;
            // 
            // ColumnObrazovanje
            // 
            this.ColumnObrazovanje.Text = "Obrazovanje";
            this.ColumnObrazovanje.Width = 99;
            // 
            // ColumnIskustvo
            // 
            this.ColumnIskustvo.Text = "Iskustvo";
            this.ColumnIskustvo.Width = 285;
            // 
            // LvSpisakRazvoja
            // 
            this.LvSpisakRazvoja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.ColumnOpis});
            this.LvSpisakRazvoja.Enabled = false;
            this.LvSpisakRazvoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvSpisakRazvoja.FullRowSelect = true;
            this.LvSpisakRazvoja.GridLines = true;
            this.LvSpisakRazvoja.Location = new System.Drawing.Point(23, 211);
            this.LvSpisakRazvoja.MultiSelect = false;
            this.LvSpisakRazvoja.Name = "LvSpisakRazvoja";
            this.LvSpisakRazvoja.Size = new System.Drawing.Size(479, 211);
            this.LvSpisakRazvoja.TabIndex = 4;
            this.LvSpisakRazvoja.UseCompatibleStateImageBehavior = false;
            this.LvSpisakRazvoja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ime";
            this.columnHeader1.Width = 180;
            // 
            // ColumnOpis
            // 
            this.ColumnOpis.Text = "Opis";
            this.ColumnOpis.Width = 258;
            // 
            // FVeza_Radnik_Razvoj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 433);
            this.Controls.Add(this.LvSpisakRazvoja);
            this.Controls.Add(this.LvSpisakRadnika);
            this.Controls.Add(this.BtnKreirajVezu);
            this.Name = "FVeza_Radnik_Razvoj";
            this.Text = "FVeza_Radnik_Razvoj";
            this.Shown += new System.EventHandler(this.FVeza_Radnik_Razvoj_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKreirajVezu;
        private System.Windows.Forms.ListView LvSpisakRadnika;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader ColumnIme;
        private System.Windows.Forms.ColumnHeader ColumnPrezime;
        private System.Windows.Forms.ColumnHeader ColumnAdresa;
        private System.Windows.Forms.ColumnHeader ColumnDatumRodjenja;
        private System.Windows.Forms.ColumnHeader ColumnObrazovanje;
        private System.Windows.Forms.ColumnHeader ColumnIskustvo;
        private System.Windows.Forms.ListView LvSpisakRazvoja;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnOpis;
    }
}