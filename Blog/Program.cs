using System;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        //Criando a String de conexão com o BD e deixando ela disponivel para todo o Projeto
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=q1w2e3#@!; TrustServerCertificate=True;";
        static void Main(string[] args)
        {
            // ReadUsers();
            // ReadUser();
            // CreateUser();
            // UpdateUser();
            DeleteUser();

        }

        public static void ReadUsers()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();

                foreach(var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }

        public static void ReadUser()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.Get<User>(1);
                Console.WriteLine(users.Name);
            }
        }

        public static void CreateUser()
        {
            var user = new User()
            {
                Bio = "Equipe Danilo Avelar",
                Email = "Email2@email.com",
                Image = "https://danilo.com.br",
                Name = "Equipe Danilo Avelar",
                PasswordHash = "q1w2e3r4",
                Slug = "equipe-danilo"
            };

            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
            }
        }

        public static void UpdateUser()
        {
             var user = new User()
            {
                Id = 2,
                Bio = "Equipe | Danilo Avelar",
                Email = "Email2@email.com",
                Image = "https://danilo.com.br",
                Name = "Equipe de Dev - Danilo Avelar",
                PasswordHash = "q1w2e3r4",
                Slug = "equipe-danilo"
            };

            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
            }
        }

        public static void DeleteUser()
        {
            // var use = new User()
            // {
            //     Id = 2,
            // };

            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(3);
                connection.Delete<User>(user);
                Console.WriteLine("Exclusão realizada com sucesso");
            };

        }
    }
}