namespace A_TEAM
{
    partial class FBrisanje_Razvoja
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
            this.LvSpisakRazvoja = new System.Windows.Forms.ListView();
            this.BtnIzbrisiRazvoj = new System.Windows.Forms.Button();
            this.ColumnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LvSpisakRazvoja
            // 
            this.LvSpisakRazvoja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnIme,
            this.ColumnOpis});
            this.LvSpisakRazvoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvSpisakRazvoja.FullRowSelect = true;
            this.LvSpisakRazvoja.GridLines = true;
            this.LvSpisakRazvoja.Location = new System.Drawing.Point(12, 33);
            this.LvSpisakRazvoja.MultiSelect = false;
            this.LvSpisakRazvoja.Name = "LvSpisakRazvoja";
            this.LvSpisakRazvoja.Size = new System.Drawing.Size(479, 211);
            this.LvSpisakRazvoja.TabIndex = 0;
            this.LvSpisakRazvoja.UseCompatibleStateImageBehavior = false;
            this.LvSpisakRazvoja.View = System.Windows.Forms.View.Details;
            // 
            // BtnIzbrisiRazvoj
            // 
            this.BtnIzbrisiRazvoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiRazvoj.Location = new System.Drawing.Point(200, 293);
            this.BtnIzbrisiRazvoj.Name = "BtnIzbrisiRazvoj";
            this.BtnIzbrisiRazvoj.Size = new System.Drawing.Size(124, 23);
            this.BtnIzbrisiRazvoj.TabIndex = 1;
            this.BtnIzbrisiRazvoj.Text = "Izbrisi razvoj";
            this.BtnIzbrisiRazvoj.UseVisualStyleBackColor = true;
            // 
            // ColumnIme
            // 
            this.ColumnIme.Text = "Ime";
            this.ColumnIme.Width = 180;
            // 
            // ColumnOpis
            // 
            this.ColumnOpis.Text = "Opis";
            this.ColumnOpis.Width = 258;
            // 
            // FBrisanje_Razvoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 354);
            this.Controls.Add(this.BtnIzbrisiRazvoj);
            this.Controls.Add(this.LvSpisakRazvoja);
            this.Name = "FBrisanje_Razvoja";
            this.Text = "FBrisanje_Razvoja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvSpisakRazvoja;
        private System.Windows.Forms.Button BtnIzbrisiRazvoj;
        private System.Windows.Forms.ColumnHeader ColumnIme;
        private System.Windows.Forms.ColumnHeader ColumnOpis;
    }
}