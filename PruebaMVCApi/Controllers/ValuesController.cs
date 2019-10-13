using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using Datos;

namespace PruebaMVCApi.Controllers
{
    public class ValuesController : ApiController
    {
        ////GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}



        //[AcceptVerbs("GET")]
        //[HttpGet]
        // usage http://localhost:50697/api/values/get
        public string Get()
        {
            List<Pc> pcs = new List<Pc>();
            Disco disco1 = new Disco();
            Disco disco2 = new Disco();
            disco1.Capacidad = 500;
            disco2.Capacidad = 250;
            disco1.Tipo = "Hard Disk";
            disco2.Tipo = "Solid State";

            pcs.Add(new Pc { Id = 1, Procesador = "Intel I5", Memoria = 8, Disco = disco1 });
            pcs.Add(new Pc { Id = 1, Procesador = "Intel I7", Memoria = 16, Disco = disco2 });
            pcs.Add(new Pc { Id = 1, Procesador = "AMD XX", Memoria = 24, Disco = disco1 });
            var resultado = pcs.Where(s => s.Memoria > 8);
            //string datapath = Path.Combine(HttpContext.Request.PhysicalApplicationPath, @"App_Data\PcInfoFile.xml");
            //Repositorio rep = new Repositorio();
            //var pcs = rep.ReadPcFile(datapath);
            //var resultado = pcs.Where(s => s.Memoria > 8);
            string jsonString = JsonConvert.SerializeObject(resultado, Formatting.Indented);
            return jsonString;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
