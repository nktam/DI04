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

        public static List<DatosVO> FacturacionMes(string id)
        {
            return LeerDatosDAL.FacturacionMes(id);
        }
    }
}
