using Portfolio.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Portfolio.Shared.Services
{
    public class ProjectService
    {
        private List<Project> ListProjects { get; set; } = new List<Project>();
        private DateTime DateRequested { get; set; }

        public async Task<List<Project>> GetProjects()
        {
            if (DateRequested != DateTime.MinValue && DateTime.UtcNow.Subtract(DateRequested).TotalMinutes < 10 && ListProjects != null && ListProjects.Any())
            {
                return ListProjects ?? new List<Project>();
            }
            DateRequested = DateTime.UtcNow;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            var res = await client.GetAsync("https://api.github.com/users/reindertkorver/repos");
            var res1 = await res.Content.ReadAsStringAsync();
            var projects = JsonSerializer.Deserialize<List<Project>>(res1);
            if (projects == null)
                return new List<Project>();
            ListProjects = projects.Where(p => !p.Fork).OrderByDescending(r => r.Created).ToList();
            return ListProjects;
        }
    }
}