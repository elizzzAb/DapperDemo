using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
    public partial class Form1 : Form
    {
        CustomerRepository customerR = new CustomerRepository(); //define que elementos se ejecutan dentro del customerRepository

        public Form1()
        {
            InitializeComponent();
        }

        public void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerTodo();
            dgvObtenerTodos.DataSource = cliente;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //borde azul xd
        }

        private void btnObtenerId_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerPorID(tboxObtenerID.Text);
            dgvObtenerTodos.DataSource = new List<Customers> { cliente };

        }
    }
}
