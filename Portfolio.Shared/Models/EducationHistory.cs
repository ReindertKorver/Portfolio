using System.Text.Json.Serialization;

namespace Portfolio.Shared.Models
{
    public class EducationHistory
    {
        public string Course { get; set; }
        public string OrganisationName { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public bool Current { get; set; }
    }
}