namespace A_TEAM.DomainModel
{
    partial class FBrisanje_Veza
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
            this.LvSpisakRadnika = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDatumRodjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnObrazovanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnIskustvo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvSpisakSlazeSe = new System.Windows.Forms.ListView();
            this.LvNeutralan = new System.Windows.Forms.ListView();
            this.LvNeSlazeSe = new System.Windows.Forms.ListView();
            this.LvSpisakRazvoja = new System.Windows.Forms.ListView();
            this.BtnPogledajSelektovanogRadnika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIzbrisiVezuSlazeSe = new System.Windows.Forms.Button();
            this.BtnIzbrisiVezuNeutralan = new System.Windows.Forms.Button();
            this.BtnIzbrisiVezuNeSlazeSe = new System.Windows.Forms.Button();
            this.BtnIzbrisiVezuKaRazvoju = new System.Windows.Forms.Button();
            this.columnSlazeSeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSlazeSeIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSlazeSePrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNeutralanID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNeutralanIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNeutralanPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNeSlazeSeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNeSlazeSeIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNeSlazeSePrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRazvojIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRazvojOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.LvSpisakRadnika.Location = new System.Drawing.Point(12, 12);
            this.LvSpisakRadnika.MultiSelect = false;
            this.LvSpisakRadnika.Name = "LvSpisakRadnika";
            this.LvSpisakRadnika.Size = new System.Drawing.Size(857, 193);
            this.LvSpisakRadnika.TabIndex = 2;
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
            this.ColumnIskustvo.Width = 250;
            // 
            // LvSpisakSlazeSe
            // 
            this.LvSpisakSlazeSe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSlazeSeID,
            this.columnSlazeSeIme,
            this.columnSlazeSePrezime});
            this.LvSpisakSlazeSe.Enabled = false;
            this.LvSpisakSlazeSe.FullRowSelect = true;
            this.LvSpisakSlazeSe.GridLines = true;
            this.LvSpisakSlazeSe.Location = new System.Drawing.Point(12, 283);
            this.LvSpisakSlazeSe.MultiSelect = false;
            this.LvSpisakSlazeSe.Name = "LvSpisakSlazeSe";
            this.LvSpisakSlazeSe.Size = new System.Drawing.Size(211, 97);
            this.LvSpisakSlazeSe.TabIndex = 3;
            this.LvSpisakSlazeSe.UseCompatibleStateImageBehavior = false;
            this.LvSpisakSlazeSe.View = System.Windows.Forms.View.Details;
            // 
            // LvNeutralan
            // 
            this.LvNeutralan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNeutralanID,
            this.columnNeutralanIme,
            this.columnNeutralanPrezime});
            this.LvNeutralan.Enabled = false;
            this.LvNeutralan.FullRowSelect = true;
            this.LvNeutralan.GridLines = true;
            this.LvNeutralan.Location = new System.Drawing.Point(229, 283);
            this.LvNeutralan.MultiSelect = false;
            this.LvNeutralan.Name = "LvNeutralan";
            this.LvNeutralan.Size = new System.Drawing.Size(219, 97);
            this.LvNeutralan.TabIndex = 4;
            this.LvNeutralan.UseCompatibleStateImageBehavior = false;
            this.LvNeutralan.View = System.Windows.Forms.View.Details;
            // 
            // LvNeSlazeSe
            // 
            this.LvNeSlazeSe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNeSlazeSeId,
            this.columnNeSlazeSeIme,
            this.columnNeSlazeSePrezime});
            this.LvNeSlazeSe.Enabled = false;
            this.LvNeSlazeSe.FullRowSelect = true;
            this.LvNeSlazeSe.GridLines = true;
            this.LvNeSlazeSe.Location = new System.Drawing.Point(454, 283);
            this.LvNeSlazeSe.MultiSelect = false;
            this.LvNeSlazeSe.Name = "LvNeSlazeSe";
            this.LvNeSlazeSe.Size = new System.Drawing.Size(206, 97);
            this.LvNeSlazeSe.TabIndex = 5;
            this.LvNeSlazeSe.UseCompatibleStateImageBehavior = false;
            this.LvNeSlazeSe.View = System.Windows.Forms.View.Details;
            // 
            // LvSpisakRazvoja
            // 
            this.LvSpisakRazvoja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRazvojIme,
            this.columnRazvojOpis});
            this.LvSpisakRazvoja.Enabled = false;
            this.LvSpisakRazvoja.FullRowSelect = true;
            this.LvSpisakRazvoja.GridLines = true;
            this.LvSpisakRazvoja.Location = new System.Drawing.Point(666, 283);
            this.LvSpisakRazvoja.MultiSelect = false;
            this.LvSpisakRazvoja.Name = "LvSpisakRazvoja";
            this.LvSpisakRazvoja.Size = new System.Drawing.Size(203, 97);
            this.LvSpisakRazvoja.TabIndex = 6;
            this.LvSpisakRazvoja.UseCompatibleStateImageBehavior = false;
            this.LvSpisakRazvoja.View = System.Windows.Forms.View.Details;
            // 
            // BtnPogledajSelektovanogRadnika
            // 
            this.BtnPogledajSelektovanogRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPogledajSelektovanogRadnika.Location = new System.Drawing.Point(181, 211);
            this.BtnPogledajSelektovanogRadnika.Name = "BtnPogledajSelektovanogRadnika";
            this.BtnPogledajSelektovanogRadnika.Size = new System.Drawing.Size(514, 29);
            this.BtnPogledajSelektovanogRadnika.TabIndex = 7;
            this.BtnPogledajSelektovanogRadnika.Text = "Pogledaj veze selektovanog radnika";
            this.BtnPogledajSelektovanogRadnika.UseVisualStyleBackColor = true;
            this.BtnPogledajSelektovanogRadnika.Click += new System.EventHandler(this.BtnPogledajSelektovanogRadnika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Slaze se sa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Neutralan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ne slaze se sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(710, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pripada razvojima";
            // 
            // BtnIzbrisiVezuSlazeSe
            // 
            this.BtnIzbrisiVezuSlazeSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiVezuSlazeSe.Location = new System.Drawing.Point(12, 406);
            this.BtnIzbrisiVezuSlazeSe.Name = "BtnIzbrisiVezuSlazeSe";
            this.BtnIzbrisiVezuSlazeSe.Size = new System.Drawing.Size(211, 38);
            this.BtnIzbrisiVezuSlazeSe.TabIndex = 12;
            this.BtnIzbrisiVezuSlazeSe.Text = "Izbrisi vezu slaze se";
            this.BtnIzbrisiVezuSlazeSe.UseVisualStyleBackColor = true;
            this.BtnIzbrisiVezuSlazeSe.Click += new System.EventHandler(this.BtnIzbrisiVezuSlazeSe_Click);
            // 
            // BtnIzbrisiVezuNeutralan
            // 
            this.BtnIzbrisiVezuNeutralan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiVezuNeutralan.Location = new System.Drawing.Point(229, 406);
            this.BtnIzbrisiVezuNeutralan.Name = "BtnIzbrisiVezuNeutralan";
            this.BtnIzbrisiVezuNeutralan.Size = new System.Drawing.Size(219, 38);
            this.BtnIzbrisiVezuNeutralan.TabIndex = 13;
            this.BtnIzbrisiVezuNeutralan.Text = "Izbrisi vezu neutralan";
            this.BtnIzbrisiVezuNeutralan.UseVisualStyleBackColor = true;
            this.BtnIzbrisiVezuNeutralan.Click += new System.EventHandler(this.BtnIzbrisiVezuNeutralan_Click);
            // 
            // BtnIzbrisiVezuNeSlazeSe
            // 
            this.BtnIzbrisiVezuNeSlazeSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiVezuNeSlazeSe.Location = new System.Drawing.Point(454, 406);
            this.BtnIzbrisiVezuNeSlazeSe.Name = "BtnIzbrisiVezuNeSlazeSe";
            this.BtnIzbrisiVezuNeSlazeSe.Size = new System.Drawing.Size(206, 38);
            this.BtnIzbrisiVezuNeSlazeSe.TabIndex = 14;
            this.BtnIzbrisiVezuNeSlazeSe.Text = "Izbrisi vezu ne skaze se";
            this.BtnIzbrisiVezuNeSlazeSe.UseVisualStyleBackColor = true;
            this.BtnIzbrisiVezuNeSlazeSe.Click += new System.EventHandler(this.BtnIzbrisiVezuNeSlazeSe_Click);
            // 
            // BtnIzbrisiVezuKaRazvoju
            // 
            this.BtnIzbrisiVezuKaRazvoju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiVezuKaRazvoju.Location = new System.Drawing.Point(666, 406);
            this.BtnIzbrisiVezuKaRazvoju.Name = "BtnIzbrisiVezuKaRazvoju";
            this.BtnIzbrisiVezuKaRazvoju.Size = new System.Drawing.Size(203, 38);
            this.BtnIzbrisiVezuKaRazvoju.TabIndex = 15;
            this.BtnIzbrisiVezuKaRazvoju.Text = "Izbrisi vezu ka razvoju";
            this.BtnIzbrisiVezuKaRazvoju.UseVisualStyleBackColor = true;
            this.BtnIzbrisiVezuKaRazvoju.Click += new System.EventHandler(this.BtnIzbrisiVezuKaRazvoju_Click);
            // 
            // columnSlazeSeID
            // 
            this.columnSlazeSeID.Text = "ID";
            this.columnSlazeSeID.Width = 0;
            // 
            // columnSlazeSeIme
            // 
            this.columnSlazeSeIme.Text = "Ime";
            this.columnSlazeSeIme.Width = 79;
            // 
            // columnSlazeSePrezime
            // 
            this.columnSlazeSePrezime.Text = "Prezime";
            this.columnSlazeSePrezime.Width = 117;
            // 
            // columnNeutralanID
            // 
            this.columnNeutralanID.Text = "ID";
            this.columnNeutralanID.Width = 2;
            // 
            // columnNeutralanIme
            // 
            this.columnNeutralanIme.Text = "Ime";
            this.columnNeutralanIme.Width = 92;
            // 
            // columnNeutralanPrezime
            // 
            this.columnNeutralanPrezime.Text = "Prezime";
            this.columnNeutralanPrezime.Width = 116;
            // 
            // columnNeSlazeSeId
            // 
            this.columnNeSlazeSeId.Text = "ID";
            this.columnNeSlazeSeId.Width = 0;
            // 
            // columnNeSlazeSeIme
            // 
            this.columnNeSlazeSeIme.Text = "Ime";
            // 
            // columnNeSlazeSePrezime
            // 
            this.columnNeSlazeSePrezime.Text = "Prezime";
            this.columnNeSlazeSePrezime.Width = 133;
            // 
            // columnRazvojIme
            // 
            this.columnRazvojIme.Text = "Ime";
            this.columnRazvojIme.Width = 91;
            // 
            // columnRazvojOpis
            // 
            this.columnRazvojOpis.Text = "Opis";
            this.columnRazvojOpis.Width = 98;
            // 
            // FBrisanje_Veza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 456);
            this.Controls.Add(this.BtnIzbrisiVezuKaRazvoju);
            this.Controls.Add(this.BtnIzbrisiVezuNeSlazeSe);
            this.Controls.Add(this.BtnIzbrisiVezuNeutralan);
            this.Controls.Add(this.BtnIzbrisiVezuSlazeSe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPogledajSelektovanogRadnika);
            this.Controls.Add(this.LvSpisakRazvoja);
            this.Controls.Add(this.LvNeSlazeSe);
            this.Controls.Add(this.LvNeutralan);
            this.Controls.Add(this.LvSpisakSlazeSe);
            this.Controls.Add(this.LvSpisakRadnika);
            this.Name = "FBrisanje_Veza";
            this.Text = "FBrisanje_Veza";
            this.Shown += new System.EventHandler(this.FBrisanje_Veza_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvSpisakRadnika;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader ColumnIme;
        private System.Windows.Forms.ColumnHeader ColumnPrezime;
        private System.Windows.Forms.ColumnHeader ColumnAdresa;
        private System.Windows.Forms.ColumnHeader ColumnDatumRodjenja;
        private System.Windows.Forms.ColumnHeader ColumnObrazovanje;
        private System.Windows.Forms.ColumnHeader ColumnIskustvo;
        private System.Windows.Forms.ListView LvSpisakSlazeSe;
        private System.Windows.Forms.ColumnHeader columnSlazeSeID;
        private System.Windows.Forms.ColumnHeader columnSlazeSeIme;
        private System.Windows.Forms.ColumnHeader columnSlazeSePrezime;
        private System.Windows.Forms.ListView LvNeutralan;
        private System.Windows.Forms.ColumnHeader columnNeutralanID;
        private System.Windows.Forms.ColumnHeader columnNeutralanIme;
        private System.Windows.Forms.ColumnHeader columnNeutralanPrezime;
        private System.Windows.Forms.ListView LvNeSlazeSe;
        private System.Windows.Forms.ColumnHeader columnNeSlazeSeId;
        private System.Windows.Forms.ColumnHeader columnNeSlazeSeIme;
        private System.Windows.Forms.ColumnHeader columnNeSlazeSePrezime;
        private System.Windows.Forms.ListView LvSpisakRazvoja;
        private System.Windows.Forms.ColumnHeader columnRazvojIme;
        private System.Windows.Forms.ColumnHeader columnRazvojOpis;
        private System.Windows.Forms.Button BtnPogledajSelektovanogRadnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIzbrisiVezuSlazeSe;
        private System.Windows.Forms.Button BtnIzbrisiVezuNeutralan;
        private System.Windows.Forms.Button BtnIzbrisiVezuNeSlazeSe;
        private System.Windows.Forms.Button BtnIzbrisiVezuKaRazvoju;
    }
}