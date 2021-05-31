using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using dessida.ini;

namespace dessida
{

    class Var
    {
         

        private static string sqlmy = @"Server="+ini.Serveur+";Database="+ini.Database+";Uid="+ini.Uid+";Pwd="+ini.Pwd+";";

        public static string Sqlmy
        {

            get { return sqlmy; }
            set { sqlmy = value; }
        }


        public static class ini
        {
            //------------------------------------------------------------------------
            // Settings.ini
            // [Serveur]
            // Serveur=
            // Database=
            // Uid=
            // Pwd=
            // Backup=
            //-------------------------------------------------------------------------
            static IniFile MyIni = new IniFile("Settings.ini");
            public static string Serveur = MyIni.Read("Serveur", "Serveur");
            public static string Database = MyIni.Read("Database", "Serveur");
            public static string Uid = MyIni.Read("Uid", "Serveur");
            public static string Pwd = MyIni.Read("Pwd","Serveur");
            public static string backup = MyIni.Read("Backup", "Serveur");
        }

        public class dati
        {
            public static int nombre { get; set; }
        }
        public static class global
        {
            public static int M; //Mois
            public static int A; //Année
            public static int J; //Jour Selectionné
            public static int j2; //Jour scanner pour crée calandrier
            public static int lWeek1;
            public static int lWeek2;
            public static int lWeek3;
            public static int lWeek4;
            public static int lWeek5;
            public static int lWeek6;
            public static int acess;
            public static string user;
            public static string pass;
            public static string infoRegi;
            public static bool serveur = true;



        }
        public static string dato
        {
            get { return global.A.ToString() + "-" + global.M.ToString() + "-" + global.J.ToString(); }
        }
        public static string uniqueDato
        {
            get { return global.A.ToString() + "-" + global.M.ToString() + "-" + global.j2.ToString(); }
        }

        public static bool connect
        {
            get
            {
                try
                { 
                using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
                {
                    string selectQuery = "SELECT * FROM login where user = '" + global.user + "' and pass = '" + global.pass + "';";
                    mysqlCon.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        Var.global.acess = (int)reader["acess"];
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                }
                catch (MySqlException ex)
                {
                    global.serveur = false;
                    return false;

                }


            }
        }

        public static string sqlreturn
        {
            get
            {

                using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
                {
                    string selectQuery = "SELECT COUNT(RaportDate) as 'nombre' FROM Raport WHERE RaportDate = '" + Var.uniqueDato + "';";
                    mysqlCon.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    var mega = reader.GetString("nombre");
                    mysqlCon.Close();
                    return mega;

                }


            }
        }
        public static string sqlreturn1
        {
            get
            {

                using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
                {
                    string selectQuery = "SELECT COUNT(dateReparation) as 'nombre' FROM Reparation WHERE dateReparation >= '" + Var.uniqueDato + "'AND dateReparation < '" + Var.uniqueDato + "'+ INTERVAL 1 DAY;";
                    mysqlCon.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    var mega = reader.GetString("nombre");
                    mysqlCon.Close();
                    return mega;

                }

            }

        }
        public static string sqlreturn2
        {

            get
            {
                var parseDate = DateTime.Parse(uniqueDato);
                if (parseDate <= DateTime.Now) //Si on regarde une date ultérieure a aujourd'hui
                {
                    using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
                    {
                        string selectQuery = "SELECT nombre AS 'toto' FROM historic WHERE date >= '" + Var.uniqueDato + "' AND date < '" + Var.uniqueDato + "' + INTERVAL 1 DAY;";
                        mysqlCon.Open();
                        MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            var mega = reader.GetString("toto");
                            mysqlCon.Close();
                            return mega;
                            
                        }
                        else
                        {
                            return "0";
                        }
                        


                    }
                }
                else  //Si la date est dans le futur et que on considere que on a rien fait depuis jour présent
                {
                    using (MySqlConnection mysqlCon = new MySqlConnection(Var.Sqlmy))
                    {
                        string selectQuery = "SELECT COUNT(DU) AS 'DU' FROM Maint WHERE du <= '" + Var.uniqueDato + "';";
                        mysqlCon.Open();
                        MySqlCommand command = new MySqlCommand(selectQuery, mysqlCon);
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        var mega = reader.GetString("DU");
                        mysqlCon.Close();
                        return mega;

                    }
                    
                }

            }

        }
    }
}
