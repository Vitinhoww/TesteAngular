using System.ComponentModel.DataAnnotations;

namespace TesteAngular.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public float VAT { get; set; }

        public float Tax { get; set; }

    }
}
