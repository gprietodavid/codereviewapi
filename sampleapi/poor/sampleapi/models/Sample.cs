using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleapi.models
{
    public class Sample
    {
        [JsonProperty("id")]
        public string ID { get; }

        [JsonProperty("SampleAttribute")]
        public string SampleAttribute { get; set; }
    }

}
