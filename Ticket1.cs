using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using back;


namespace cajerox
{
    public partial class Ticket1 : Form
    {
        int nro = 1;
        string tipo;
        int monto;
        
        public Ticket1 (int monto, string tipo)
        {
            nro += 1;
            InitializeComponent();
            this.tipo = tipo;
            this.monto = monto;
            DateTime hoy = DateTime.Now;
            lblFecha.Text = hoy.ToShortDateString();
            lblHora.Text = hoy.ToShortTimeString();
            lblImporte.Text = "$" +Convert.ToString( monto);
            lblTipo.Text = tipo;
            lblNro.Text = Convert.ToString(nro);
        }
        
        private void btHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
