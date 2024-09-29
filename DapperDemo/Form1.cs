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



        private void btnObtenerId_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerPorID(tboxObtenerID.Text);
            dgvObtenerTodos.DataSource = new List<Customers> { cliente };
            if (cliente != null)
            {
                RellenarForm(cliente);
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = CrearCliente();
            var insertado = customerR.insertarCliente(nuevoCliente);
            MessageBox.Show($"{insertado} registros insertados");
        }

        private Customers CrearCliente()
        {
            var nuevo = new Customers
            {
                CustomerID = txbCustomerId.Text,
                CompanyName = txbCompanyName.Text,
                ContactName = txbContactName.Text,
                ContactTitle = txbContactTitle.Text,
                Address = txbAddress.Text
            };
            return nuevo;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var clienteActualizado = CrearCliente();
            var actualizados = customerR.ActualizarCliente(clienteActualizado);
            var cliente = customerR.ObtenerPorID(clienteActualizado.CustomerID);
            dgvObtenerTodos.DataSource = new List<Customers> { cliente };
            MessageBox.Show($"Filas actualizadas {actualizados} , {clienteActualizado.CustomerID}");

        }

        private void RellenarForm(Customers customers)
        {
            txbCustomerId.Text = customers.CustomerID;
            txbCompanyName.Text = customers.CompanyName;
            txbContactName.Text = customers.ContactName;
            txbContactTitle.Text = customers.ContactTitle;
            txbAddress.Text = customers.Address;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminadas = customerR.EliminarCliente(tboxObtenerID.Text);
            MessageBox.Show($"Se ha eliminado {eliminadas} fila de manera correcta");
        }
    }
}
