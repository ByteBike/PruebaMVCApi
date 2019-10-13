using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    interface IRepositorio
    {
        IEnumerable GetAll();

        List<Pc> ReadPcFile(string path);

    }
}
