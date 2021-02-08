using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using apicorreios.Models;
using System.Web;
using System.Net;
 namespace apicorreios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class CorreiosController : Controller    {
    
        [HttpGet("correios")]
       public string Get()
       {
           var json = new WebClient().DownloadString("https://viacep.com.br/ws/01001000/json/");
           return json;
       }
    
    }
}
