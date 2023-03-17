namespace SimpleTracker.Web.Models;

public class SimpleTrackerViewModel
{
    public IEnumerable<ModelClient>? Clients { get; set; }
    public IEnumerable<Employee>? Employees { get; set; }
    public IEnumerable<History>? Histories { get; set; }
    public IEnumerable<Contract>? Contracts { get; set; }

    public bool contractActive = false;
    public bool clientActive = false;
    public bool employeeActive = false;
    public bool historyActive = false;
}
