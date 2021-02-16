using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UTILS;

namespace DAL
{
    public class LeerDatosDAL
    {
        private const string fileDatos = @"..\..\..\DAL\bd\1_datos_comerciales.csv";
        private const string fileFacturacion = @"..\..\..\DAL\bd\2_facturacion_comercial.csv";

        public static ComercialVO DatosComercial (string id)
        {
            StreamReader rDatos = new StreamReader(File.OpenRead(fileDatos));
            ComercialVO comercial = new ComercialVO();

            while (!rDatos.EndOfStream)
            {   
                string line = rDatos.ReadLine();
                string[] values = line.Split(',');
                if (values[0] == id)
                {
                    comercial.Nombre = values[1] + " " + values[2];
                    comercial.Direccion = values[3];
                    comercial.Edad = values[4];
                }
                if (rDatos.EndOfStream) break;
            }
            return comercial;
        }

        public static List<ComercialVO> GetComerciales()
        {
            StreamReader rDatos = new StreamReader(File.OpenRead(fileDatos));
            List<ComercialVO> lista = new List<ComercialVO>();
            
            while (true)
            {
                string line = rDatos.ReadLine();
                var values = line.Split(',');
                if (values[1] != " nombre") 
                {
                    lista.Add(new ComercialVO(int.Parse(values[0]), values[1]+" "+values[2], values[3], values[4]));
                }
                if (rDatos.EndOfStream) break;
            }
            return lista;
        }


        public static List<DatosVO> FacturacionMes(string idcom, string idemp)
        {
            StreamReader rDatos = new StreamReader(File.OpenRead(fileFacturacion));
            List<DatosVO> lista = new List<DatosVO>();
            List<int> listavalores = new List<int>();
            List<string> listapie = new List<string>();

            while (true)
            {
                var line = rDatos.ReadLine();
                var values = line.Split(',');

                // si el priemr dato es numero_comercial
                //estamos en la primera fila metemos los meses a la lista pie
                if (values[0] == "numero_comercial")
                {
                    for (int i = 1; i < values.Length; i++)
                    {
                        listapie.Add(values[i]);
                    }
                }
                // si el primer dato es igual al id del comercial
                // y el segundo dato igual al id de la empresa
                // metemos los valores a la listavalorea
                if (values[0] == idcom && values[1] == idemp)
                {
                    for (int i = 1; i < values.Length; i++)
                    {
                        listavalores.Add(int.Parse(values[i]));
                    }
                }
                if (rDatos.EndOfStream) break;
            }

            // recorremos los array y anadimos a la lista los objetos DatosVO que estamos creando
            for (int i = 1; i < listapie.Count; i++)
            {
                lista.Add(new DatosVO(listavalores[i], listapie[i]));
            }
            return lista;
        }

        public static List<DatosVO> FacturacionTrim(string idcom, string idemp)
        {
            StreamReader rDatos = new StreamReader(File.OpenRead(fileFacturacion));
            List<DatosVO> lista = new List<DatosVO>();
            List<int> listavalores = new List<int>();
            string[] listapie = new string[]{ "TRIM1", "TRIM2", "TRIM3", "TRIM4" };

            while (true)
            {
                var line = rDatos.ReadLine();
                var values = line.Split(',');
         
                // si el primer dato es igual al id del comercial
                // y el segundo dato igual al id de la empresa
                // metemos los valores a la listavalorea
                if (values[0] == idcom && values[1] == idemp)
                {
                    int count = 0;
                    int tot = 0;
                    for (int i = 2; i < values.Length; i++)
                    {
                        tot += int.Parse(values[i]);

                        if (count == 2)
                        {
                            listavalores.Add(tot);
                            tot = 0;
                            count = 0;
                        } 
                        else
                        {
                            count++;
                        }
                        
                    }
                }
                if (rDatos.EndOfStream) break;
            }

            // recorremos los array y anadimos a la lista los objetos DatosVO que estamos creando
            for (int i = 0; i < listapie.Length; i++)
            {
                lista.Add(new DatosVO(listavalores[i], listapie[i]));
            }
            return lista;
        }

        public static int FacturacionAnual(string idcom, string idemp)
        {
            StreamReader rDatos = new StreamReader(File.OpenRead(fileFacturacion));
            int total=0;

            while (true)
            {
                var line = rDatos.ReadLine();
                var values = line.Split(',');

                if (values[0] == idcom && values[1] == idemp)
                {
                    for (int i = 1; i < values.Length; i++)
                    {
                        total += int.Parse(values[i]);
                    }
                }
                if (rDatos.EndOfStream) break;
            }
            return total;
        }

    }
}
