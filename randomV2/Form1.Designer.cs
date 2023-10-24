namespace randomV2
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
            this.lbNot = new System.Windows.Forms.ListBox();
            this.lblDuz = new System.Windows.Forms.Label();
            this.lblKaldi = new System.Windows.Forms.Label();
            this.lblTesekkur = new System.Windows.Forms.Label();
            this.lblTaktir = new System.Windows.Forms.Label();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNot
            // 
            this.lbNot.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNot.FormattingEnabled = true;
            this.lbNot.Location = new System.Drawing.Point(13, 13);
            this.lbNot.Name = "lbNot";
            this.lbNot.Size = new System.Drawing.Size(120, 212);
            this.lbNot.TabIndex = 0;
            // 
            // lblDuz
            // 
            this.lblDuz.AutoSize = true;
            this.lblDuz.Location = new System.Drawing.Point(144, 63);
            this.lblDuz.Name = "lblDuz";
            this.lblDuz.Size = new System.Drawing.Size(29, 13);
            this.lblDuz.TabIndex = 1;
            this.lblDuz.Text = "Düz:";
            // 
            // lblKaldi
            // 
            this.lblKaldi.AutoSize = true;
            this.lblKaldi.Location = new System.Drawing.Point(142, 33);
            this.lblKaldi.Name = "lblKaldi";
            this.lblKaldi.Size = new System.Drawing.Size(36, 13);
            this.lblKaldi.TabIndex = 2;
            this.lblKaldi.Text = "Kaldı :";
            // 
            // lblTesekkur
            // 
            this.lblTesekkur.AutoSize = true;
            this.lblTesekkur.Location = new System.Drawing.Point(142, 95);
            this.lblTesekkur.Name = "lblTesekkur";
            this.lblTesekkur.Size = new System.Drawing.Size(58, 13);
            this.lblTesekkur.TabIndex = 3;
            this.lblTesekkur.Text = "Teşekkür :";
            // 
            // lblTaktir
            // 
            this.lblTaktir.AutoSize = true;
            this.lblTaktir.Location = new System.Drawing.Point(143, 130);
            this.lblTaktir.Name = "lblTaktir";
            this.lblTaktir.Size = new System.Drawing.Size(34, 13);
            this.lblTaktir.TabIndex = 4;
            this.lblTaktir.Text = "Taktir";
            // 
            // btnNot
            // 
            this.btnNot.BackColor = System.Drawing.Color.LightGreen;
            this.btnNot.Location = new System.Drawing.Point(149, 167);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(75, 23);
            this.btnNot.TabIndex = 5;
            this.btnNot.Text = "Not";
            this.btnNot.UseVisualStyleBackColor = false;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SlateGray;
            this.btnEkle.Location = new System.Drawing.Point(149, 201);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 248);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.lblTaktir);
            this.Controls.Add(this.lblTesekkur);
            this.Controls.Add(this.lblKaldi);
            this.Controls.Add(this.lblDuz);
            this.Controls.Add(this.lbNot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNot;
        private System.Windows.Forms.Label lblDuz;
        private System.Windows.Forms.Label lblKaldi;
        private System.Windows.Forms.Label lblTesekkur;
        private System.Windows.Forms.Label lblTaktir;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnEkle;
    }
}

