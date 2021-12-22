using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FavoriteRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace FavoriteRestaurants.Controllers
{
  public class RestaurantController : Controller
  {
    private readonly FavoriteRestaurantsContext _db;

    public RestaurantController(FavoriteRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.Include(Restaurant => Restaurant.Cuisine).ToList();
      return View(model);
    }
  }
}