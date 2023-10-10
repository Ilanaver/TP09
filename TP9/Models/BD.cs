using System.Data.SqlClient;
using Dapper;

public static class BD {
    public static string _connectionString = @"Server=localhost;DataBase=Login;Trusted_Connection=True;";
    //funciones:
    public static void Registro(Usuario user) {
        string SQL = "INSERT INTO Usuario (Username, Contraseña, Email, Nombre, Apellido0) VALUES (@pUsername, @pContraseña, @pEmail, @pNombre, @pApellido);";
        using (SqlConnection db = new SqlConnection(_connectionString)) {
            db.Execute(SQL, new{@pUsername = user.Username, @pContraseña = user.Contraseña, @pEmail = user.Email, @pNombre = user.Nombre, @pApellido = user.Apellido});
        }
    }
    public static Usuario InfoUser(string User, string Pass) {
        Usuario devolver = new Usuario();
        string SQL = "SELECT * FROM Usuario WHERE Username = @pUser AND Contrseña = @pPass;";
        using (SqlConnection db = new SqlConnection(_connectionString)) {
            devolver = db.Query<Usuario>(SQL, new {@pUser = User, @pPass = Pass}).FirstOrDefault();
        }
        return devolver;
    }
    public static List<Usuario> ListaUsuarios(int Iduser) {
        List<Usuario> listaUsuarios = new List<Usuario>();
        string SQL = "SELECT * FROM Usuario WHERE IdUsuario = @pIdUser;";
        using (SqlConnection db = new SqlConnection(_connectionString)) {
            listaUsuarios = db.Query<Usuario>(SQL, new {@pIdUser = Iduser}).ToList();
        }
        return listaUsuarios;
    }
}