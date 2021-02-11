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

        public static List<string> DatosComercial (string id)
        {
            StreamReader rDatos = new StreamReader(File.OpenRead(fileDatos));
            List<string> lista = new List<string>();
            var line = rDatos.ReadLine();
            
            while (!rDatos.EndOfStream)
            {
                var values = line.Split(',');
                if (values[0] == id)
                {
                    foreach (var item in values)
                    {
                        lista.Add(item);
                    }
                }
                line = rDatos.ReadLine();
            }
                return lista;
        }


        public static List<DatosVO> FacturacionMes(string id)
        {
            StreamReader rDatos = new StreamReader(File.OpenRead(fileFacturacion));
            List<DatosVO> lista = new List<DatosVO>();
            List<int> listavalores = new List<int>();
            List<string> listapie = new List<string>();

            while (true)
            {
                var line = rDatos.ReadLine();
                var values = line.Split(',');

                if (values[0] == "numero_comercial")
                {
                    for (int i = 1; i < values.Length; i++)
                    {
                        listapie.Add(values[i]);
                    }
                }

                if (values[0] == id && values[1] == "1")
                {
                    for (int i = 1; i < values.Length; i++)
                    {
                        listavalores.Add(int.Parse(values[i]));
                    }
                }
                if (rDatos.EndOfStream) break;
            }

            for (int i = 1; i < listapie.Count; i++)
            {
                lista.Add(new DatosVO(listavalores[i], listapie[i]));
            }

            return lista;
        }

    }
}
