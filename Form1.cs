using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Modelamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta menuP = new Venta();
            this.Hide();
            menuP.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Categorias menuC = new Categorias();
            this.Hide();
            menuC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Almacen menuA = new Almacen();
            this.Hide();
            menuA.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Proveedor menuPr = new Proveedor();
            this.Hide();
            menuPr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clientes menuCl = new Clientes();   
            this.Hide();
            menuCl.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Platos menuPl = new Platos();
            this.Hide();
            menuPl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cocina menuCo = new Cocina();   
            this.Hide();
            menuCo.Show();
        }
    }
}
