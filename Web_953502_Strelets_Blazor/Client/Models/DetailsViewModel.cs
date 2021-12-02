using System.Text.Json.Serialization;

namespace Web_953502_Strelets_Blazor.Client.Models
{
    public class DetailsViewModel
    {
        [JsonPropertyName("mark")]
        public string CarName { get; set; }

        [JsonPropertyName("model")]
        public string Mark { get; set; }
        
        [JsonPropertyName("color")]
        public string Color { get; set; }
        
        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
