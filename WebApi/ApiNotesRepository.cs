using SQLite;

namespace WebApi;

public class ApiNotesRepository
{
    private string _dbPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Onlinetodos.db3");

    
}
