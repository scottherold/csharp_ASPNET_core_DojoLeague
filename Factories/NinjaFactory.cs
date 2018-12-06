using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using DojoLeague.Models;
using Microsoft.Extensions.Options;

namespace DojoLeague.Factory
{
    public class NinjaFactory
    {
        private MySqlOptions _options;
        public NinjaFactory(IOptions<MySqlOptions> config)
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
        public void AddNewNinja(Ninja ninja)
        {
            using (IDbConnection dbConnection = Connection)
            {
                // Queries the DB to insert a new Ninja
                string query = "INSERT INTO ninjas (name, level, description, dojo_id, created_at) VALUES (@name, @level, @description, @dojo_id, NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, ninja);
            }
        }
        public List<Ninja> NinjaWithDojos()
        {
            using (IDbConnection dbConnection = Connection)
            {
                // Queries the DB for Ninjas and Dojos for the table on Index.cshtml
                var query = @"SELECT * FROM ninjas LEFT JOIN dojos ON ninjas.dojo_id=dojos.dojo_id";
                dbConnection.Open();

                List<Ninja> ninjaList = dbConnection.Query<Ninja, Dojo, Ninja>(query, (ninja, dojo) => { ninja.dojo = dojo; return ninja; },splitOn: "dojo_id").ToList();
                return ninjaList;
            }
        }
        public Ninja NinjaFind(int ninjaID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                // sets a query to pull a Ninja based on the ninja_id provided by the controller.
                // this argument is ninjaID and will pull from the View.
                string query = "SELECT * FROM ninjas LEFT JOIN dojos ON ninjas.dojo_id=dojos.dojo_id WHERE ninjas.ninja_id=@ID";
                var arg = new {ID=ninjaID};
                dbConnection.Open();
                var result = dbConnection.Query<Ninja, Dojo, Ninja>(query, (ninja, dojo) => { ninja.dojo = dojo; return ninja; }, arg ,splitOn: "dojo_id");
                return result.FirstOrDefault();
            }
        }
        public List<Ninja> FindNinjasInDojo(int dojoID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                // Queries the DB for Ninjas with a specific dojo
                string query = "SELECT * FROM ninjas JOIN dojos ON ninjas.dojo_id=dojos.dojo_id WHERE ninjas.dojo_id=@ID";
                var arg = new {ID=dojoID};
                dbConnection.Open();

                List<Ninja> ninjaDojoList = dbConnection.Query<Ninja, Dojo, Ninja>(query, (ninja, dojo) => { ninja.dojo = dojo; return ninja; }, arg ,splitOn: "dojo_id").ToList();
                return ninjaDojoList;
            }
        }
        public List<Ninja> FindRogueNinjas()
        {
            using (IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                    // Queries the DB for ninjas without a dojo
                    var query = @"SELECT * FROM ninjas WHERE dojo_id IS NULL";
                    dbConnection.Open();
                    return dbConnection.Query<Ninja>(query).ToList();
                }
            }
        }
    }
}