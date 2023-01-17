using Newtonsoft.Json;

namespace TestMaurySore.Model
{
    public class Product
    {

        
        [JsonProperty(PropertyName = "productKey")]
        public string productKey { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "isComplete")]
        public bool Completed { get; set; }
    }
}
