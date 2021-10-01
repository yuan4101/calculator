using System;
using System.Windows.Forms;

namespace appWinCalculadora
{
    public partial class mdiFormPrincipal : Form
    {
        public mdiFormPrincipal()
        {
            InitializeComponent();
        }

        private void subMnuSumarOpcByte_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<byte> vtnaOperacion = new frmOperador<byte>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Suma de Bytes";
            vtnaOperacion.Controls[0].Text = "Sumar";
            vtnaOperacion.Controls[6].Text = "Sumando 1";
            vtnaOperacion.Controls[5].Text = "Sumando 2";
            vtnaOperacion.Controls[2].Visible = true;
            vtnaOperacion.Show();
        }

        private void subMnuSumarOpcShort_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<short> vtnaOperacion = new frmOperador<short>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Suma de Shorts";
            vtnaOperacion.Controls[0].Text = "Sumar";
            vtnaOperacion.Controls[6].Text = "Sumando 1";
            vtnaOperacion.Controls[5].Text = "Sumando 2";
            vtnaOperacion.Controls[2].Visible = true;
            vtnaOperacion.Show();
        }

        private void subMnuSumarOpcEntero_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<int> vtnaOperacion = new frmOperador<int>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Suma de Enteros";
            vtnaOperacion.Controls[0].Text = "Sumar";
            vtnaOperacion.Controls[6].Text = "Sumando 1";
            vtnaOperacion.Controls[5].Text = "Sumando 2";
            vtnaOperacion.Controls[2].Visible = true;
            vtnaOperacion.Show();
        }

        private void subMnuSumarOpcLong_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<long> vtnaOperacion = new frmOperador<long>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Suma de Longs";
            vtnaOperacion.Controls[0].Text = "Sumar";
            vtnaOperacion.Controls[6].Text = "Sumando 1";
            vtnaOperacion.Controls[5].Text = "Sumando 2";
            vtnaOperacion.Controls[2].Visible = true;
            vtnaOperacion.Show();
        }

        private void subMnuSumarOpcFloat_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<float> vtnaOperacion = new frmOperador<float>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Suma de Floats";
            vtnaOperacion.Controls[0].Text = "Sumar";
            vtnaOperacion.Controls[6].Text = "Sumando 1";
            vtnaOperacion.Controls[5].Text = "Sumando 2";
            vtnaOperacion.Controls[2].Visible = true;
            vtnaOperacion.Show();
        }

        private void subMnuSumarOpcDoble_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<double> vtnaOperacion = new frmOperador<double>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Suma de Dobles";
            vtnaOperacion.Controls[0].Text = "Sumar";
            vtnaOperacion.Controls[6].Text = "Sumando 1";
            vtnaOperacion.Controls[5].Text = "Sumando 2";
            vtnaOperacion.Controls[2].Visible = true;
            vtnaOperacion.Show();
        }

        private void subMnuRestarOpcEntero_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<int> vtnaOperacion = new frmOperador<int>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Resta de Enteros";
            vtnaOperacion.Controls[0].Text = "Restar";
            vtnaOperacion.Controls[6].Text = "Minuendo";
            vtnaOperacion.Controls[5].Text = "Sustraendo";
            vtnaOperacion.Show();
        }

        private void subMnuRestarOpcFloat_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<float> vtnaOperacion = new frmOperador<float>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Resta de Floats";
            vtnaOperacion.Controls[0].Text = "Restar";
            vtnaOperacion.Controls[6].Text = "Minuendo";
            vtnaOperacion.Controls[5].Text = "Sustraendo";
            vtnaOperacion.Show();
        }

        private void subMenuMultiplicarOpcEntero_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<int> vtnaOperacion = new frmOperador<int>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Multiplicacion de Enteros";
            vtnaOperacion.Controls[0].Text = "Multiplicar";
            vtnaOperacion.Controls[6].Text = "Factor 1";
            vtnaOperacion.Controls[5].Text = "Factor 2";
            vtnaOperacion.Show();
        }

        private void subMenuMultiplicarOpcFloat_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<float> vtnaOperacion = new frmOperador<float>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Multiplicacion de Floats";
            vtnaOperacion.Controls[0].Text = "Multiplicar";
            vtnaOperacion.Controls[6].Text = "Factor 1";
            vtnaOperacion.Controls[5].Text = "Factor 2";
            vtnaOperacion.Show();
        }

        private void subMnuDividirOpcEntero_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<int> vtnaOperacion = new frmOperador<int>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Division de Enteros";
            vtnaOperacion.Controls[0].Text = "Dividir";
            vtnaOperacion.Controls[6].Text = "Numerador";
            vtnaOperacion.Controls[5].Text = "Denominador";
            vtnaOperacion.Show();
        }

        private void subMnuDividirOpcFloat_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frmOperador<float> vtnaOperacion = new frmOperador<float>();
            vtnaOperacion.MdiParent = this;
            vtnaOperacion.Text = "Division de Floats";
            vtnaOperacion.Controls[0].Text = "Dividir";
            vtnaOperacion.Controls[6].Text = "Numerador";
            vtnaOperacion.Controls[5].Text = "Denominador";
            vtnaOperacion.Show();
        }

        private void opcSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}