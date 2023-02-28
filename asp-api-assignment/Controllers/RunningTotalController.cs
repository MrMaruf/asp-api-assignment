using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asp_api_assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RunningTotalController : ControllerBase
    {
        // Assignment 3 implementation;
        [HttpPost(Name ="runningtotal")]
        public int Post(RunningTotalRequestBody requestBody)
        {
            int value = requestBody.Number;
            int sum = value + PersistentValuesHolder.PreviousValue + PersistentValuesHolder.LastValue;
            PersistentValuesHolder.LastValue = value;
            return sum;
        }

    }
}
