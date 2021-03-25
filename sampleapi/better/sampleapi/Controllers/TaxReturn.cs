using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sampleapi.helpers;
using sampleapi.interfaces;
using sampleapi.models;
using Microsoft.AspNetCore.Authorization;

namespace sampleapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class TaxReturn : ControllerBase
    {
        private readonly IQueryService _queryService;
        private readonly IMessagePublisher _publisher;

        private readonly ILogger<TaxReturn> _logger;       
        public TaxReturn(ILogger<TaxReturn> logger, IQueryService queryService, IMessagePublisher publisher)
        {
            _logger = logger;
            _queryService = queryService;
            _publisher = publisher;
        }

        [HttpPost]
        public IActionResult PlaceJob()
        {
            _publisher.PostMessage("do something");
            return Accepted();
        }

        [HttpGet]
        public async Task<SampleResponse> GetSamples()
        {
           return await _queryService.GetAllSamples();         
        }
    }
}
