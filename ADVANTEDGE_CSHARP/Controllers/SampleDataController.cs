using System;
using System.Threading.Tasks;
using ADVANTEDGE_CSHARP.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ADVANTEDGE_CSHARP.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private IJsonOperations jsonOperations;
        public SampleDataController()
        {
            jsonOperations = new JsonOperations("./Assets/Pet.json");
        }
        [HttpGet("[action]")]
        public IActionResult GetJsonData()
        {
            try
            {
                return Ok(Task.Factory.StartNew(() => jsonOperations.GetJsonData()).Result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}