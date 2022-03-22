using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Versioning_RestPAI.V1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("0.9", Deprecated = true)]
    [ApiVersion("1.0")]
    public class VersioningDemo:ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Data.Summaries.Where(x => x.StartsWith("B"));
        }
    }
}
