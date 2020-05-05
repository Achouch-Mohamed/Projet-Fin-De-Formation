using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Fin_Formation
{
    public partial class EditProfile : Form
    {
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
        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            //PictureBox en format Circulaire
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, photo.Width - 3, photo.Height - 3);
            Region rg = new Region(gp);
            photo.Region = rg;

        }
    }
}
