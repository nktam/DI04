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
        private UserControls.DatosComercialUC datoscomercial_uc;
        private UserControls.TotalEmpresasUC totalempresas_uc;
        private UserControls.TotalVentasUC totalventas_uc;
        public Formulario()
        {
            InitializeComponent();



            datoscomercial_uc = new UserControls.DatosComercialUC();
            totalempresas_uc = new UserControls.TotalEmpresasUC();
            totalventas_uc = new UserControls.TotalVentasUC();

            // Cargamos en el combobox los nombres de los comerciales
            foreach (var item in ControladorBLL.GetComerciales())
            {
                cbComercial.Items.Add(item.Nombre);
            }

            // Seleccionamos en el combo el comercial 1
            // al seleccionar cbComercial_SelectedIndexChanged lanza CargaComercial()
            cbComercial.SelectedIndex = 0;

        }

        private void CargaComercial(string idatoscomercial_ucom)
        {
            // añadimos al table layout panel tlpAside el usercontrol datoscomercial_uc
            tlpAside.Controls.Add(datoscomercial_uc,0,1);
            // añadimos al table layout panel tlpAside el usercontrol totalempresas_uc
            tlpAside.Controls.Add(totalempresas_uc, 0, 2);
            // añadimos al table layout panel tlpAside el usercontrol totalempresas_uc
            tlpAside.Controls.Add(totalventas_uc, 0, 3);

            // instanciamos el obejto COmercialVO comercial
            ComercialVO comercial = new ComercialVO();
            // consultamos al controlador los datos del comercial
            comercial = ControladorBLL.DatosComercial(idatoscomercial_ucom);
            // en el usercontrol mostramos los datos
            datoscomercial_uc.SetNombre (comercial.Nombre);
            datoscomercial_uc.SetDireccion(comercial.Direccion);
            datoscomercial_uc.SetEdad($"Edad: {comercial.Edad}");

            int fac1 = ControladorBLL.FacturacionAnual(idatoscomercial_ucom, "1");
            int fac2 = ControladorBLL.FacturacionAnual(idatoscomercial_ucom, "2");

            totalempresas_uc.SetEmp1(fac1.ToString()+" €");
            totalempresas_uc.SetEmp2(fac2.ToString() + " €");

            totalventas_uc.SetTotal((fac1+fac2).ToString()+" €");
            // Limpiamos y rellenamos los datos de la facturación mes de la empresa 1
            chtEmp1mes.Series[0].Points.Clear();
            foreach (var item in ControladorBLL.FacturacionMes(idatoscomercial_ucom, "1"))
            {
                chtEmp1mes.Series[0].Points.AddXY(item.Nombre, item.Valor);
            }

            // Limpiamos y rellenamos los datos de la facturación mes de la empresa 2
            chtEmp2mes.Series[0].Points.Clear();
            foreach (var item in ControladorBLL.FacturacionMes(idatoscomercial_ucom, "2"))
            {
                chtEmp2mes.Series[0].Points.AddXY(item.Nombre, item.Valor);
            }

            chtEmp1Trim.Series[0].Points.Clear();
            foreach (var item in ControladorBLL.FacturacionTrim(idatoscomercial_ucom, "1"))
            {
                chtEmp1Trim.Series[0].Points.AddXY(item.Nombre, item.Valor);
            }

            chtEmp2Trim.Series[0].Points.Clear();
            foreach (var item in ControladorBLL.FacturacionTrim(idatoscomercial_ucom, "2"))
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
