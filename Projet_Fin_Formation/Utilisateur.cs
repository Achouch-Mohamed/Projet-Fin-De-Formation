using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Projet_Fin_Formation
{
    public partial class Utilisateur : Form
    {
        Connexion Connection = new Connexion();
        public Utilisateur()
        {
            InitializeComponent();
        }
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

        private void Utilisateur_Load(object sender, EventArgs e)
        {
            //////////////
            //this.listUtilisateur.Columns[0].Visible = false;
           //PictureBox en format Circulaire
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, photo.Width - 3, photo.Height - 3);
            Region rg = new Region(gp);
            photo.Region = rg;
            //
            Connection.CONNECTER();
            Connection.dtadapter = new SqlDataAdapter("select * from utilisateur", Connection.con);
            Connection.dtset = new DataSet();
            Connection.dtadapter.Fill(Connection.dtset, "utilisateur");
            listUtilisateur.DataSource= Connection.dtset.Tables["utilisateur"];
            ///DataGrid View Design 
            listUtilisateur.BorderStyle = BorderStyle.None;
            listUtilisateur.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238,239,249);
            listUtilisateur.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            listUtilisateur.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            listUtilisateur.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            listUtilisateur.BackgroundColor = Color.White;
            listUtilisateur.EnableHeadersVisualStyles = false;
            listUtilisateur.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            listUtilisateur.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20,25,72);
            listUtilisateur.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public void Ajoutter()
        {
            if (id.Text == "" || nom.Text == "" || prenom.Text == "" || adresse.Text == "" || email.Text == "" || tele.Text == "")
            {
                MessageBox.Show("SVP Rempliz Tout les Chomps");
                return;
            }

            Connection.NewLigne = Connection.dtset.Tables["utilisateur"].NewRow();
            Connection.NewLigne[0] = id.Text;
            Connection.NewLigne[1] = nom.Text;
            Connection.NewLigne[2] = prenom.Text;
            Connection.NewLigne[3] = adresse.Text;
            Connection.NewLigne[4] = email.Text;
            Connection.NewLigne[5] = tele.Text;
            Connection.NewLigne[6] = imageToByteArray(this.photo.Image);
            Random rnd = new Random();
            int number;
            number = rnd.Next(999, 10000);
            Connection.NewLigne[7] = number.ToString();
            Connection.NewLigne[8] = Age.Text;
            Connection.NewLigne[9] = Ville.Text;
            Connection.NewLigne[10] = dateinscreption.Text;
            Connection.NewLigne[11] = typecompte.Text;
            ///////////////// Mail///////////////////
            //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            //client.EnableSsl = true;
            //client.Timeout = 10000;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.Credentials = new NetworkCredential("mohamedachouch123@gmail.com", "simo@12345");
            //MailMessage msg = new MailMessage();
            //msg.To.Add(email.Text);
            //msg.From = new MailAddress("mohamedachouch123@gmail.com");
            //msg.Body = "Bienvenu Dans Une Societe" + number.ToString();
            //client.Send(msg);
            //MessageBox.Show("Mail Envoyé");
            
            /////////////////////////////////////////
            for (int i = 0; i < Connection.dtset.Tables["utilisateur"].Rows.Count; i++)
            {
                if (id.Text == Connection.dtset.Tables["utilisateur"].Rows[i][0].ToString())
                {
                    MessageBox.Show("C'est Etudiant Deja Ajouter");
                    return;
                }
            }

            Connection.dtset.Tables["utilisateur"].Rows.Add(Connection.NewLigne);
            Connection.CmdBuild = new SqlCommandBuilder(Connection.dtadapter);
            Connection.dtadapter.InsertCommand = Connection.CmdBuild.GetInsertCommand();
            Connection.dtadapter.Update(Connection.dtset, "utilisateur");
            MessageBox.Show("Ajouter Avec Succes");
            listUtilisateur.DataSource = Connection.dtset.Tables["utilisateur"];
            Connection.DECONNECTER();
        }

        public void Suprimer()
        {
            if (id.Text == "")
            {
                MessageBox.Show("SVP Rempliz Le ID_Stagiare");
                return;
            }
            bool m = false;
            for (int i = 0; i < Connection.dtset.Tables["utilisateur"].Rows.Count; i++)
            {
                if (id.Text == Connection.dtset.Tables["utilisateur"].Rows[i][0].ToString())
                {

                    m = true;
                    Connection.dtset.Tables["utilisateur"].Rows[i].Delete();
                    Connection.CmdBuild = new SqlCommandBuilder(Connection.dtadapter);
                    Connection.dtadapter.Update(Connection.dtset, "utilisateur");
                    MessageBox.Show("Supprimer Avec Succes ");
                    listUtilisateur.DataSource = Connection.dtset.Tables["utilisateur"];
                    return;
                }


            }

            if (m == false)
            {
                MessageBox.Show("C'est Etudiant deja Supprimer Ou inconnu ");
            }



        }

        public void Modifier()
        {
            if (id.Text == "" || nom.Text == "" || prenom.Text == "" || adresse.Text == "" || email.Text == "" || tele.Text == "")
            {
                MessageBox.Show("SVP Rempliz Tout les Chomps");
                return;
            }


               for (int i = 0; i < Connection.dtset.Tables["utilisateur"].Rows.Count; i++)
            {
                if (id.Text == Connection.dtset.Tables["utilisateur"].Rows[i][0].ToString())
                {
                    Connection.dtset.Tables["utilisateur"].Rows[i][1] = nom.Text;
                    Connection.dtset.Tables["utilisateur"].Rows[i][2] = prenom.Text;
                    Connection.dtset.Tables["utilisateur"].Rows[i][3] = adresse.Text;
                    Connection.dtset.Tables["utilisateur"].Rows[i][4] = email.Text;
                    Connection.dtset.Tables["utilisateur"].Rows[i][5] = tele.Text;
                    Connection.dtset.Tables["utilisateur"].Rows[i][6] = imageToByteArray(this.photo.Image); 
                    Connection.dtset.Tables["utilisateur"].Rows[i][8] = Age.Text;
                    Connection.dtset.Tables["utilisateur"].Rows[i][9] = Ville.Text;
                    Connection.dtset.Tables["utilisateur"].Rows[i][10] = dateinscreption.Text;
                    Connection.dtset.Tables["utilisateur"].Rows[i][11] = typecompte.Text;
                    Connection.CmdBuild = new SqlCommandBuilder(Connection.dtadapter);
                    Connection.dtadapter.InsertCommand = Connection.CmdBuild.GetInsertCommand();
                    Connection.dtadapter.Update(Connection.dtset, "utilisateur");
                    listUtilisateur.DataSource = Connection.dtset.Tables["utilisateur"];
                    MessageBox.Show("Modifier Avec Succes ");
                    return;
                }
                else
                {
                    MessageBox.Show("C'est Etudiant N'exist Pas");
                }
            }




        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tele_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

                e.Handled = true;
            //else if (char.IsControl(e.KeyChar))
            //    e.Handled = true;
            else
                e.Handled = false;
        }

        private void prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

                e.Handled = true;
            //else if (char.IsControl(e.KeyChar))
            //    e.Handled = true;
            else
                e.Handled = false;
        }

        private void adresse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

                e.Handled = true;
            //else if (char.IsControl(e.KeyChar))
            //    e.Handled = true;
            else
                e.Handled = false;
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

                e.Handled = true;
            //else if (char.IsControl(e.KeyChar))
            //    e.Handled = true;
            else
                e.Handled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ajoutter();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.ShowDialog();
            if (this.openFileDialog1.FileName != "")
            this.photo.ImageLocation = this.openFileDialog1.FileName;

        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void id_AcceptsTabChanged(object sender, EventArgs e)
        {
           
        }

        private void id_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Suprimer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id.ResetText();
            nom.ResetText();
            prenom.ResetText();
            adresse.ResetText();
            tele.ResetText();
            email.ResetText();
            Ville.ResetText();
            Age.ResetText();
            typecompte.ResetText();
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligneencours;
            ligneencours = listUtilisateur.CurrentRow.Index;
            id.Text = this.listUtilisateur.Rows[ligneencours].Cells[0].Value.ToString();
            nom.Text = this.listUtilisateur.Rows[ligneencours].Cells[1].Value.ToString();
            prenom.Text = this.listUtilisateur.Rows[ligneencours].Cells[2].Value.ToString();
            adresse.Text = this.listUtilisateur.Rows[ligneencours].Cells[3].Value.ToString();
            email.Text = this.listUtilisateur.Rows[ligneencours].Cells[4].Value.ToString();
            tele.Text = this.listUtilisateur.Rows[ligneencours].Cells[5].Value.ToString();
           
            MemoryStream ms = new MemoryStream((byte[])this.listUtilisateur.Rows[ligneencours].Cells[6].Value);
            photo.Image = Image.FromStream(ms);
            Age.Text = this.listUtilisateur.Rows[ligneencours].Cells[8].Value.ToString();
            Ville.Text = this.listUtilisateur.Rows[ligneencours].Cells[9].Value.ToString();
            dateinscreption.Text = this.listUtilisateur.Rows[ligneencours].Cells[10].Value.ToString();
            typecompte.Text = this.listUtilisateur.Rows[ligneencours].Cells[11].Value.ToString();
          
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sw = 0;
            if (search.Text != "")
            {
                for (int s = 0; s <= this.listUtilisateur.RowCount - 2; s++)
                {
                    if (search.Text == this.listUtilisateur.Rows[s].Cells[0].Value.ToString())
                    {
                        id.Text = this.listUtilisateur.Rows[s].Cells[0].Value.ToString();
                        nom.Text = this.listUtilisateur.Rows[s].Cells[1].Value.ToString();
                        prenom.Text = this.listUtilisateur.Rows[s].Cells[2].Value.ToString();
                        adresse.Text = this.listUtilisateur.Rows[s].Cells[3].Value.ToString();
                        email.Text = this.listUtilisateur.Rows[s].Cells[4].Value.ToString();
                        tele.Text = this.listUtilisateur.Rows[s].Cells[5].Value.ToString();
                        MemoryStream ms = new MemoryStream((byte[])this.listUtilisateur.Rows[s].Cells[6].Value);
                        photo.Image = Image.FromStream(ms);
                        Age.Text = this.listUtilisateur.Rows[s].Cells[8].Value.ToString();
                        Ville.Text = this.listUtilisateur.Rows[s].Cells[9].Value.ToString();
                        dateinscreption.Text = this.listUtilisateur.Rows[s].Cells[10].Value.ToString();
                        typecompte.Text = this.listUtilisateur.Rows[s].Cells[11].Value.ToString();
                        sw = 1;
                    }
                }
                if (sw == 0)
                {
                    MessageBox.Show("ID Introuvable");
                }
            }
            else
            {
                MessageBox.Show("Vous Devez Remplir ID");
            }

        }

      
    }
}
