using APIs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ResponseModel> Get()
        {
            var response = new ResponseModel();
            response.ResponseMessage = "Welcome to Predatar!";
            return response;
        }
    }
}
