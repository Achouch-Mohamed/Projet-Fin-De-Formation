using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Projet_Fin_Formation
{
    public partial class Form1 : Form
    {
        Connexion Connection = new Connexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection.CONNECTER();
            Connection.dtadapter = new SqlDataAdapter("select * from utilisateur", Connection.con);
            Connection.dtset = new DataSet();
            Connection.dtadapter.Fill(Connection.dtset, "utilisateur");
           
        }
    }
}
