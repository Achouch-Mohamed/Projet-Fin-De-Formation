namespace Projet_Fin_Formation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Connecter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Code = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.obliémotpasse = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projet_Fin_Formation.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(356, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Connecter
            // 
            this.Connecter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Connecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Connecter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Connecter.BorderRadius = 0;
            this.Connecter.ButtonText = "Connecter";
            this.Connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connecter.DisabledColor = System.Drawing.Color.Gray;
            this.Connecter.Iconcolor = System.Drawing.Color.Transparent;
            this.Connecter.Iconimage = ((System.Drawing.Image)(resources.GetObject("Connecter.Iconimage")));
            this.Connecter.Iconimage_right = null;
            this.Connecter.Iconimage_right_Selected = null;
            this.Connecter.Iconimage_Selected = null;
            this.Connecter.IconMarginLeft = 0;
            this.Connecter.IconMarginRight = 0;
            this.Connecter.IconRightVisible = true;
            this.Connecter.IconRightZoom = 0D;
            this.Connecter.IconVisible = true;
            this.Connecter.IconZoom = 90D;
            this.Connecter.IsTab = false;
            this.Connecter.Location = new System.Drawing.Point(345, 186);
            this.Connecter.Name = "Connecter";
            this.Connecter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Connecter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Connecter.OnHoverTextColor = System.Drawing.Color.White;
            this.Connecter.selected = false;
            this.Connecter.Size = new System.Drawing.Size(126, 36);
            this.Connecter.TabIndex = 7;
            this.Connecter.Text = "Connecter";
            this.Connecter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Connecter.Textcolor = System.Drawing.Color.White;
            this.Connecter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connecter.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.HintForeColor = System.Drawing.Color.Empty;
            this.Email.HintText = "";
            this.Email.isPassword = false;
            this.Email.LineFocusedColor = System.Drawing.Color.Blue;
            this.Email.LineIdleColor = System.Drawing.Color.Gray;
            this.Email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Email.LineThickness = 3;
            this.Email.Location = new System.Drawing.Point(306, 75);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(206, 31);
            this.Email.TabIndex = 12;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Code
            // 
            this.Code.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Code.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Code.HintForeColor = System.Drawing.Color.Empty;
            this.Code.HintText = "";
            this.Code.isPassword = false;
            this.Code.LineFocusedColor = System.Drawing.Color.Blue;
            this.Code.LineIdleColor = System.Drawing.Color.Gray;
            this.Code.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Code.LineThickness = 3;
            this.Code.Location = new System.Drawing.Point(306, 130);
            this.Code.Margin = new System.Windows.Forms.Padding(4);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(206, 31);
            this.Code.TabIndex = 13;
            this.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // obliémotpasse
            // 
            this.obliémotpasse.AutoSize = true;
            this.obliémotpasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obliémotpasse.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obliémotpasse.LinkColor = System.Drawing.Color.Blue;
            this.obliémotpasse.Location = new System.Drawing.Point(353, 240);
            this.obliémotpasse.Name = "obliémotpasse";
            this.obliémotpasse.Size = new System.Drawing.Size(113, 15);
            this.obliémotpasse.TabIndex = 15;
            this.obliémotpasse.TabStop = true;
            this.obliémotpasse.Text = "Mot De Passe Oblié";
            this.obliémotpasse.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.obliémotpasse);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Connecter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton Connecter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Code;
        private System.Windows.Forms.LinkLabel obliémotpasse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}