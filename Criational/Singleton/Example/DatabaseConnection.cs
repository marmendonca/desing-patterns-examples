namespace DesingPatternsExamples.Criational.Singleton;

public class DatabaseConnection
{
    private static DatabaseConnection _instance;

    internal string ConnectionString { get; private set; }

    private DatabaseConnection()
    {
        ConnectionString = "testeconnection";
    }

    public static DatabaseConnection GetInstance()
    {
        if (_instance is null)
            _instance = new DatabaseConnection();

        return _instance;
    }

    public void ExecuteQuery(string commandSql)
    {
        Console.WriteLine($"Executing query {commandSql} using connection: {ConnectionString}");
    }
}