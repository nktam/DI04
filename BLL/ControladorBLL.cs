using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using UTILS;

namespace BLL
{
    public class ControladorBLL
    {

        public static List<string> DatosComercial(string id)
        {
            return LeerDatosDAL.DatosComercial(id);
        }

        public static List<string> GetComerciales()
        {
            return LeerDatosDAL.GetComerciales();
        }

        public static int FacturacionAnual(string idcom, string idemp)
        {
            return LeerDatosDAL.FacturacionAnual(idcom, idemp);
        }

            public static List<DatosVO> FacturacionMes(string id, string idemp)
        {
            return LeerDatosDAL.FacturacionMes(id, idemp);
        }
    }
}
