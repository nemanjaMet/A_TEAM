namespace A_TEAM
{
    partial class FVeze_radnika
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
            this.BtnDodajVezu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LvOsobe1 = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvOsobe2 = new System.Windows.Forms.ListView();
            this.columnIdOsoba2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImeOsoba2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezimeOsoba2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osoba 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Osoba 2";
            // 
            // BtnDodajVezu
            // 
            this.BtnDodajVezu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodajVezu.Location = new System.Drawing.Point(128, 286);
            this.BtnDodajVezu.Name = "BtnDodajVezu";
            this.BtnDodajVezu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDodajVezu.Size = new System.Drawing.Size(184, 30);
            this.BtnDodajVezu.TabIndex = 2;
            this.BtnDodajVezu.Text = "Napravi vezu";
            this.BtnDodajVezu.UseVisualStyleBackColor = true;
            this.BtnDodajVezu.Click += new System.EventHandler(this.BtnDodajVezu_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NE_SLAZE_SE",
            "SLAZE_SE",
            "NEUTRALAN"});
            this.comboBox1.Location = new System.Drawing.Point(156, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Izaberi vezu";
            // 
            // LvOsobe1
            // 
            this.LvOsobe1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnIme,
            this.columnPrezime});
            this.LvOsobe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvOsobe1.FullRowSelect = true;
            this.LvOsobe1.GridLines = true;
            this.LvOsobe1.Location = new System.Drawing.Point(22, 106);
            this.LvOsobe1.Name = "LvOsobe1";
            this.LvOsobe1.Size = new System.Drawing.Size(185, 144);
            this.LvOsobe1.TabIndex = 5;
            this.LvOsobe1.UseCompatibleStateImageBehavior = false;
            this.LvOsobe1.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 0;
            // 
            // columnIme
            // 
            this.columnIme.Text = "Ime";
            this.columnIme.Width = 82;
            // 
            // columnPrezime
            // 
            this.columnPrezime.Text = "Prezime";
            this.columnPrezime.Width = 93;
            // 
            // LvOsobe2
            // 
            this.LvOsobe2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdOsoba2,
            this.columnImeOsoba2,
            this.columnPrezimeOsoba2});
            this.LvOsobe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvOsobe2.FullRowSelect = true;
            this.LvOsobe2.GridLines = true;
            this.LvOsobe2.Location = new System.Drawing.Point(239, 106);
            this.LvOsobe2.Name = "LvOsobe2";
            this.LvOsobe2.Size = new System.Drawing.Size(181, 144);
            this.LvOsobe2.TabIndex = 6;
            this.LvOsobe2.UseCompatibleStateImageBehavior = false;
            this.LvOsobe2.View = System.Windows.Forms.View.Details;
            // 
            // columnIdOsoba2
            // 
            this.columnIdOsoba2.Text = "Id";
            this.columnIdOsoba2.Width = 2;
            // 
            // columnImeOsoba2
            // 
            this.columnImeOsoba2.Text = "Ime";
            this.columnImeOsoba2.Width = 84;
            // 
            // columnPrezimeOsoba2
            // 
            this.columnPrezimeOsoba2.Text = "Prezime";
            this.columnPrezimeOsoba2.Width = 84;
            // 
            // FVeze_radnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 371);
            this.Controls.Add(this.LvOsobe2);
            this.Controls.Add(this.LvOsobe1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnDodajVezu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FVeze_radnika";
            this.Text = "FVeze_radnika";
            this.Shown += new System.EventHandler(this.FVeze_radnika_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDodajVezu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView LvOsobe1;
        private System.Windows.Forms.ListView LvOsobe2;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnIme;
        private System.Windows.Forms.ColumnHeader columnPrezime;
        private System.Windows.Forms.ColumnHeader columnIdOsoba2;
        private System.Windows.Forms.ColumnHeader columnImeOsoba2;
        private System.Windows.Forms.ColumnHeader columnPrezimeOsoba2;
    }
}