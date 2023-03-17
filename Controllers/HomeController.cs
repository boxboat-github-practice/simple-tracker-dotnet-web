using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleTracker.Web.Models;
using Newtonsoft.Json;

namespace SimpleTracker.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult SimpleTracker()
    {
        SimpleTrackerViewModel stvm = new SimpleTrackerViewModel();
        SimpleTracker.Web.Client.ApiClient cl = new Client.ApiClient("http://localhost:8080");
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("accept", "text/plain");
        RestSharp.RestResponse clientResponse = (RestSharp.RestResponse)cl.CallApi("/clients", RestSharp.Method.GET, new List<KeyValuePair<string, string>>(), null, headers, new Dictionary<string,string>(), new Dictionary<string, RestSharp.FileParameter>(), new Dictionary<string,string>(), "application/json");
        var allClients = clientResponse.Content.ToString() != null
            ? JsonConvert.DeserializeObject<List<ModelClient>>(clientResponse.Content.ToString()!)
            : default(List<ModelClient>);
        
        
        stvm.Clients = allClients!;
        return View(stvm);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
