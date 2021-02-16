using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using UTILS;

namespace BLL
{
    public class ControladorBLL
    {

        public static ComercialVO DatosComercial(string id)
        {
            return LeerDatosDAL.DatosComercial(id);
        }

        public static List<ComercialVO> GetComerciales()
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

        public static List<DatosVO> FacturacionTrim(string id, string idemp)
        {
            return LeerDatosDAL.FacturacionTrim(id, idemp);
        }
    }
}
