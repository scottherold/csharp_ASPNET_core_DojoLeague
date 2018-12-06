using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using DojoLeague.Models;
using Microsoft.Extensions.Options;

namespace DojoLeague.Factory
{
    public class DojoFactory
    {
        private MySqlOptions _options;
        public DojoFactory(IOptions<MySqlOptions> config)
        {
            _options = config.Value;
        }
        internal IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(_options.ConnectionString);
            }
        }
        // adds a new dojo
        public void AddNewDojo(Dojo dojo)
        {
            using (IDbConnection dbConnection = Connection)
            {
                // Queries the DB to insert a new Dojo
                string query = "INSERT INTO dojos (name, location, description, created_at) VALUES (@name, @location, @description, NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, dojo);
            }
        }
        // creates a list of dojos
        public List<Dojo> DojoList()
        {
            using (IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                    // Queries the DB for Dojo names to populate the table on Dojos.cshtml
                    var query = @"SELECT * FROM dojos";
                    dbConnection.Open();
                    return dbConnection.Query<Dojo>(query).ToList();
                }
            }
        }
        // Finds a dojo
        public Dojo DojoFind(int dojoID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                // sets a query to pull a Dojo based on the dojo_id provided by the controller.
                // this argument is dojoID and will pull from the View.
                string query = "SELECT * FROM dojos WHERE dojo_id = @ID";
                var arg = new {ID=dojoID};
                dbConnection.Open();
                var result = dbConnection.Query<Dojo>(query, arg);
                return result.FirstOrDefault();
            }
        }
        // removes a ninja from a dojo
        public void Banish(int ninjaID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                // Queries the DB to update the dojo_id of a ninja in the 
                // current dojo to null
                string query = "UPDATE ninjas SET dojo_id = NULL WHERE ninja_id = @NinjaID";
                var arg = new {NinjaID=ninjaID};
                dbConnection.Open();
                dbConnection.Execute(query, arg);
            }
        }
        // adds a ninja to a dojo
        public void Recruit(int dojoID, int ninjaID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                // Queries the DB to update the dojo_id of a rogue ninja to
                // the current dojo_id
                string query = "UPDATE ninjas SET dojo_id = @DojoID WHERE ninja_id = @NinjaID";
                var args = new {DojoID=dojoID, NinjaID=ninjaID};
                dbConnection.Open();
                dbConnection.Execute(query, args);
            }
        }
    }
}