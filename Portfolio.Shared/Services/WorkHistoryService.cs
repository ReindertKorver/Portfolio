using Portfolio.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared.Services
{
    public class WorkHistoryService
    {
        private List<WorkHistory> EducationHistory { get; set; } = new List<WorkHistory>()
        {
            new WorkHistory()
            {
                CompanyName="Adlevo BV",
                Title= "Stagiair Software Developer",
                Description = "Eerste stage 2de jaar.",
                StartDate = new DateTime(2017,8,1),
                EndDate= new DateTime(2018,2,1)
            },
            new WorkHistory()
            {
                CompanyName="Adlevo BV",
                Title= "Software Developer",
                Description = "",
                StartDate = new DateTime(2018,2,1),
                EndDate= new DateTime(2018,8,1)
            },
            new WorkHistory()
            {
                CompanyName="Adlevo BV",
                Title= "Stagiair Software Developer",
                Description = "Tweede stage 3de jaar.",
                StartDate = new DateTime(2018,8,1),
                EndDate= new DateTime(2019,2,1)
            },
            new WorkHistory()
            {
                CompanyName="Altronic",
                Title= "Software Engineer",
                Description = "Ontwerp en ontwikkeling interne web applicatie.",
                StartDate = new DateTime(2020,7,1),
                EndDate= new DateTime(2021,2,1)
            },
            new WorkHistory()
            {
                CompanyName="Hogeschool Rotterdam",
                Title= "Peercoach",
                Description = "Het coachen van 1ste jaars studenten bij het vak Development.",
                StartDate = new DateTime(2020,7,1),
                EndDate= new DateTime(2021,2,1)
            },
            new WorkHistory()
            {
                CompanyName="Growteq",
                Title= "Stagiair .Net Developer",
                Description = "Ontwikkelen van onderandere een applicatie binnen de automotive branch.",
                StartDate = new DateTime(2021,9,1),
                EndDate= new DateTime(2022,2,1)
            },

            new WorkHistory()
            {
                CompanyName="Growteq",
                Title= "Junior .Net Developer",
                Description = "Ontwikkelen van verschillende applicaties.",
                StartDate = new DateTime(2021,12,1)
            }
        };

        public List<WorkHistory> GetWorkHistory()
        {
            return EducationHistory;
        }
    }
}