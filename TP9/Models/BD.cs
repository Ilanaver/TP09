using System.Data.SqlClient;
using Dapper;

public static class BD {
    public static string _connectionString = @"Server=localhost;DataBase=Login;Trusted_Connection=True;";
    //funciones:
    public static void Registro(Usuario username) {
        string SQL = "INSERT INTO Usuario (Username, Contraseña, Email, Nombre, Apellido0) VALUES (@pUsername, @pContraseña, @pEmail, @pNombre, @pApellido);";
        using (SqlConnection db = new SqlConnection(_connectionString)) {
            db.Execute(SQL, new{@pUsername = user.Username, @pContraseña = user.Contraseña, @pEmail = user.Email, @pNombre = user.Nombre, @pApellido = user.Apellido});
        }
    }
    public static List<Usuario> InfoUser(int Iduser) {
        List<Usuario> infousuario = new List<Usuario>();
        string SQL = "SELECT * FROM Usuario WHERE IdUsuario = @pIdUser;";
        using (SqlConnection db = new SqlConnection(_connectionString)) {
            infousuario = db.Query<Usuario>(SQL, new {@pIdUser = Iduser}).ToList();
        }
        return infousuario;
    }
    public static void CambiarContraseña(string us, string nuevaContra)
    {
        using (SqlConnection BD = new SqlConnection(connectionString))
        {
            string sql = "UPDATE Usuario SET Contraseña=@pNuevaContraseña WHERE Username= @pUsername";
            BD.Execute(sql, new { pNuevaContraseña = nuevaContra, @pUsername = us });
        }
    }
    public static string GetPassByUser(string user)
    {
        string contraseña;
        using (SqlConnection BD = new SqlConnection(connectionString))
        {
            string sql = "SELECT Contraseña FROM Usuario WHERE Username=@pUsername";
            contraseña = BD.QueryFirstOrDefault<string>(sql, new { @pUsername = user });
        }
        return contraseña;
    }
}