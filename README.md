# A Guide to the Backend API
The backend uses a library called ASP.NET it lets you write web services. This code will run to expose API endpoints which the Maui side (frontend will call)

## Folders
- Services: a middleman for anything you need.
- Data/ Migrations: See [Database Usage](DatabaseUsage.md)
- Controllers: this the code that will be exposed to maui
- Properties: this is from ASP, just settings so ingore this.
- The `.http` file is for testing your enpoints but you can do this in the UI

## Structure 
### Controllers
```cs
// A Class is marked as a controller
[ApiController]
[Route("api/v1/[controller]")]
public class yourController : ControllerBase
{
    protected readonly YourService _service;

    public yourController(YourService service)
    {
      _service = service;
    }

    [HttpGet]
    public async Task<List<Object>> getAllCards()
    {
        return _service.GetCards();
    }
}
```
| This is the basic structure of a controller.
- The `[Route("api/v1/[controller]")]` creates a route for this controller. We called it `yourController`so the URL will be `/api/v1/your`
- Next we specify which service this will use (if you have one)
- In the constructor we set the service (dependency injection)
- Next we define what type of route we use here we made a get route.

### Services
A Service is a way to separate concerns, this way we can remove database queries from the controller and delegate that to a service. 
```cs
using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Services
{
    public class myService : BaseRepository
    {
        public myService(DataContext ctx) : base(ctx)
        {

        }

        public async Task<IEnumerable<Table>> GetCards()
        {
            return await _context.Cards.ToListAsync();
        }
    }
}
```
- Here we specify a service, this inherits from BaseRepository which injects the database context into it (See [Database Usage](DatabaseUsage.md))
- This will contain all the functions which query the database for you to call from within the controller.

Don't worry about anything else right now. When doing your own code you will need to add a service and controller.
  
