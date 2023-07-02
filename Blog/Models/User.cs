using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    //Notação para apelidar a tabela da Pluralização do SQL
    //Buscando por Dapper.Contrib o USING
    //Sempre usar o COlchetes para nomear a tabela corretamente, por causa de nomes Reservados
    [Table("[User]")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }   
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
    }
}