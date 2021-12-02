using System.Text.Json.Serialization;

namespace Web_953502_Strelets_Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("carId")]
        public int CarId { get; set; }

        [JsonPropertyName("mark")]
        public string CarName { get; set; }

    }
}
