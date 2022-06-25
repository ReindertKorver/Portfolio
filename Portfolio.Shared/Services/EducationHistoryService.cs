using Portfolio.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared.Services
{
    public class EducationHistoryService
    {
        private List<EducationHistory> EducationHistory { get; set; } = new List<EducationHistory>()
        {
            new EducationHistory()
            {
                OrganisationName="Hoornbeeck College",
                Description = "",
                Course="(ICT) Applicatie & media ontwikkeling",
                StartDate = new DateTime(2016,8,1),
                EndDate= new DateTime(2019,8,1)
            },
            new EducationHistory()
            {
                OrganisationName="Hogeschool Rotterdam",
                Course="Informatica",
                Description = "Eerste stage 2de jaar.",
                StartDate = new DateTime(2019,8,1),
                EndDate= new DateTime(2023,8,1)
            },
        };

        public List<EducationHistory> GetEducationHistory()
        {
            return EducationHistory;
        }
    }
}