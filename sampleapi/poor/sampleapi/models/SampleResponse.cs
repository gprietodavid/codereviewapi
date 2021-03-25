using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleapi.models
{
    public class SampleResponse
    {
        public string MetadataHeader { get; set; }
        public IEnumerable<Sample> Samples { get; set; }
    }
}
