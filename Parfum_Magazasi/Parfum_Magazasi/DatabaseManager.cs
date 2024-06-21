using MySql.Data.MySqlClient;

public static class DatabaseManager
{
    public static string connectionString = "server=localhost;user=tester;database=parfum_magaza;port=3306;password=Tester_74";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}
