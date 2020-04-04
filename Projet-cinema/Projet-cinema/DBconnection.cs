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
            /* ca ne marche pas 
            if (File.Exists("dbCinema2.db"))
            {
                
                File.Delete("dbCinema2.db");
            }
            // Create a new database connection:
            sqliteConn = new SQLiteConnection("Data Source=dbCinema2.db; Version=3; Compress=True;");
            // Open the connection:
            sqliteConn.Open();*/


           sqliteConn = new SQLiteConnection("Data Source=C:/Users/imane/source/repos/Projet_gestion_cinema/Projet-cinema/dbCinema.db; Version=3; Compress=True;");
            // Ouvrir la connexion
            sqliteConn.Open();

            
            CreateProducers();
            CreateFilms();
            //CreateFilmsActors();
            CreateCinema();
            CreateRooms();
            CreateProducers();
            CreateFilms();
            CreateProjections();
            CreateActors();
            CreateFilms_has_Actors();
            AddCinema();
             //AddRooms();
            //AddProducers();
            //AddActors();
            //AddCinema("Pathé", "Lundi-Dimane 10h-00h", "Rue du Port-Franc 16", "Lausanne", "1003");
            //sqliteConn.Close();

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
            string createSql = "CREATE TABLE IF NOT EXISTS projections (id INTEGER PRIMARY KEY AUTOINCREMENT, ProjectionDate VARCHAR(100) NOT NULL,DueDate VARCHAR(100) NOT NULL, Quality VARCHAR(15) NULL, Price DECIMAL(5,2) NULL,Rooms_id INT NOT NULL,Films_id INT NOT NULL,FOREIGN KEY (Rooms_id)REFERENCES Rooms (id),FOREIGN KEY (Films_id)REFERENCES Films (id))";

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
        public long AddActors(string fName, string lName)
        {
            

            string sql1 = "select * from actors where firstname = '" + fName + "' and lastname = '" + lName + "'";
            SQLiteCommand command1 = new SQLiteCommand(sql1, sqliteConn);
            SQLiteDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                string id = reader["id"].ToString();
                string sql2 = "insert into Films_has_Actors(films_id, Actors_id) values((SELECT max(id) from films),'" + id + "')";
                SQLiteCommand command2 = new SQLiteCommand(sql2, sqliteConn);
                command2.ExecuteNonQuery();

            }
            else
            {
                string sql2 = "insert into actors (firstname,lastname) values ('" + fName + "','" + lName + "')";
                SQLiteCommand command2 = new SQLiteCommand(sql2, sqliteConn);
                command2.ExecuteNonQuery();
                string sql3 = "insert into Films_has_Actors(films_id, Actors_id) values((SELECT max(id) from films),(SELECT max(id) FROM actors))";
                SQLiteCommand command3 = new SQLiteCommand(sql3, sqliteConn);
                command3.ExecuteNonQuery();

            }



            return sqliteConn.LastInsertRowId;
        }
        public void updateActor(string fName, string lName, string idFilm)
        {
            string sql1 = "select * from actors where firstname = '" + fName + "' and lastname = '" + lName + "'";
            SQLiteCommand command1 = new SQLiteCommand(sql1, sqliteConn);
            SQLiteDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine("Actor exist");
                string id = reader["id"].ToString();
                string sql2 = "update Films_has_Actors set Actors_id = '" + id + "' where films_id = '" + idFilm + "'";
                SQLiteCommand command2 = new SQLiteCommand(sql2, sqliteConn);
                command2.ExecuteNonQuery();

            }
            else
            {
                Console.WriteLine("Actor don't exist");
                string sql2 = "insert into actors (firstname,lastname) values ('" + fName + "','" + lName + "')";
                SQLiteCommand command2 = new SQLiteCommand(sql2, sqliteConn);
                command2.ExecuteNonQuery();
                string sql3 = "update Films_has_Actors set Actors_id = (SELECT max(id) FROM actors) where films_id = '" + idFilm + "'";

                SQLiteCommand command3 = new SQLiteCommand(sql3, sqliteConn);
                command3.ExecuteNonQuery();

            }
        }

        public long AddFilm(string name,string description,string producersFName, string producersLName,string actorsFName, string actorsLName)
        {

            string sql1 = "select * from producers where firstname = '" + producersFName + "' and lastname = '" + producersLName + "'";
            SQLiteCommand command1 = new SQLiteCommand(sql1, sqliteConn);
            SQLiteDataReader reader = command1.ExecuteReader();
            if (reader.Read())  // recuperer au moins une ligne 
            {
                string id = reader["id"].ToString();

                string sql3 = "insert into films(name, description, producers_id) values('" + name + "','" + description + "' , '" + id + "')";
                SQLiteCommand command3 = new SQLiteCommand(sql3, sqliteConn);
                command3.ExecuteNonQuery();
            }
            else
            {
                string sql2 = "INSERT into producers(firstname, lastname) values('" + producersFName + "','" + producersLName + "')";
                SQLiteCommand command2 = new SQLiteCommand(sql2, sqliteConn);
                command2.ExecuteNonQuery();

                string sql3 = "insert into films(name, description, producers_id) values('" + name + "','" + description + "' ,(select max(id) from producers))";
                SQLiteCommand command3 = new SQLiteCommand(sql3, sqliteConn);
                command3.ExecuteNonQuery();

            }
            AddActors(actorsFName, actorsLName);





            return sqliteConn.LastInsertRowId;
        }

        // A modifier entierement 
        public void UpdateFilm(string idFilm, string name, string description, string producersFName, string producersLName, string actorsFName, string actorsLName)
        {

            string sql1 = "select * from producers where firstname = '" + producersFName + "' and lastname = '" + producersLName + "'";
            SQLiteCommand command1 = new SQLiteCommand(sql1, sqliteConn);
            SQLiteDataReader reader = command1.ExecuteReader();
            if (reader.Read())  // recuperer au moins une ligne 
            {
                string id = reader["id"].ToString();

                string sql3 = "update films set name='" + name + "', description='" + description + "' ,producers_id='" + id + "' where id='" + idFilm + "'";
                SQLiteCommand command3 = new SQLiteCommand(sql3, sqliteConn);
                command3.ExecuteNonQuery();
            }
            else
            {
                string sql2 = "INSERT into producers(firstname, lastname) values('" + producersFName + "','" + producersLName + "')";
                SQLiteCommand command2 = new SQLiteCommand(sql2, sqliteConn);
                command2.ExecuteNonQuery();

                string sql3 = "update films set name='" + name + "', description='" + description + "' ,producers_id=(select max(id) from producers) where id='" + idFilm + "'";
                SQLiteCommand command3 = new SQLiteCommand(sql3, sqliteConn);
                command3.ExecuteNonQuery();

            }


           

        }

        public void RemoveFilms(string FilmId)
        {
            string sql = "DELETE FROM films where id like '"+ FilmId + "'";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            command.ExecuteNonQuery();

            
        }
       

        public SQLiteDataReader GetFilms()
        {

            string sql = "select F.id, F.name,P.firstName,P.lastName, A.firstName, A.lastName, F.Description from films F, producers P, actors A, Films_has_Actors FA where F.Producers_id = P.id and F.id = FA.films_id and A.id = FA.Actors_id";
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

            string sql = "select P.id, F.name,P.quality,P.projectionDate, P.dueDate, R.name from films F, projections P, rooms R where F.id = P.Films_id and R.id = P.Rooms_id";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            SQLiteDataReader reader = command.ExecuteReader();

            return reader;
        }


        public long AddProjection(string name, string quality, DateTime projectionDate, DateTime dueDate, string room)
        {




            string sql1 = "INSERT into projections(ProjectionDate, DueDate,quality,Rooms_id,films_id) values('" + projectionDate + "','" + dueDate + "','" + quality + "' ,(select id from rooms where name like '" + room + "'),(select id from films where name like '" + name + "'))";
            

            SQLiteCommand command1 = new SQLiteCommand(sql1, sqliteConn);
            command1.ExecuteNonQuery();


            return sqliteConn.LastInsertRowId;
        }
        public void RemoveProjections(string id)
        {
            string sql = "DELETE FROM projections where id = '" + id + "'";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            command.ExecuteNonQuery();


        }
        public void UpdateProj(string idProj, string name, string quality, DateTime projectionDate, DateTime dueDate, string room)
        {

            string sql1 = "UPDATE projections set ProjectionDate = '" + projectionDate + "', DueDate='" + dueDate + "',quality='" + quality + "',Rooms_id=(select id from rooms where name like '" + room + "'),films_id=(select id from films where name like '" + name + "') where id='" + idProj + "'";
            //string sql1 = "INSERT into projections(ProjectionDate, DueDate,quality,Rooms_id,films_id) values('','','' ,(select id from rooms where name like '" + room + "'),(select id from films where name like '" + name + "'))";

            SQLiteCommand command1 = new SQLiteCommand(sql1, sqliteConn);
            command1.ExecuteNonQuery();

        }

        public void RemoveProjectionsAuto()
        {
            string sql = "delete from projections where strftime('%d-%m-%Y %H:%M:%S','now') > DueDate";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            command.ExecuteNonQuery();

        }
        


    }
}
