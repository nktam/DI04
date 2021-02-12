using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using UTILS;

namespace UI.Forms
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();

            // Cargamos en el combo box los nombre de los comerciales
            foreach (var item in ControladorBLL.GetComerciales())
            {
                cbComercial.Items.Add(item);
            }

            // Seleccionamos en el combo el comercial 1
            // al seleccionar cbComercial_SelectedIndexChanged lanza CargaComercial()
            cbComercial.SelectedIndex = 0;

        }


        private void CargaComercial(string idcom)
        {
            List<string> datoscomercial = ControladorBLL.DatosComercial(idcom);

            lbNombre.Text = datoscomercial[1]+" "+datoscomercial[2];
            lbDireccion.Text = datoscomercial[3];
            lbEdad.Text = $"Edad: {datoscomercial[4]}";
            lbEmp1tot.Text = ControladorBLL.FacturacionAnual(idcom, "1").ToString()+" €";
            lbEmp2tot.Text = ControladorBLL.FacturacionAnual(idcom, "2").ToString() + " €";

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

            chtEmp2Trim.Series[0].Points.Clear();
            foreach (var item in ControladorBLL.FacturacionMes(idcom, "2"))
            {
                chtEmp2Trim.Series[0].Points.AddXY(item.Nombre, item.Valor);
            }
        }

        private void cbComercial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int com = cbComercial.SelectedIndex + 1;
            string comercial = com.ToString();
            CargaComercial(comercial);

        }
    }
}
