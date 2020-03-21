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

            
            //CreateProducers();
            //CreateFilms();
            //CreateFilmsActors();
            CreateCinema();
            CreateRooms();
            CreateProducers();
            CreateFilms();
            CreateProjections();
            CreateActors();
            CreateFilms_has_Actors();
            //AddCinema();
            // AddRooms();
            //AddProducers();
            //AddActors();
            //AddCinema("Pathé", "Lundi-Dimane 10h-00h", "Rue du Port-Franc 16", "Lausanne", "1003");


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
        public long AddCinema()
        {
            string sql = "insert into cinemas (name,openingTime,Adresse,locality,cp) values ('Bel-Air','Lundi-Dimanche 15h-22h','Place Bel-Air 6','Yverdon-les-Bains','1400') ";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);

            //GetProducer
            command.ExecuteNonQuery();



            return sqliteConn.LastInsertRowId;
        }
        public long AddRooms()
        {
            string sql = "insert into rooms (name,number,capacity,cinemas_id) values ('Chat',1,100,1);insert into rooms (name,number,capacity,cinemas_id) values ('Chien',2,100,3) ";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);

            //GetProducer
            command.ExecuteNonQuery();



            return sqliteConn.LastInsertRowId;
        }
        public long AddProducers()
        {
            string sql = "insert into producers (firstname,lastname) values ('James','Cameron');insert into producers (firstname,lastname) values ('Sam','Worthington') ";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);

            //GetProducer
            command.ExecuteNonQuery();



            return sqliteConn.LastInsertRowId;
        }
        public long AddActors()
        {
            string sql = "insert into actors (firstname,lastname) values ('Linda','Hamilton');insert into actors (firstname,lastname) values ('Suzy','Ami') ";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);

            //GetProducer
            command.ExecuteNonQuery();



            return sqliteConn.LastInsertRowId;
        }


        public long AddFilm(string name,string description,string producersName,string actorsName)
        {




            string sql1 = "INSERT into producers(firstname, lastname) values('" + producersName.Split(' ')[0] + "','" + producersName.Split(' ')[1] + "')";
            SQLiteCommand command1 = new SQLiteCommand(sql1, sqliteConn);
            command1.ExecuteNonQuery();

            

            string sql2 = "insert into films(name, description, producers_id) values('"+name+ "','" +description+"' ,(select max(id) from producers))";
            SQLiteCommand command2 = new SQLiteCommand(sql2, sqliteConn);
            command2.ExecuteNonQuery();

            string sql3 = "INSERT into actors(firstname, lastname) values('" + actorsName.Split(' ')[0] + "','" + actorsName.Split(' ')[1] + "')";
            SQLiteCommand command3 = new SQLiteCommand(sql3, sqliteConn);
            command3.ExecuteNonQuery();

            string sql4 = "insert into Films_has_Actors(films_id, Actors_id) values((SELECT max(id)from films),(SELECT max(id) FROM actors))";
            SQLiteCommand command4 = new SQLiteCommand(sql4, sqliteConn);
            command4.ExecuteNonQuery();
            

            return sqliteConn.LastInsertRowId;
        }
       
        public void RemoveFilms(string filmName)
        {
            string sql = "DELETE FROM films where name like '"+filmName+"'";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            command.ExecuteNonQuery();

            
        }
        public void UpdateFilms(string name, string description, string producersName, string actorsName)
        {
            
            AddFilm(name, description, producersName, actorsName);
            
        }

        public SQLiteDataReader GetFilms()
        {

            string sql = "select F.name,P.firstName,P.lastName, A.firstName, A.lastName, F.Description from films F, producers P, actors A, Films_has_Actors FA where F.Producers_id = P.id and F.id = FA.films_id and A.id = FA.Actors_id";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            SQLiteDataReader reader = command.ExecuteReader();
    
            return reader;
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
        public List<string> GetListRooms()
        {
            string sql = "select name from rooms";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            SQLiteDataReader reader = command.ExecuteReader();
            List<string> lstRoomsName = new List<string>();
            while (reader.Read())
            {
                lstRoomsName.Add(reader["name"].ToString());

            }
            return lstRoomsName;
        }

        /*-----------------------------------------------------------------------------------*/

        public SQLiteDataReader GetProjections()
        {

            string sql = "select F.name,P.quality,P.projectionDate, P.dueDate, R.name from films F, projections P, rooms R where F.id = P.id and R.id = P.id";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            SQLiteDataReader reader = command.ExecuteReader();

            return reader;
        }


        public long AddProjection(string name, string quality, DateTime projectionDate, DateTime dueDate, string room)
        {




            string sql1 = "INSERT into projections(projectionDate, dueDate,quality,Rooms_id,films_id) values('" + projectionDate + "','" + dueDate + "','" + quality +"' ,(select id from rooms where name like '" + room + "'),(select id from films where name like '" + name + "'))";
            SQLiteCommand command1 = new SQLiteCommand(sql1, sqliteConn);
            command1.ExecuteNonQuery();


            return sqliteConn.LastInsertRowId;
        }
        public void RemoveProjections(string filmName)
        {
            string sql = "DELETE FROM projections where films_id = (select id from films where name like '" + filmName + "')";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            command.ExecuteNonQuery();

            
        }
        public void UpdateProj(string name, string quality, DateTime projectionDate, DateTime dueDate, string room)
        {

            AddProjection(name, quality, projectionDate, dueDate, room);
            
        }

        public void RemoveProjectionsAuto()
        {
            string sql = "delete from projections where datetime('now','localtime') > DueDate;";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            command.ExecuteNonQuery();

        }
        


    }
}
