using System.Text.Json.Serialization;

namespace Portfolio.Shared.Models
{
    public class WorkHistory
    {
        public string Title { get; set; }

        public string Description { get; set; }
        public string CompanyName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}