using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UserRepository
    {
        //Variavel de conexão do BD, privada pois nao sera utilizada fora desse escopo.
        private readonly SqlConnection _connection;

        //Criando o metodo construtor da Classe e fazendo com que a _connection receba a conexão que vem do parametro do método construtor.
        public UserRepository(SqlConnection connection)
            => _connection = connection;
        

        public IEnumerable<User>GetAll()
            => _connection.GetAll<User>(); // Utilizando a ExpressionBody ( => ), retirando as chaves quando só temos 1 linha de RETORNO
        

        //Metodo GetById não é IEnumerable, pois nao retorna uma lista e sim apenas um usuraio referente ao ID passado
        public User GetById(int id)
            => _connection.Get<User>(id); // Utilizando a ExpressionBody ( => ), retirando as chaves quando só temos 1 linha de RETORNO
        

        //Metodo CreateUser recebe o objeto USER para ser persistido no BD
        //Metodo é VOID pois nao precisa retornar nada
        public void CreateUser(User user)
        {
            user.ID = 0; // Se tentar criar um usuario diferente de 0 ele seta 0 para o fulano
            _connection.Insert<User>(user);
        }        

        public void Update(User user)
        {
            if(user.id != 0) //Se o usuario for diferente de 0, faz o Update
            _connection.Update<User>(user);
        }

        public void Delete(user user)
        {
            if(user.id != 0) //Se o usuario for diferente de 0, faz o Delete
            _connection.Delete<User>(user);
        }

        public void Delete(int Id) 
        {
            if(id != 0)
            {
                var user = _connection.Get<User>(id);
                _connection.Delete<User>(user);
            }
        }

    }
}