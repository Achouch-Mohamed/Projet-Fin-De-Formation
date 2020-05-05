namespace Projet_Fin_Formation
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.File = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.photo = new System.Windows.Forms.PictureBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.pnfile = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.panelUtilisateur = new System.Windows.Forms.Panel();
            this.Utilisateur = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.pnfile.SuspendLayout();
            this.panelUtilisateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.FlatAppearance.BorderSize = 0;
            this.File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.File.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(147, 45);
            this.File.TabIndex = 6;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = true;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.photo);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.File);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 45);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1150, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Edit Profile";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(1263, 3);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(52, 33);
            this.photo.TabIndex = 14;
            this.photo.TabStop = false;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button14.Location = new System.Drawing.Point(181, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(144, 45);
            this.button14.TabIndex = 7;
            this.button14.Text = "Gestion";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Location = new System.Drawing.Point(3, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 40);
            this.button6.TabIndex = 9;
            this.button6.Text = "Deconnecter";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button10.Location = new System.Drawing.Point(3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 40);
            this.button10.TabIndex = 10;
            this.button10.Text = "Connecter";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pnfile
            // 
            this.pnfile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnfile.Controls.Add(this.button10);
            this.pnfile.Controls.Add(this.Exit);
            this.pnfile.Controls.Add(this.button6);
            this.pnfile.Location = new System.Drawing.Point(0, 47);
            this.pnfile.Name = "pnfile";
            this.pnfile.Size = new System.Drawing.Size(147, 146);
            this.pnfile.TabIndex = 11;
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Exit.Location = new System.Drawing.Point(3, 95);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(141, 40);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // panelUtilisateur
            // 
            this.panelUtilisateur.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelUtilisateur.Controls.Add(this.Utilisateur);
            this.panelUtilisateur.Controls.Add(this.button12);
            this.panelUtilisateur.Controls.Add(this.button13);
            this.panelUtilisateur.Location = new System.Drawing.Point(181, 47);
            this.panelUtilisateur.Name = "panelUtilisateur";
            this.panelUtilisateur.Size = new System.Drawing.Size(147, 142);
            this.panelUtilisateur.TabIndex = 12;
            // 
            // Utilisateur
            // 
            this.Utilisateur.Enabled = false;
            this.Utilisateur.FlatAppearance.BorderSize = 0;
            this.Utilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Utilisateur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilisateur.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Utilisateur.Location = new System.Drawing.Point(3, 3);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(141, 40);
            this.Utilisateur.TabIndex = 10;
            this.Utilisateur.Text = "Utilisateur";
            this.Utilisateur.UseVisualStyleBackColor = true;
            this.Utilisateur.Click += new System.EventHandler(this.Utilisateur_Click);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button12.Location = new System.Drawing.Point(3, 95);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(141, 40);
            this.button12.TabIndex = 11;
            this.button12.Text = "Produit";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button13.Location = new System.Drawing.Point(3, 49);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(141, 40);
            this.button13.TabIndex = 9;
            this.button13.Text = "Deconnecter";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(1156, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "𝕷𝖎𝖛𝖗𝖆𝖎𝖘𝖔𝖓 𝕯𝖆𝖇𝖆";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1327, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelUtilisateur);
            this.Controls.Add(this.pnfile);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.pnfile.ResumeLayout(false);
            this.panelUtilisateur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button File;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel pnfile;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panelUtilisateur;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        public System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Utilisateur;
        private System.Windows.Forms.Label label1;
    }
}