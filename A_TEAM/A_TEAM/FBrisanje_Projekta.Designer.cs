namespace A_TEAM
{
    partial class FBrisanje_Projekta
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
            this.LvSpisakProjekata = new System.Windows.Forms.ListView();
            this.BtnIzbrisiProjekat = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LvSpisakProjekata
            // 
            this.LvSpisakProjekata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LvSpisakProjekata.Enabled = false;
            this.LvSpisakProjekata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvSpisakProjekata.FullRowSelect = true;
            this.LvSpisakProjekata.GridLines = true;
            this.LvSpisakProjekata.Location = new System.Drawing.Point(12, 12);
            this.LvSpisakProjekata.MultiSelect = false;
            this.LvSpisakProjekata.Name = "LvSpisakProjekata";
            this.LvSpisakProjekata.Size = new System.Drawing.Size(795, 251);
            this.LvSpisakProjekata.TabIndex = 0;
            this.LvSpisakProjekata.UseCompatibleStateImageBehavior = false;
            this.LvSpisakProjekata.View = System.Windows.Forms.View.Details;
            // 
            // BtnIzbrisiProjekat
            // 
            this.BtnIzbrisiProjekat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiProjekat.Location = new System.Drawing.Point(276, 269);
            this.BtnIzbrisiProjekat.Name = "BtnIzbrisiProjekat";
            this.BtnIzbrisiProjekat.Size = new System.Drawing.Size(224, 32);
            this.BtnIzbrisiProjekat.TabIndex = 1;
            this.BtnIzbrisiProjekat.Text = "Izbrisi projekat";
            this.BtnIzbrisiProjekat.UseVisualStyleBackColor = true;
            this.BtnIzbrisiProjekat.Click += new System.EventHandler(this.BtnIzbrisiProjekat_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ime";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rok zavrsetka";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Potrebno_iskustvo";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Potrebni ljudi iz razvoja";
            this.columnHeader4.Width = 244;
            // 
            // FBrisanje_Projekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 310);
            this.Controls.Add(this.BtnIzbrisiProjekat);
            this.Controls.Add(this.LvSpisakProjekata);
            this.Name = "FBrisanje_Projekta";
            this.Text = "FBrisanje_Projekta";
            this.Shown += new System.EventHandler(this.FBrisanje_Projekta_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvSpisakProjekata;
        private System.Windows.Forms.Button BtnIzbrisiProjekat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}