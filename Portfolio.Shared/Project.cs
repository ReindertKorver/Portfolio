using System.Text.Json.Serialization;

namespace Portfolio.Shared
{
    public class Project
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        public string Image { get; set; }
        [JsonPropertyName("html_url")]

        public string Url { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime Created { get; set; }
        [JsonPropertyName("updated_at")]
        
        public DateTime Updated { get; set; }
        [JsonPropertyName("fork")]
        
        public bool Fork { get; set; }
    }
}