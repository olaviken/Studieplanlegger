using Microsoft.IdentityModel.Tokens;
using Npgsql;

namespace Studieplanlegger.Components.DatabaseConnection
{
    

    public class DatabaseConnection
    {
        

        public void PostgresKontakt(String DatabaseLink)
        {
            NpgsqlConnection kontakt = new NpgsqlConnection(DatabaseLink);
            kontakt.Open();
        }
    }
}
