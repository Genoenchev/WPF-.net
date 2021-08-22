using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            Console.WriteLine("Getting DB Connection...");

            IDbManager db = new SqliteDbManager();
            DbConnection conn = db.getConnection();

            if(conn == null)
            {
                Console.WriteLine("Failed to get connection");
            }
            // First approach using LINQ concat
            var allLists = GetCountryPopulations().Concat(SecondList())
                                                  .ToList();
            // Second approach using Enumerable.Union
            List<int> ulist = GetCountryPopulations().Union(SecondList()).ToList();
        }

        static void SecondList() 
        {
            cn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT CountryName,SUM(city.population) AS Population FROM city INNER JOIN country on city.countryId = countryId group by country", cn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Countries> country = new List<Countries>();

            while (reader.Read())
            {
                Country c = new Country();
                c.ID = (string)reader["ID"];
                c.Population = (string)reader["Population"];
                
                country.Add(c);
            }

        }
    }
}
