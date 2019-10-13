using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Datos
{
    public class Pc
    {
        public int Id { get; set; }

        public string Procesador { get; set; }

        public int Memoria { get; set; }

        public Disco Disco { get; set; }
    }
}