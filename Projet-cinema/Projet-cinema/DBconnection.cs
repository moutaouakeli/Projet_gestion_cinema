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
           /* if (File.Exists("dbCinema.db"))
            {
                
                Console.WriteLine("OK");
            }
            else
            {
                
                Console.WriteLine("KO");
            }*/
            

            sqliteConn = new SQLiteConnection("Data Source=C:/Users/imane/source/repos/Projet_gestion_cinema/Projet-cinema/dbCinema.db; Version=3; Compress=True;");
            // Ouvrir la connexion
            sqliteConn.Open();

            // CreateActors();
            //CreateProducers();
            //CreateFilms();
            //CreateFilmsActors();
            CreateCinema();

           
        }
        

        public void CreateCinema()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS Cinemas (id INTEGER PRIMARY KEY AUTOINCREMENT,Name VARCHAR(45) NOT NULL,OpeningTime VARCHAR(200) NULL,Adresse VARCHAR(100) NULL, CP VARCHAR(6) NULL,Locality VARCHAR(50) NULL)";

            //Affectation de la propriété CommandText avec la variable createSQL 
            cmd.CommandText = createSql;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

        }
        public void CreateRooms()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS rooms (id INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(45) NOT NULL,Number INT NOT NULL,Capacity INT NOT NULL, Cinemas_id INT NOT NULL,FOREIGN KEY(Cinemas_id) REFERENCES Cinemas(id))";

            //Affectation de la propriété CommandText avec la variable createSQL 
            cmd.CommandText = createSql;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

        }

        public void CreateProducers()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS producers (id INTEGER PRIMARY KEY AUTOINCREMENT, FirstName VARCHAR(45) NOT NULL,LastName VARCHAR(50) NOT NULL)";

            //Affectation de la propriété CommandText avec la variable createSQL 
            cmd.CommandText = createSql;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

        }
        public void CreateFilms()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS films (id INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(60) NOT NULL,Description VARCHAR(400) NULL,Producers_id INT NOT NULL,FOREIGN KEY (Producers_id) REFERENCES Producers (id))";

            //Affectation de la propriété CommandText avec la variable createSQL 
            cmd.CommandText = createSql;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

        }
        public void CreateProjections()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS projections (id INTEGER PRIMARY KEY AUTOINCREMENT, ProjectionDate DATE NOT NULL,DueDate DATE NOT NULL, Quality VARCHAR(15) NULL, Price DECIMAL(5,2) NULL,Rooms_id INT NOT NULL,Films_id INT NOT NULL,FOREIGN KEY (Rooms_id)REFERENCES Rooms (id),FOREIGN KEY (Films_id)REFERENCES Films (id))";

            //Affectation de la propriété CommandText avec la variable createSQL 
            cmd.CommandText = createSql;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

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
        public void CreateFilms_has_Actors()
        {
            //Déclaration de la variable cmd, appel de la méthode publique CreateCommand
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            //Déclaration de la variable createSQL, y stocke la requête SQL
            string createSql = "CREATE TABLE IF NOT EXISTS Films_has_Actors (id INTEGER PRIMARY KEY AUTOINCREMENT, Actors_id INT NOT NULL,Films_id INT NOT NULL,FOREIGN KEY (Actors_id)REFERENCES Actors (id),FOREIGN KEY (Films_id)REFERENCES Films (id))";

            //Affectation de la propriété CommandText avec la variable createSQL et foreign key
            cmd.CommandText = createSql;

            //Appel la méthode ExecuteNonQuery qui exécute la requête
            cmd.ExecuteNonQuery();

        }

        /* public void CreateFilmsActors()
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

         }*/



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
            string sql = "select * from films";
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
