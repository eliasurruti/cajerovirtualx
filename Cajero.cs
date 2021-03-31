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
    public partial class Cajero : Form
    {
        Movimientos mod = new Movimientos();
        int monto;
        string tipo;
        int nro;
        public Cajero()
        {
            InitializeComponent();
            lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
           
        }
             
        //Menu buttons


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
      
        }
        private void btnRetiro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }
        private void btnTransf_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }


        //Back buttons


        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btBack3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btBack4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        private void btBack5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        private void btBack6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        private void btBack7_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(0);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }


        //Exit Buttons


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btExit4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btExit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btExit7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btExit6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btExit5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //100 buttons


        private void bt100_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 100;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(5);
                mod.monto = 100;
                monto = mod.monto;
                lblTransferencia.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Transferencia";
                tipo = mod.tipo;
            }
            else
            {              
                 tabControl1.SelectTab(8);
                 lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);             
            }
        }

        private void bt_100_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 100;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(6);
                mod.monto = 100;
                monto = mod.monto;
                lblRetiro.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Extraccion";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            mod.saldo = mod.saldo + 100;
            lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
            tabControl1.SelectTab(7);
            mod.monto = 100;
            monto = mod.monto;
            lblDeposito.Text = "$ " + Convert.ToString(mod.monto);
            mod.tipo = "Deposito";
            tipo = mod.tipo;
        }

        
        //200 buttons


        private void bt200_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 200;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(5);
                mod.monto = 200;
                monto = mod.monto;
                lblTransferencia.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Transferencia";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }

        }

        private void bt_200_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 200;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(6);
                mod.monto = 200;
                monto = mod.monto;
                lblRetiro.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Extraccion";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            mod.saldo = mod.saldo + 200;
            lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
            tabControl1.SelectTab(7);
            mod.monto = 200;
            monto = mod.monto;
            lblDeposito.Text = "$ " + Convert.ToString(mod.monto);
            mod.tipo = "Deposito";
            tipo = mod.tipo;
        }


        //500 buttons


      

        private void bt_500_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 500;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(6);
                mod.monto = 500;
                monto = mod.monto;
                lblRetiro.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Extraccion";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
        }

        private void bt500_Click_1(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 500;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(5);
                mod.monto = 500;
                monto = mod.monto;
                lblTransferencia.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Transferencia";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            mod.saldo = mod.saldo + 500;
            lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
            tabControl1.SelectTab(7);
            mod.monto = 500;
            monto = mod.monto;
            lblDeposito.Text = "$ " + Convert.ToString(mod.monto);
            mod.tipo = "Deposito";
            tipo = mod.tipo;
        }


        //1000 buttons


        private void btn1000_Click(object sender, EventArgs e)
        {
            mod.saldo = mod.saldo + 1000;
            lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
            tabControl1.SelectTab(7);
            mod.monto = 1000;
            monto = mod.monto;
            lblDeposito.Text = "$ " + Convert.ToString(mod.monto);
            mod.tipo = "Deposito";
            tipo = mod.tipo;
        }

        private void bt_1000_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 1000;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(6);
                mod.monto = 1000;
                monto = mod.monto;
                lblRetiro.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Extraccion";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
        }

        private void bt500_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 1000;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(5);
                mod.monto = 1000;
                monto = mod.monto;
                lblTransferencia.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Transferencia";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
        }


        //2000 buttons


        private void bt2000_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 2000;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(5);
                mod.monto = 2000;
                monto = mod.monto;
                lblTransferencia.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Transferencia";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
        }

        private void bt_2000_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 2000;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(6);
                mod.monto = 2000;
                monto = mod.monto;
                lblRetiro.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Extraccion";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
        }
        private void btn2000_Click(object sender, EventArgs e)
        {
            mod.saldo = mod.saldo + 2000;
            lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
            tabControl1.SelectTab(7);
            mod.monto = 2000;
            monto = mod.monto;
            lblDeposito.Text = "$ " + Convert.ToString(mod.monto);
            mod.tipo = "Deposito";
            tipo = mod.tipo;
        }
        
        //5000 buttons


        private void btn5000_Click(object sender, EventArgs e)
        {           
            mod.saldo = mod.saldo + 5000;
            lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
            tabControl1.SelectTab(7);
            mod.monto = 5000;
            monto = mod.monto;
            lblDeposito.Text = "$ " + Convert.ToString(mod.monto);
            mod.tipo = "Deposito";
            tipo = mod.tipo;
        }

        private void bt_5000_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 5000;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(6);
                mod.monto = 5000;
                monto = mod.monto;
                lblRetiro.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Extraccion";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
        }

        private void bt5000_Click(object sender, EventArgs e)
        {
            if (mod.monto <= mod.saldo)
            {
                mod.saldo = mod.saldo - 5000;
                lblSaldo.Text = "$ " + Convert.ToString(mod.saldo);
                tabControl1.SelectTab(5);
                mod.monto = 5000;
                monto = mod.monto;
                lblTransferencia.Text = "$ " + Convert.ToString(mod.monto);
                mod.tipo = "Transferencia";
                tipo = mod.tipo;
            }
            else
            {
                tabControl1.SelectTab(8);
                lblDisponible.Text = "$ " + Convert.ToString(mod.saldo);
            }
            
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Form ticket = new Ticket1(monto,tipo);
            ticket.Show();
        }

        private void btnTicket3_Click(object sender, EventArgs e)
        {
            Ticket1 ticket = new Ticket1(monto,tipo);
            ticket.Show();
        }

        private void btnTicket2_Click(object sender, EventArgs e)
        {
            Ticket1 ticket = new Ticket1(monto, tipo);
            ticket.Show();
        }

      
    }
}
