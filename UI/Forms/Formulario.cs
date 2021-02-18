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
        private UserControls.GraficosUC graficos_uc;
        public Formulario()
        {
            InitializeComponent();



            datoscomercial_uc = new UserControls.DatosComercialUC();
            totalempresas_uc = new UserControls.TotalEmpresasUC();
            totalventas_uc = new UserControls.TotalVentasUC();
            graficos_uc = new UserControls.GraficosUC();

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
            // añadimos al table layout panel base el usercontrol graficos_uc
            tlpBase.Controls.Add(graficos_uc, 1, 0);

            // instanciamos el obejto COmercialVO comercial
            ComercialVO comercial = new ComercialVO();
            // consultamos al controlador los datos del comercial
            comercial = ControladorBLL.DatosComercial(idatoscomercial_ucom);
            // en el usercontrol mostramos los datos
            datoscomercial_uc.SetNombre (comercial.Nombre);
            datoscomercial_uc.SetDireccion(comercial.Direccion);
            datoscomercial_uc.SetEdad($"Edad: {comercial.Edad}");
            // obtenemos la facturacion anual por empresa
            int fac1 = ControladorBLL.FacturacionAnual(idatoscomercial_ucom, "1");
            int fac2 = ControladorBLL.FacturacionAnual(idatoscomercial_ucom, "2");
            // mostramos en el uc
            totalempresas_uc.SetEmp1(fac1.ToString()+" €");
            totalempresas_uc.SetEmp2(fac2.ToString() + " €");
            // sumamos y mostramos en el UC
            totalventas_uc.SetTotal((fac1+fac2).ToString()+" €");
            // Rellenamos en graficos_uc los gráficos con las ventas del comercial
            graficos_uc.Rellenar(idatoscomercial_ucom);
        }

        private void cbComercial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int com = cbComercial.SelectedIndex + 1;
            string comercial = com.ToString();
            CargaComercial(comercial);
        }

    }
}
