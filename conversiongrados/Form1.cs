using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversiongrados
{
    public partial class Form1 : Form
    {
        //---------------------------------------
        Conversion conversion = new Conversion();
        //---------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            conversion.setGrados(double.Parse(txtgrados.Text));
           // MessageBox.Show(cbtipogrados.SelectedIndex.ToString());

            switch (cbtipogrados.SelectedIndex.ToString())
            {
                case "0":

                    lblresultado.Text = "El resultado es: "+conversion.convertirFarenheit().ToString();
                    lblresultado.Visible = true;

                    break;

                case "1":
                    lblresultado.Text = "El resultado es: " + conversion.convertirCelcius().ToString();
                    lblresultado.Visible = true;
                    break;

                default:

                    MessageBox.Show("Ingrese una opción valida.");

                    break;
                    



            }
        }
    }
}
