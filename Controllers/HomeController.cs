using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleTracker.Web.Models;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Api;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SimpleTracker.Web.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;
    private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _webHostEnvironment;
    private readonly IConfiguration? _config;
    SimpleTrackerViewModel? stvm;

    public HomeController(ILogger<HomeController> logger, Microsoft.AspNetCore.Hosting.IWebHostEnvironment webHostEnvironment, IConfiguration config)
	{
        _logger = logger;
        stvm = new SimpleTrackerViewModel();
		_webHostEnvironment = webHostEnvironment;
        _config = config;
       Configuration.Default.BasePath = _config.GetValue<string>("ApiUrl");

	}

    public IActionResult Index()
    {
        stvm = new SimpleTrackerViewModel();

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    //begin client API CRUD
    [HttpGet]
    public IActionResult DeleteClient(int? id)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        apiInstance.ClientsClientIdDelete((int)id);
        return RedirectToAction(nameof(SimpleTracker));
    }

    [HttpGet]
    public IActionResult EditClient(int? id)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        ModelClient mc = apiInstance.ClientsClientIdGet((int)id);
        return View(mc);
    }


    [HttpGet]
    public IActionResult CreateClient()
    {
       return View();
    }

    [HttpPost]
    public IActionResult CreateClient(ModelClient mc)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        ClientsPostRequest cpr = new ClientsPostRequest(mc.Name, mc.Url);
        apiInstance.ClientsPost(cpr);
        return RedirectToAction(nameof(SimpleTracker));
    }

    [HttpPost]
    public IActionResult EditClient(ModelClient mc)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        ClientsPostRequest cpr = new ClientsPostRequest(mc.Name, mc.Url);
        apiInstance.ClientsClientIdPut(mc.Id, cpr);
        return RedirectToAction(nameof(SimpleTracker));
    }
    //end client API CRUD

    //begin employee API CRUD
    [HttpGet]
    public IActionResult DeleteEmployee(int? id)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        apiInstance.EmployeesEmployeeIdDelete((int)id);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=employee"));
    }

    [HttpGet]
    public IActionResult EditEmployee(int? id)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        Employee emp = apiInstance.EmployeesEmployeeIdGet((int)id);
        return View(emp);
    }

    [HttpGet]
    public IActionResult CreateEmployee()
    {
       return View();
    }

    [HttpPost]
    public IActionResult CreateEmployee(Employee emp)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        EmployeesPostRequest epr = new EmployeesPostRequest(emp.Name, emp.Github);
        apiInstance.EmployeesPost(epr);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=employee"));
    }

    [HttpPost]
    public IActionResult EditEmployee(Employee emp)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        EmployeesPostRequest epr = new EmployeesPostRequest(emp.Name, emp.Github);
        apiInstance.EmployeesEmployeeIdPut(emp.Id, epr);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=employee"));
    }
    //end employee API CRUD

    //begin contract API CRUD
    [HttpGet]
    public IActionResult DeleteContract(int? id)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        apiInstance.ContractsContractIdDelete((int)id);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=contract"));
    }

    [HttpGet]
    public IActionResult EditContract(int? id)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        Contract ctr = apiInstance.ContractsContractIdGet((int)id);
        return View(ctr);
    }

    [HttpGet]
    public IActionResult CreateContract()
    {
       return View();
    }

    [HttpPost]
    public IActionResult CreateContract(Contract ctr)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        ContractPatch cp = new ContractPatch(ctr.ClientId, ctr.Type, ctr.StartDate, ctr.EndDate, ctr.Tech[0].Split(',').ToArray<string>());
        apiInstance.ContractsPost(cp);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=contract"));
    }

    [HttpPost]
    public IActionResult EditContract(Contract ctr)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        ContractPatch cp = new ContractPatch(ctr.ClientId, ctr.Type, ctr.StartDate, ctr.EndDate, ctr.Tech);
        apiInstance.ContractsContractIdPut(ctr.Id, cp);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=contract"));
    }
    //end contract API CRUD


    //begin history API CRUD
    [HttpGet]
    public IActionResult DeleteHistory(int? id)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        apiInstance.HistoryHistoryIdDelete((int)id);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=history"));
    }

    [HttpGet]
    public IActionResult EditHistory(int? id)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        History hst = apiInstance.HistoryHistoryIdGet((int)id);
        return View(hst);
    }

    [HttpGet]
    public IActionResult CreateHistory()
    {
       return View();
    }

    [HttpPost]
    public IActionResult CreateHistory(History hst)
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        HistoryPatch hp = new HistoryPatch(hst.ClientId, hst.ContractId, hst.EmployeeId, hst.Role);
        apiInstance.HistoryPost(hp);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=history"));
    }
    //end history API CRUD

    public IActionResult SimpleTracker()
    {
        var apiInstance = new DefaultApi(Configuration.Default);
        stvm.Clients = apiInstance.ClientsGet();
        stvm.Employees = apiInstance.EmployeesGet();
        stvm.Contracts = apiInstance.ContractsGet();
        stvm.Histories = apiInstance.HistoryGet();

        string apiMethodType = this.ControllerContext.HttpContext.Request.Query["methodType"].ToString();

        if (apiMethodType.Equals("employee"))
        {
            stvm.employeeActive = true;
        }
        else if (apiMethodType.Equals("contract"))
        {
            stvm.contractActive = true;
        }
        else if (apiMethodType.Equals("history"))
        {
            stvm.historyActive = true;
        }
        else
        {
            stvm.clientActive = true;
        }

        return View(stvm);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
