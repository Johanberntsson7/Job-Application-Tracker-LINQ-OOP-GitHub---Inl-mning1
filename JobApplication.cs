namespace Job_Application_Tracker_LINQ_OOP_GitHub___Inl_mning1;

public class JobApplication
{
    public string CompanyName { get; set; } = string.Empty;
    public string PositionTitle { get; set; } = string.Empty;
    public DateTime ApplicationDate { get; set; }
    public ApplicationStatus Status { get; set; }
    public DateTime ResponseDate { get; set; }

    public int GetDaysSinceApplied()
    {
        return (DateTime.Today - ApplicationDate).Days;
    }

    public string GetSummary()
    {
        return $"{CompanyName} - {PositionTitle} (Applied: {ApplicationDate:yyyy-MM-dd})";
    }
}   

