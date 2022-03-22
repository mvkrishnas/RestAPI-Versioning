using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Versioning_RestPAI.V3.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("0.9", Deprecated = true)]
    [ApiVersion("3.0")]
    public class VersioningDemo : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Data.Summaries.Where(x => x.StartsWith("C"));
        }
    }
}
