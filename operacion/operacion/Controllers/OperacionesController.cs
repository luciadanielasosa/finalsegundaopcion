using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace operacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        [HttpGet]
        public string operaciones(int numero)
        {
            string respuesta = "";
            if(numero<0)
            {
                respuesta = "ERROR";
            }
            if(numero==0)
            {
                respuesta = "Realizado por Lucia Sosa";
            }
            if(numero>0)
            {
                respuesta = "imagen";
            }
            return respuesta;

        }
    }
}
