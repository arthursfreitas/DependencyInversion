using DependencyInversion;

class PasswordRecovery
{
    private readonly IDatabaseConnection databaseConnection;
    //Dependency Injection
    public PasswordRecovery(IDatabaseConnection _connection)
    {
        databaseConnection = _connection;
    }

}