namespace A_TEAM
{
    partial class FBrisanje_Radnika
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
            this.BtnIzbrisiRadnika = new System.Windows.Forms.Button();
            this.LvSpisakRadnika = new System.Windows.Forms.ListView();
            this.ColumnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDatumRodjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnObrazovanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnIskustvo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnIzbrisiRadnika
            // 
            this.BtnIzbrisiRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiRadnika.Location = new System.Drawing.Point(280, 248);
            this.BtnIzbrisiRadnika.Name = "BtnIzbrisiRadnika";
            this.BtnIzbrisiRadnika.Size = new System.Drawing.Size(213, 23);
            this.BtnIzbrisiRadnika.TabIndex = 0;
            this.BtnIzbrisiRadnika.Text = "Izrbisi radnika";
            this.BtnIzbrisiRadnika.UseVisualStyleBackColor = true;
            // 
            // LvSpisakRadnika
            // 
            this.LvSpisakRadnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnIme,
            this.ColumnPrezime,
            this.ColumnAdresa,
            this.ColumnDatumRodjenja,
            this.ColumnObrazovanje,
            this.ColumnIskustvo});
            this.LvSpisakRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvSpisakRadnika.FullRowSelect = true;
            this.LvSpisakRadnika.GridLines = true;
            this.LvSpisakRadnika.Location = new System.Drawing.Point(41, 30);
            this.LvSpisakRadnika.MultiSelect = false;
            this.LvSpisakRadnika.Name = "LvSpisakRadnika";
            this.LvSpisakRadnika.Size = new System.Drawing.Size(789, 193);
            this.LvSpisakRadnika.TabIndex = 1;
            this.LvSpisakRadnika.UseCompatibleStateImageBehavior = false;
            this.LvSpisakRadnika.View = System.Windows.Forms.View.Details;
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
            // FBrisanje_Radnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 306);
            this.Controls.Add(this.LvSpisakRadnika);
            this.Controls.Add(this.BtnIzbrisiRadnika);
            this.Name = "FBrisanje_Radnika";
            this.Text = "FBrisanje_Radnika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnIzbrisiRadnika;
        private System.Windows.Forms.ListView LvSpisakRadnika;
        private System.Windows.Forms.ColumnHeader ColumnIme;
        private System.Windows.Forms.ColumnHeader ColumnPrezime;
        private System.Windows.Forms.ColumnHeader ColumnAdresa;
        private System.Windows.Forms.ColumnHeader ColumnDatumRodjenja;
        private System.Windows.Forms.ColumnHeader ColumnObrazovanje;
        private System.Windows.Forms.ColumnHeader ColumnIskustvo;
    }
}