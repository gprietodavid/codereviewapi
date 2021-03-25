using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleapi.helpers
{   
    public class BusNotifier
    {
        
        public BusNotifier() {
            
        }
        public bool PostMessage(string message)
        {
            //let's pretend we did post a message to a bus for a receiver to handle the job
            return true;
        }
    }
}
