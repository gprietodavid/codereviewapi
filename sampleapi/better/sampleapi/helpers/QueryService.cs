using Microsoft.Azure.Cosmos;
using sampleapi.interfaces;
using sampleapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleapi.helpers
{
    public class QueryService : IQueryService
    {
        private string CosmosConnectionString = "mystring";
        private CosmosClient cosmosClient;
        public QueryService()
        {
            cosmosClient = new CosmosClient(CosmosConnectionString);
        }
        public async Task<SampleResponse> GetAllSamples()
        {
            var response = new SampleResponse()
            {
                MetadataHeader = "something"
            };
            var query = cosmosClient.GetContainer("mydb", "mycontainer").GetItemQueryIterator<Sample>("SELECT * FROM c");
            List<Sample> results = new List<Sample>();
            while (query.HasMoreResults) results.AddRange((await query.ReadNextAsync()).ToList());
            response.Samples = results;
            return response;
        }
    }
}
