using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPOSCSharpMySQL.Configuracion
{
    internal class CConexion
    {
        private MySqlConnection conectar = null;

        private static string usuario = "root";
        private static string contraseña = "BD@agus";
        private static string bd = "bdpos";
        private static string ip = "localhost";
        private static string puerto = "3306";

        private string cadena = $"Server={ip};Port={puerto};Database0{bd};Uid={usuario};Pwd={contraseña};";

        public MySqlConnection EstableceConexion()
        {
            try
            {

                conectar = new MySqlConnection(cadena);
                conectar.Open();
                MessageBox.Show("Se conecto a la Base de Datos");

            }

            catch (Exception e) {

                MessageBox.Show("No se conecto a la Base de Datos");

            }

            return conectar;

        }

        public void CerrarConexion() {

            try
            {

                if (conectar != null && conectar.State == System.Data.ConnectionState.Open)

                    conectar.Close();

                MessageBox.Show("Se cerro la conexxion a la Base de Datos");

            }
            
            catch (Exception e) 
            {
                MessageBox.Show("No se cerro la conexion a la Base de Datos" + e.ToString());
            }

        }
    }
}
