using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    //Notação para apelidar a tabela da Pluralização do SQL
    //Buscando por Dapper.Contrib o USING
    //Sempre usar o Colchetes para nomear a tabela corretamente, por causa de nomes Reservados
    [Table("[Role]")]
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}