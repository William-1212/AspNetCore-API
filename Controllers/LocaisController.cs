﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using apicorreios.Models;
using System.Web;
 namespace apicorreios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocaisController : Controller    {
    
        [HttpGet("oi")]
       public JsonResult Get()
       {
           using(var db = new LocaisContexto()){
                 return Json(db.Enderecos.ToList());
           }
       }
    
    }
}
