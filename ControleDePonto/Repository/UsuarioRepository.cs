using ControleDePonto.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace ControleDePonto.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        IConfiguration _configuration;

        public UsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("ConexaoDB").Value;
            return connection;
        }

        public Usuario ObtemUsuario(string email, string senha)
        {
            string connection = this.GetConnection();
            string sql = @"select * from Usuario(nolock) where Email = @Email and Senha = @Senha";

            using (var con = new SqlConnection(connection))
            {
                var usuario = con.Query<Usuario>(sql, new { @Email = email, @Senha = senha}).FirstOrDefault();
                return usuario;
            }
        }
    }
}
