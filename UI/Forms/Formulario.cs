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
            textBox1.Text = String.Join(", ", ControladorBLL.DatosComercial("1"));

            foreach (var item in ControladorBLL.FacturacionMes("1"))
            {
                chart2.Series[0].Points.AddXY(item.Nombre, item.Valor);
            }

        }

       
    }
}
