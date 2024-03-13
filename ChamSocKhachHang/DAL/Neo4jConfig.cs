using ChamSocKhachHang.BLL;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChamSocKhachHang.DAL
{
    public static class Neo4jConfig
    {
        private static string uri = "neo4j+s://f0014f4d.databases.neo4j.io:7687";
        private static string user = "neo4j";
        private static string password = "hDh3tkzsIz1HPULpm1IikZ21ElftntdzgxA_NgZdcpg";
        private static IDriver driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));

        public static IResult QueryCypher(string query)
        {
            var session = driver.Session();
            var tx = session.BeginTransaction();
            return tx.Run(query);
        }

        public static void ExeuteWrite(string query)
        {
            try
            {
                var session = driver.Session();
                session.ExecuteWrite(tx => tx.Run(query));
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
