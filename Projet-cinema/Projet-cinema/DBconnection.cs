using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class DBconnection
    {
        SQLiteConnection sqliteConn;
        public DBconnection()
        {
            /* if (File.Exists("dbCinema.db"))
             {
                 File.Delete("dbCinema.db");
             }*/
            // Créer une nouvelle connexion de la base de donnée

            if (File.Exists("dbCinema.db"))
            {
                sqliteConn.Open();

            }
            else
            {

                sqliteConn = new SQLiteConnection("Data Source=dbCinema.db; Version=3; Compress=True;");
                // Ouvrir la connexion
                sqliteConn.Open();

            }
            CreateActors();
            CreateProducers();
            CreateFilms();
            CreateFilmsActors();



        }
        public void CreateActors()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS actors (id INTEGER PRIMARY KEY AUTOINCREMENT, firstname VARCHAR(45) NOT NULL, lastname VARCHAR(50) NOT NULL)";
            
            //Affectation de la propriété CommandText avec la variable createSQL et foreign key
            cmd.CommandText = createSql ;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

        }
        public void CreateFilmsActors()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS filmsActors (id INTEGER PRIMARY KEY AUTOINCREMENT, actors_id INT, films_id INT)";
            string foreignKey1 = "ALTER TABLE filmsActors ADD  CONSTRAINT FK_filmsActors_actors FOREIGN KEY(actors_id) REFERENCES actors(id)";
            string foreignKey2 = "ALTER TABLE filmsActors ADD  CONSTRAINT FK_filmsActors_films FOREIGN KEY(films_id) REFERENCES films(id)";
            //Affectation de la propriété CommandText avec la variable createSQL et foreign key
            cmd.CommandText = createSql + foreignKey1 + foreignKey2;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

        }
        public void CreateProducers()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS producers (id INTEGER PRIMARY KEY AUTOINCREMENT, firstname VARCHAR(45) NOT NULL, lastname VARCHAR(50) NOT NULL)";

            //Affectation de la propriété CommandText avec la variable createSQL et foreign key
            cmd.CommandText = createSql ;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

        }
        public void CreateFilms()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS films (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(60) NOT NULL, description VARCHAR(400),producers_id INT)";
            string foreignKey = "ALTER TABLE films ADD  CONSTRAINT FK_films_producers FOREIGN KEY(producers_id) REFERENCES producers(id)";
            //Affectation de la propriété CommandText avec la variable createSQL et foreign key
            cmd.CommandText = createSql + foreignKey;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

        }

        public long AddFilm(string name,string description,int producers_id)
        {
            string sql = "insert into films (name,description,producers_id) values (" + name + ", " + description + "," + producers_id + ")";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
          
            //GetProducer
            command.ExecuteNonQuery();
            return sqliteConn.LastInsertRowId;
        }
       
        public void RemoveFilms()
        {
            string sql = "DELETE FROM films";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            command.ExecuteNonQuery();

            sql = "UPDATE SQLITE_SEQUENCE SET SEQ = 0 WHERE NAME = 'films';";
            command = new SQLiteCommand(sql, sqliteConn);
            command.ExecuteNonQuery();
        }

        public string GetFilmsName(int id)
        {
            string sql = "select firstname,lastname from films where id = " + id;
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            SQLiteDataReader reader = command.ExecuteReader();
            string name = "";
            while (reader.Read())
            {
                name = reader["firstname" + " " + "lastname"].ToString();
            }
            return name;
        }
        public List<string> GetListFilms()
        {
            string sql = "select name from films";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            SQLiteDataReader reader = command.ExecuteReader();
            List<string> lstFilmsName = new List<string>();
            while (reader.Read())
            {
                lstFilmsName.Add(reader["name"].ToString());
            }
            return lstFilmsName;
        }

    }
}
