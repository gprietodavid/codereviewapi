using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sampleapi.helpers;
using sampleapi.interfaces;
using sampleapi.models;

namespace sampleapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxReturn : ControllerBase
    {
        private readonly IQueryService _queryService;

        private readonly ILogger<TaxReturn> _logger;
       
        public TaxReturn(ILogger<TaxReturn> logger, IQueryService queryService)
        {
            _logger = logger;
            _queryService = queryService;
        }

        [HttpPost]
        public IActionResult PlaceJob()
        {
            BusNotifier notify = new BusNotifier();
            notify.PostMessage("do something");
            return Accepted();
        }
        [Authorize]
        [HttpGet]
        public async Task<SampleResponse> GetSamples()
        {
           return await _queryService.GetAllSamples();         
        }
    }
}
