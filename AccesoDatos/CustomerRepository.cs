using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public List<Customers> ObtenerTodo()
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String selectAll = "";
                selectAll = selectAll + "SELECT [CustomerID] " + "\n";
                selectAll = selectAll + "      ,[CompanyName] " + "\n";
                selectAll = selectAll + "      ,[ContactName] " + "\n";
                selectAll = selectAll + "      ,[ContactTitle] " + "\n";
                selectAll = selectAll + "      ,[Address] " + "\n";
                selectAll = selectAll + "      ,[City] " + "\n";
                selectAll = selectAll + "      ,[Region] " + "\n";
                selectAll = selectAll + "      ,[PostalCode] " + "\n";
                selectAll = selectAll + "      ,[Country] " + "\n";
                selectAll = selectAll + "      ,[Phone] " + "\n";
                selectAll = selectAll + "      ,[Fax] " + "\n";
                selectAll = selectAll + "  FROM [dbo].[Customers]";
                var cliente = conexion.Query<Customers>(selectAll).ToList(); //error
                return cliente;
            }
        }

        public Customers ObtenerPorID(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {

                String selectPorID = "";
                selectPorID = selectPorID + "SELECT [CustomerID] " + "\n";
                selectPorID = selectPorID + "      ,[CompanyName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactTitle] " + "\n";
                selectPorID = selectPorID + "      ,[Address] " + "\n";
                selectPorID = selectPorID + "      ,[City] " + "\n";
                selectPorID = selectPorID + "      ,[Region] " + "\n";
                selectPorID = selectPorID + "      ,[PostalCode] " + "\n";
                selectPorID = selectPorID + "      ,[Country] " + "\n";
                selectPorID = selectPorID + "      ,[Phone] " + "\n";
                selectPorID = selectPorID + "      ,[Fax] " + "\n";
                selectPorID = selectPorID + "  FROM [dbo].[Customers] " + "\n";
                selectPorID = selectPorID + "  WHERE CustomerID = @CustomerID";

                var Cliente = conexion.QueryFirstOrDefault<Customers>(selectPorID, new { CustomerID = id });
                return Cliente;
            }
        }

        public int insertarCliente(Customers customer)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String Insertar = "";
                Insertar = Insertar + "INSERT INTO [dbo].[Customers] " + "\n";
                Insertar = Insertar + "           ([CustomerID] " + "\n";
                Insertar = Insertar + "           ,[CompanyName] " + "\n";
                Insertar = Insertar + "           ,[ContactName] " + "\n";
                Insertar = Insertar + "           ,[ContactTitle] " + "\n";
                Insertar = Insertar + "           ,[Address]) " + "\n";
                Insertar = Insertar + "     VALUES " + "\n";
                Insertar = Insertar + "           (@customerID " + "\n";
                Insertar = Insertar + "           ,@companyName " + "\n";
                Insertar = Insertar + "           ,@contactName " + "\n";
                Insertar = Insertar + "           ,@contactTitle " + "\n";
                Insertar = Insertar + "           ,@address)";
                var insertadas = conexion.Execute(Insertar, new
                {
                    customerID = customer.CustomerID,
                    CompanyName = customer.CompanyName,
                    ContactName = customer.ContactName,
                    ContactTitle = customer.ContactTitle,
                    Address = customer.Address,
                });
                return insertadas;
            }
        }

        public int ActualizarCliente(Customers customers)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String UpdateCustomer = "";
                UpdateCustomer = UpdateCustomer + "UPDATE [dbo].[Customers] " + "\n";
                UpdateCustomer = UpdateCustomer + "   SET [CustomerID] = @CustomerID " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[CompanyName] = @CompanyName " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[ContactName] = @ContactName " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[ContactTitle] = @ContactTitle " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[Address] = @Address " + "\n";
                UpdateCustomer = UpdateCustomer + " WHERE CustomerID = @CustomerID";

                var actualizadas =
                    conexion.Execute(UpdateCustomer, new
                    {
                        CustomerID = customers.CustomerID,
                        CompanyName = customers.CompanyName,
                        ContactName = customers.ContactName,
                        ContactTitle = customers.ContactTitle,
                        Address = customers.Address
                    });
                return actualizadas;
            }
        }
    }
}
