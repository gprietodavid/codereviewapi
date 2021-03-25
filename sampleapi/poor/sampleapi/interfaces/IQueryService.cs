using sampleapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleapi.interfaces
{
    public interface IQueryService    {
        Task<SampleResponse> GetAllSamples();
    }
}
