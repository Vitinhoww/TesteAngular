using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteAngular.Models
{
    [Table("Country")]
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public float VAT { get; set; }

        public float Tax { get; set; }

    }
}
