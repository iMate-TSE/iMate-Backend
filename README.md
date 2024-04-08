# A Guide to the Backend API
The backend uses a library called ASP.NET it lets you write web services. This code will run to expose API endpoints which the Maui side (frontend)

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

## Connecting to the Frontend
- You may notice the new HTTP Service on the maui side.
- This connects to the api, it passed into a ViewModelBase
- This will let you inject the http service into your viewmodels.

**Using this**
1. You will need to edit your view model to inherit this new ViewModelBase
```cs
    public partial class DeckViewModel : ViewModelBase
    {
        public ObservableCollection<Card> Cards { get; } = new ObservableCollection<Card>();

        [ObservableProperty] 
        private bool _hasCards;

        // inject it into the constructor 
        public DeckViewModel(IHttpService httpService) : base(httpService)
        {
            Cards = GetCards();
            HasCards = !(Cards.Count > 0);
        }
    }
```

2. From here you have the ability to call the api: 
*GetPizzas() is currently undefined it will be defined later don't get confused*
```cs
        public async void GetData()
        {
            List<Product> data = await HttpService.GetPizzas();
        }
```

3. Now need to use the command architecture to define a command which will represent this function.

```cs
        public DeckViewModel(IHttpService httpService) : base(httpService)
        {
            Cards = GetCards();
            HasCards = !(Cards.Count > 0);
            // GetData wsa defined above
            GetDataCommand = new Command(GetData);
        }

        public ICommand GetDataCommand { get; }
```
4. Commands allow you to use these things in the page itself:
```xml
<Button Text="Click this button" Command="{Binding GetPizzasCommand}" />
```

### Actual API Calls 
This will happen inside the HTTPService Class, we will define the GetPizzas method
```cs
// task tells C# that the result might be slow to come back (as it will with a database)
public async Task<List<Product>> GetPizzas() {
    try {
        // so we await and scope a request in this case to the /pizza route
        using HttpResponseMessage response = await _httpClient.GetAsync("pizza");

        // check to make sure we got the 200 status code
        response.EnsureSuccessStatusCode();

        // if we did we can read the response 
        var jsonResponse = await (response.Content.ReadFromJsonAsync<List<Product>>());

        // handle returning the response
        if (jsonResponse != null) {
            return jsonResponse;
        } else {
            return new List<Product>();
         }
    } catch (Exception ex) {
        // if anything goes wrong just return an empty list
        Console.WriteLine(ex.Message);
        return new List<Product>();
    }
}
```
If you are not using a Get request (i.e you didn't put `[HttpGet]` on your controller you need to use a different method such as PostAsync.
See the following: https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient
