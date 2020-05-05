using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows;

namespace Projet_Fin_Formation
{
    public partial class HomePage : Form
    {
       
        
        private static HomePage HPage;
        static void frm_frmClosed(object sender ,FormClosedEventArgs e)
        {
            HPage = null;
        }
       
        public static HomePage getHomePage
        {
            get
            {
                if (HPage==null)
                {
                    HPage = new HomePage();
                    HPage.FormClosed += new FormClosedEventHandler(frm_frmClosed);
                }
                return HPage;
            }
        }
        // Classe Drawing Image
        public class CircularPictureBox : PictureBox
        {
            protected override void OnPaint(PaintEventArgs pe)
            {
                GraphicsPath g = new GraphicsPath();
                g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(g);
                base.OnPaint(pe);
            }
        }
      
       ////////////////////
        public HomePage()
        {
            if (HPage == null)
            {
                HPage = this;
            }
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            InitializeComponent();

            string str = string.Empty;
            for (int i = 0; i < 100000; i++)
            {
                str += i.ToString();
            }
            t.Abort();
           
        }

        void splash()
        {
            
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Livraison Daba";
            Application.Run(frm);
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.MdiParent = this;
            l.Show();
            pnfile.Visible = false;

           
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnfile.Visible = true;
            panelUtilisateur.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelUtilisateur.Visible = true;
            pnfile.Visible = false;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            pnfile.Visible = false;
            panelUtilisateur.Visible = false;

            //PictureBox en format Circulaire
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, photo.Width - 3, photo.Height - 3);
            Region rg = new Region(gp);
            photo.Region = rg;
        }

        private void Utilisateur_Click(object sender, EventArgs e)
        {
            Utilisateur u = new Utilisateur();
            u.MdiParent = this;
            u.Show();
            panelUtilisateur.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.MdiParent = this;
            l.Show();
            pnfile.Visible = false;
        }

        private void File_Click(object sender, EventArgs e)
        {
            pnfile.Visible = true;
            panelUtilisateur.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pnfile.Visible = false;
            panelUtilisateur.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
