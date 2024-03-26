namespace iMate.API.Data
{
    public abstract class BaseRepository
    {
        protected readonly DataContext _context;

        // Repository Pattern for Dependency Injection

        protected BaseRepository(DataContext context)
        {
            _context = context;
        }
    }
}
