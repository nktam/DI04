using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class DatosComercialUC : UserControl
    {
        public DatosComercialUC()
        {
            InitializeComponent();
        }

        public void SetNombre(string text)
        {
            lbNombre.Text = text;
        }

        public void SetDireccion(string text)
        {
            lbDireccion.Text = text;
        }

        public void SetEdad(string text)
        {
            lbEdad.Text = text;
        }

        private void DatosComercial_Load(object sender, EventArgs e)
        {

        }
    }
}
