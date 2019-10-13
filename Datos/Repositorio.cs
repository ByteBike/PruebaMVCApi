using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Web;


namespace Datos
{
    public class Repositorio : IRepositorio
    {

        public List<Pc> ReadPcFile(string path)
        {
            // sirve
            //string sPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            //GetPath clase = new GetPath();
            //string path = clase.GetFilePath();
            //myFileStream = new FileStream(path, FileMode.Open);
            //        < Id > 1 </ Id >
            //< Cpu > Intel </ Cpu >
            //< Memoria > 8 </ Memoria >
            //< disco >
            //  < Tipo > Hard Disk </ Tipo >

            //     < Capacidad > 500 </ Capacidad >
            // disco

            
           
               XDocument xdoc = XDocument.Load(path);

            Pc objPc = new Pc();
            List<Pc> lstPc
                = (from _pc in xdoc.Element("PCList").Elements("Computador")
                   select new Pc
                   {
                       Id = Convert.ToInt32(_pc.Element("Id").Value),
                       Procesador = _pc.Element("Cpu").Value,
                       Memoria = Convert.ToInt32(_pc.Element("Memoria").Value),
                       Disco = new Disco
                                {
                                    Capacidad = Convert.ToInt32(_pc.Element("disco").Element("Capacidad").Value),
                                    Tipo = _pc.Element("disco").Element("Tipo").Value
                                }
                   }).ToList();
           
            //foreach (XElement element in doc.Root.Descendants("Computador"))
            //{
            //    Pc pc = new Pc();
            //    pc.Id = (int)element.Attribute()
            //    pc.Memoria = (int)element.Attribute("Memoria");
            //    pc.Procesador = (string)element.Attribute("Procesador");
            //    pcs.Add(pc);

            //}


            return lstPc;
        }


        public IEnumerable GetAll()
        {
            throw new NotImplementedException();
        }

       

    }
}
