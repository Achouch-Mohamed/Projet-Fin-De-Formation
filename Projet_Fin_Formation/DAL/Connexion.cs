using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Fin_Formation
{
    class Connexion
    {
        public SqlConnection con = new SqlConnection();
        //POUR CHAQUE TABLE
        public DataRow NewLigne;
        public SqlCommandBuilder CmdBuild;
        public SqlDataAdapter dtadapter = new SqlDataAdapter();
        public DataSet dtset = new DataSet();
        //Méthode Connecter
        public void CONNECTER()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {

                con.ConnectionString = @"Data Source=ACHOUCH-PC\SQLEXPRESS;Initial Catalog=PFF;Integrated Security=True";
                con.Open();
            }
        }
        //Méthode Déconnecter
        public void DECONNECTER()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
     
    }
}
