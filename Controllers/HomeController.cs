using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleTracker.Web.Models;
using Newtonsoft.Json;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Api;

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

    //begin client API CRUD
    [HttpGet]
    public IActionResult DeleteClient(int? id)
    {
        Configuration.Default.BasePath = "http://localhost:8080";
        var apiInstance = new DefaultApi(Configuration.Default);
        apiInstance.ClientsClientIdDelete((int)id);
        return RedirectToAction(nameof(SimpleTracker));
    }

    [HttpGet]
    public IActionResult EditClient(int? id)
    {
        Configuration.Default.BasePath = "http://localhost:8080";
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
        Configuration.Default.BasePath = "http://localhost:8080";
        var apiInstance = new DefaultApi(Configuration.Default);
        ClientsPostRequest cpr = new ClientsPostRequest(mc.Name, mc.Url);
        apiInstance.ClientsPost(cpr);
        return RedirectToAction(nameof(SimpleTracker));
    }
   
    [HttpPost]
    public IActionResult EditClient(ModelClient mc)
    {
        Configuration.Default.BasePath = "http://localhost:8080";
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
        Configuration.Default.BasePath = "http://localhost:8080";
        var apiInstance = new DefaultApi(Configuration.Default);
        apiInstance.EmployeesEmployeeIdDelete((int)id);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=employee"));
    }

    [HttpGet]
    public IActionResult EditEmployee(int? id)
    {
        Configuration.Default.BasePath = "http://localhost:8080";
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
        Configuration.Default.BasePath = "http://localhost:8080";
        var apiInstance = new DefaultApi(Configuration.Default);
        EmployeesPostRequest epr = new EmployeesPostRequest(emp.Name, emp.Github);
        apiInstance.EmployeesPost(epr);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=employee"));
    }
   
    [HttpPost]
    public IActionResult EditEmployee(Employee emp)
    {
        Configuration.Default.BasePath = "http://localhost:8080";
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
        Configuration.Default.BasePath = "http://localhost:8080";
        var apiInstance = new DefaultApi(Configuration.Default);
        apiInstance.ContractsContractIdDelete((int)id);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=contract"));
    }

    [HttpGet]
    public IActionResult EditContract(int? id)
    {
        Configuration.Default.BasePath = "http://localhost:8080";
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
        Configuration.Default.BasePath = "http://localhost:8080";
        var apiInstance = new DefaultApi(Configuration.Default);
        ContractPatch cp = new ContractPatch(ctr.ClientId, ctr.Type, ctr.StartDate, ctr.EndDate, ctr.Tech[0].Split(',').ToList());
        apiInstance.ContractsPost(cp);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=contract"));
    }
   
    [HttpPost]
    public IActionResult EditContract(Contract ctr)
    {
        Configuration.Default.BasePath = "http://localhost:8080";
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
        Configuration.Default.BasePath = "http://localhost:8080";
        var apiInstance = new DefaultApi(Configuration.Default);
        apiInstance.HistoryHistoryIdDelete((int)id);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=history"));
    }

    [HttpGet]
    public IActionResult EditHistory(int? id)
    {
        Configuration.Default.BasePath = "http://localhost:8080";
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
        Configuration.Default.BasePath = "http://localhost:8080";
        var apiInstance = new DefaultApi(Configuration.Default);
        HistoryPatch hp = new HistoryPatch(hst.ClientId, hst.ContractId, hst.EmployeeId, hst.Role);
        apiInstance.HistoryPost(hp);
        return Redirect(String.Format("{0}?{1}", Url.RouteUrl(new { controller = "Home", action = "SimpleTracker" }), "methodType=history"));
    }
    //end history API CRUD

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

        RestSharp.RestResponse employeeResponse = (RestSharp.RestResponse)cl.CallApi("/employees", RestSharp.Method.GET, new List<KeyValuePair<string, string>>(), null, headers, new Dictionary<string,string>(), new Dictionary<string, RestSharp.FileParameter>(), new Dictionary<string,string>(), "application/json");
        var allEmployees = employeeResponse.Content.ToString() != null
            ? JsonConvert.DeserializeObject<List<Employee>>(employeeResponse.Content.ToString()!)
            : default(List<Employee>);
        stvm.Employees = allEmployees!;

        RestSharp.RestResponse contractResponse = (RestSharp.RestResponse)cl.CallApi("/contracts", RestSharp.Method.GET, new List<KeyValuePair<string, string>>(), null, headers, new Dictionary<string,string>(), new Dictionary<string, RestSharp.FileParameter>(), new Dictionary<string,string>(), "application/json");
        var allContracts = contractResponse.Content.ToString() != null
            ? JsonConvert.DeserializeObject<List<Contract>>(contractResponse.Content.ToString()!)
            : default(List<Contract>);
        stvm.Contracts = allContracts!;

        RestSharp.RestResponse historyResponse = (RestSharp.RestResponse)cl.CallApi("/history", RestSharp.Method.GET, new List<KeyValuePair<string, string>>(), null, headers, new Dictionary<string,string>(), new Dictionary<string, RestSharp.FileParameter>(), new Dictionary<string,string>(), "application/json");
        var allHistory = historyResponse.Content.ToString() != null
            ? JsonConvert.DeserializeObject<List<History>>(historyResponse.Content.ToString()!)
            : default(List<History>);
        stvm.Histories = allHistory!;

        string apiMethodType = this.ControllerContext.HttpContext.Request.Query["methodType"].ToString();

        if(apiMethodType.Equals("employee"))
        {
            stvm.employeeActive = true;
        }
        else if(apiMethodType.Equals("contract"))
        {
            stvm.contractActive = true;
        }
        else if(apiMethodType.Equals("history"))
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
