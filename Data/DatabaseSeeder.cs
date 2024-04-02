namespace iMate.API.Data;
using iMate.API.Data.Models;
public class DatabaseSeeder(DataContext dbContext)
{
    private readonly DataContext _dbContext = dbContext;

    public void Initialise()
    {
        //dbContext.SaveChanges();
    }
}