using System;
using System.Windows.Forms;

namespace proyectoo
{
    public partial class MainForm : Form
    {
        public MainForm() 
        {
            InitializeComponent();
        }

        private string GenerarRFC(string nombre, string apellido1, string apellido2, DateTime fechaNacimiento)
        {
   
            return 
                (apellido1.Length > 1 ? apellido1.Substring(0, 2).ToUpper() : "") + 
                (apellido2.Length > 0 ? apellido2.Substring(0, 1).ToUpper() : "") + 
                (nombre.Length > 0 ? nombre.Substring(0, 1).ToUpper() : "") + 
                fechaNacimiento.ToString("yyMMdd"); // Formato AAMMDD
        }


        void BtnCalcularClick(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido1 = txtApellido1.Text;
            string apellido2 = txtApellido2.Text;
            DateTime fechaNacimiento = dtpFechaDeNacimiento.Value;

            string rfc = GenerarRFC(nombre, apellido1, apellido2, fechaNacimiento);
            lblResultado.Text = rfc; 

		}
    }
}
