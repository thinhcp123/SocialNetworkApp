using SocialNetworkApp.Persistence;

namespace SocialNetworkApp.Api.Controllers;

public class ActivitiesController:BaseApiController
{
    private readonly DataContext _context;

    public ActivitiesController(DataContext context)
    {
        _context = context;
    }
}