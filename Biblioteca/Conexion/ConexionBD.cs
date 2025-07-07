using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ConexionBD
    {
        public static string CadenaConexion =
        "Server=tcp:academiapre.database.windows.net,1433;" +
        "Initial Catalog=AcademiaPre;" +
        "Persist Security Info=False;" +
        "User ID=admind123;" +
        "Password=Admin123;" +
        "MultipleActiveResultSets=False;" +
        "Encrypt=True;" +
        "TrustServerCertificate=False;" +
        "Connection Timeout=30;";
    }
}
