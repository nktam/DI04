using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI.UserControls
{
    public partial class GraficosUC : UserControl
    {
        public GraficosUC()
        {
            InitializeComponent();
        }

        public void Rellenar(string idcom)
        {
            // Limpiamos y rellenamos los datos de la facturación mes de la empresa 1
            chtEmp1mes.Series[0].Points.Clear();
            foreach (var item in ControladorBLL.FacturacionMes(idcom, "1"))
            {
                chtEmp1mes.Series[0].Points.AddXY(item.Nombre, item.Valor);
            }
            // Limpiamos y rellenamos los datos de la facturación mes de la empresa 2
            chtEmp2mes.Series[0].Points.Clear();
            foreach (var item in ControladorBLL.FacturacionMes(idcom, "2"))
            {
                chtEmp2mes.Series[0].Points.AddXY(item.Nombre, item.Valor);
            }
            // Limpiamos y rellenamos los datos de la facturación trimestre de la empresa 1
            chtEmp1Trim.Series[0].Points.Clear();
            foreach (var item in ControladorBLL.FacturacionTrim(idcom, "1"))
            {
                chtEmp1Trim.Series[0].Points.AddXY(item.Nombre, item.Valor);
            }
            // Limpiamos y rellenamos los datos de la facturación trimestre de la empresa 2
            chtEmp2Trim.Series[0].Points.Clear();
            foreach (var item in ControladorBLL.FacturacionTrim(idcom, "2"))
            {
                chtEmp2Trim.Series[0].Points.AddXY(item.Nombre, item.Valor);
            }
        }
    }
}
