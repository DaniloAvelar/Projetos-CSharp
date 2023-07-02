using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class RoleRepository
    {
          //Variavel de conexão do BD, privada pois nao sera utilizada fora desse escopo.
        private readonly SqlConnection _connection;

        //Criando o metodo construtor da Classe e fazendo com que a _connection receba a conexão que vem do parametro do método construtor.
        public RoleRepository(SqlConnection connection)
            => _connection = connection;
        

        public IEnumerable<Role>GetAll()
            => _connection.GetAll<Role>(); // Utilizando a ExpressionBody ( => ), retirando as chaves quando só temos 1 linha de RETORNO
        

        //Metodo GetById não é IEnumerable, pois nao retorna uma lista e sim apenas um usuraio referente ao ID passado
        public Role GetById(int id)
            => _connection.Get<Role>(id); // Utilizando a ExpressionBody ( => ), retirando as chaves quando só temos 1 linha de RETORNO
        

        //Metodo CreateUser recebe o objeto ROLE para ser persistido no BD
        //Metodo é VOID pois nao precisa retornar nada
        public void CreateUser(Role role)
            => _connection.Insert<Role>(role); // Utilizando a ExpressionBody ( => ), retirando as chaves quando só temos 1 linha de RETORNO
    }
}
