using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;




namespace Projet_Fin_Formation
{
    public partial class Login : Form
    {
        Connexion c = new Connexion();
        HomePage h = new HomePage();
        Utilisateur u = new Utilisateur();
        public Login()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
        {
            c.CONNECTER();
            c.dtadapter = new SqlDataAdapter("select * from utilisateur", c.con);
            c.dtset = new DataSet();
            c.dtadapter.Fill(c.dtset, "utilisateur");
        }
        private void Connecter_Click(object sender, EventArgs e)
        {



        }

        private void Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        //////////// Images //////////////////////////// 
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //////////////////////////// ////////////////////////////
             private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int sw = 0, i;

            if (Email.Text == "" || Code.Text == "")
            { 
            MessageBox.Show("Svp Remplir tout les champs");
            return;
            }
            
            for (i = 0; i < c.dtset.Tables["utilisateur"].Rows.Count; i++)
            {
              
                if (Email.Text == c.dtset.Tables["utilisateur"].Rows[i][4].ToString() && Code.Text == c.dtset.Tables["utilisateur"].Rows[i][7].ToString())
                {
                   MessageBox.Show("Oki");
                   // MemoryStream ms = new MemoryStream((byte[])u.listUtilisateur.Rows[i].Cells[6].Value);
                   //HomePage.getHomePage.photo.Image = Image.FromStream(ms);

                    sw = 1;
                    if (c.dtset.Tables["utilisateur"].Rows[i][11].ToString() == "Admin")
                    {
                        HomePage.getHomePage.Utilisateur.Enabled = true;
                    }
                    return;
                }
               
            }
                     if (sw == 0)
                     {
                         MessageBox.Show("Non");
                         Email.ResetText();
                         Code.ResetText();
                         Email.Focus();
                         obliémotpasse.Enabled = true;
                         return;
                     }
                     
          
         }

       
           
    
    }
        
}
    

    

        
    
            
       
    
