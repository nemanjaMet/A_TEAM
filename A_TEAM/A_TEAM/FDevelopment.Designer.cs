namespace A_TEAM
{
    partial class FDevelopment
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
            this.TbDevelopmentName = new System.Windows.Forms.TextBox();
            this.TbOpis = new System.Windows.Forms.TextBox();
            this.BtnSubmitData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis:";
            // 
            // TbDevelopmentName
            // 
            this.TbDevelopmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDevelopmentName.Location = new System.Drawing.Point(98, 40);
            this.TbDevelopmentName.Name = "TbDevelopmentName";
            this.TbDevelopmentName.Size = new System.Drawing.Size(204, 22);
            this.TbDevelopmentName.TabIndex = 2;
            // 
            // TbOpis
            // 
            this.TbOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbOpis.Location = new System.Drawing.Point(98, 101);
            this.TbOpis.Multiline = true;
            this.TbOpis.Name = "TbOpis";
            this.TbOpis.Size = new System.Drawing.Size(204, 122);
            this.TbOpis.TabIndex = 3;
            // 
            // BtnSubmitData
            // 
            this.BtnSubmitData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitData.Location = new System.Drawing.Point(50, 351);
            this.BtnSubmitData.Name = "BtnSubmitData";
            this.BtnSubmitData.Size = new System.Drawing.Size(276, 28);
            this.BtnSubmitData.TabIndex = 4;
            this.BtnSubmitData.Text = "Kreiraj development";
            this.BtnSubmitData.UseVisualStyleBackColor = true;
            this.BtnSubmitData.Click += new System.EventHandler(this.BtnSubmitData_Click);
            // 
            // FDevelopment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 391);
            this.Controls.Add(this.BtnSubmitData);
            this.Controls.Add(this.TbOpis);
            this.Controls.Add(this.TbDevelopmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FDevelopment";
            this.Text = "FDevelopment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbDevelopmentName;
        private System.Windows.Forms.TextBox TbOpis;
        private System.Windows.Forms.Button BtnSubmitData;
    }
}