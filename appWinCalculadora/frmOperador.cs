using libServices;
using System;
using System.Windows.Forms;

namespace appWinCalculadora
{
    public partial class frmOperador<Tipo> : Form
    {
        Tipo cmpOperando1, cmpOperando2;
        string cmpMensaje = null;
        public frmOperador()
        {
            InitializeComponent();
        }
        private void txtOperando1_TextChanged(object sender, EventArgs e)
        {
            if(txtOperando1.Text == "")
                return;
            cmpOperando1 = clsMatematica.ConvertirATipo<Tipo>(txtOperando1.Text);
            cmpMensaje = clsMensajero.darMensaje();
            if (cmpMensaje != null)
            {
                MessageBox.Show(cmpMensaje);
                txtOperando1.Text = null;
            }
        }
        private void txtOperando2_TextChanged(object sender, EventArgs e)
        {
            if (txtOperando2.Text == "")
                return;

            if (lblOperando2.Text == "Denominador" && txtOperando2.Text == "0")
            {
                MessageBox.Show("ERROR: El denominador no puede ser 0");
                txtOperando2.Text = "";
                return;
            }
            cmpOperando2 = clsMatematica.ConvertirATipo<Tipo>(txtOperando2.Text);
            cmpMensaje = clsMensajero.darMensaje();
            if (cmpMensaje != null)
            {
                MessageBox.Show(cmpMensaje);
                txtOperando2.Text = "";
            }
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            switch (btnOperar.Text)
            {
                case "Sumar":
                    if (chkDesbordamiento.Checked == false)
                    {
                        txtResultado.Text = clsMatematica.Sumar<Tipo>(cmpOperando1, cmpOperando2).ToString();
                        break;
                    }
                    txtResultado.Text = clsMatematica.Sumar<Tipo>(cmpOperando1, cmpOperando2).ToString();
                    string varTipo = cmpOperando1.GetType().Name;
                    cmpMensaje = "";
                    switch (varTipo)
                    {
                        case "Byte":
                            cmpMensaje = Text.ToUpper() + " EN EL RANGO DE [ " + Byte.MinValue + " .. " + Byte.MaxValue + " ]\n";
                            cmpMensaje = cmpMensaje + "<Modalidad>: Con chequeo de desbordamiento.\n";
                            if (((dynamic)cmpOperando1 + cmpOperando2) > Byte.MaxValue)
                            {
                                cmpMensaje = cmpMensaje + "<ERROR>: Hubo un desbordamiento y la suma (" + cmpOperando1 + ") + (" + cmpOperando2 + ") no es posible para el rango.\n";
                                cmpMensaje = cmpMensaje + "<Causa>: El " + lblOperando2.Text + " debe estar en el intervalo entre [ 0 .. " + (Byte.MaxValue - (dynamic)cmpOperando1) + " ]\n";
                            }
                            else
                            {
                                cmpMensaje = cmpMensaje + "<Resultado>: " + txtResultado.Text;
                            }
                            break;

                        case "Int16":
                            cmpMensaje = Text.ToUpper() + " EN EL RANGO DE [ " + Int16.MinValue + " .. " + Int16.MaxValue + " ]\n";
                            cmpMensaje = cmpMensaje + "<Modalidad>: Con chequeo de desbordamiento.\n";
                            if (((dynamic)cmpOperando1 + cmpOperando2) > Int16.MaxValue)
                            {
                                cmpMensaje = cmpMensaje + "<ERROR>: Hubo un desbordamiento y la suma (" + cmpOperando1 + ") + (" + cmpOperando2 + ") no es posible para el rango.\n";
                                cmpMensaje = cmpMensaje + "<Causa>: El " + lblOperando2.Text + " debe estar en el intervalo entre [ 0 .. " + (Int16.MaxValue - (dynamic)cmpOperando1) + " ]\n";
                            }
                            else
                            {
                                cmpMensaje = cmpMensaje + "<Resultado>: " + txtResultado.Text;
                            }
                            break;

                        case "Int32":
                            cmpMensaje = Text.ToUpper() + " EN EL RANGO DE [ " + Int32.MinValue + " .. " + Int32.MaxValue + " ]\n";
                            cmpMensaje = cmpMensaje + "<Modalidad>: Con chequeo de desbordamiento.\n";
                            if (((dynamic)cmpOperando1 + cmpOperando2) > Int32.MaxValue)
                            {
                                cmpMensaje = cmpMensaje + "<ERROR>: Hubo un desbordamiento y la suma (" + cmpOperando1 + ") + (" + cmpOperando2 + ") no es posible para el rango.\n";
                                cmpMensaje = cmpMensaje + "<Causa>: El " + lblOperando2.Text + " debe estar en el intervalo entre [ 0 .. " + (Int32.MaxValue - (dynamic)cmpOperando1) + " ]\n";
                            }
                            else
                            {
                                cmpMensaje = cmpMensaje + "<Resultado>: " + txtResultado.Text;
                            }
                            break;

                        case "Int64":
                            cmpMensaje = Text.ToUpper() + " EN EL RANGO DE [ " + Int64.MinValue + " .. " + Int64.MaxValue + " ]\n";
                            cmpMensaje = cmpMensaje + "<Modalidad>: Con chequeo de desbordamiento.\n";
                            if (((dynamic)cmpOperando1 + cmpOperando2) > Int64.MaxValue)
                            {
                                cmpMensaje = cmpMensaje + "<ERROR>: Hubo un desbordamiento y la suma (" + cmpOperando1 + ") + (" + cmpOperando2 + ") no es posible para el rango.\n";
                                cmpMensaje = cmpMensaje + "<Causa>: El " + lblOperando2.Text + " debe estar en el intervalo entre [ 0 .. " + (Int64.MaxValue - (dynamic)cmpOperando1) + " ]\n";
                            }
                            else
                            {
                                cmpMensaje = cmpMensaje + "<Resultado>: " + txtResultado.Text;
                            }
                            break;

                        case "Single":
                            cmpMensaje = Text.ToUpper() + " EN EL RANGO DE [ " + Single.MinValue + " .. " + Single.MaxValue + " ]\n";
                            cmpMensaje = cmpMensaje + "<Modalidad>: Con chequeo de desbordamiento.\n";
                            if (((dynamic)cmpOperando1 + cmpOperando2) > Single.MaxValue)
                            {
                                cmpMensaje = cmpMensaje + "<ERROR>: Hubo un desbordamiento y la suma (" + cmpOperando1 + ") + (" + cmpOperando2 + ") no es posible para el rango.\n";
                                cmpMensaje = cmpMensaje + "<Causa>: El " + lblOperando2.Text + " debe estar en el intervalo entre [ 0 .. " + (Single.MaxValue - (dynamic)cmpOperando1) + " ]\n";
                            }
                            else
                            {
                                cmpMensaje = cmpMensaje + "<Resultado>: " + txtResultado.Text;
                            }
                            break;

                        case "Double":
                            cmpMensaje = Text.ToUpper() + " EN EL RANGO DE [ " + Double.MinValue + " .. " + Double.MaxValue + " ]\n";
                            cmpMensaje = cmpMensaje + "<Modalidad>: Con chequeo de desbordamiento.\n";
                            if (((dynamic)cmpOperando1 + cmpOperando2) > Double.MaxValue)
                            {
                                cmpMensaje = cmpMensaje + "<ERROR>: Hubo un desbordamiento y la suma (" + cmpOperando1 + ") + (" + cmpOperando2 + ") no es posible para el rango.\n";
                                cmpMensaje = cmpMensaje + "<Causa>: El " + lblOperando2.Text + " debe estar en el intervalo entre [ 0 .. " + (Double.MaxValue - (dynamic)cmpOperando1) + " ]\n";
                            }
                            else
                            {
                                cmpMensaje = cmpMensaje + "<Resultado>: " + txtResultado.Text;
                            }
                            break;
                    }
                    MessageBox.Show(cmpMensaje);
                    break;

                case "Restar":
                    txtResultado.Text = clsMatematica.Restar<Tipo>(cmpOperando1, cmpOperando2).ToString();
                    break;

                case "Multiplicar":
                    txtResultado.Text = clsMatematica.Multiplicar<Tipo>(cmpOperando1, cmpOperando2).ToString();
                    break;

                case "Dividir":
                    txtResultado.Text = clsMatematica.Dividir<Tipo>(cmpOperando1, cmpOperando2).ToString();
                    break;
            }
        }
    }
}