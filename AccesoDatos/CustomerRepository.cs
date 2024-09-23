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
    }
}
