

namespace Project.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public string ReportType { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string GeneratedBy { get; set; }
    }
}
