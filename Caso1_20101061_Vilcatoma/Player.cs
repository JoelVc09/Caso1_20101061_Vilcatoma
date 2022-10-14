using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Caso1_20101061_Vilcatoma
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        public int Dorsal { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public bool DateOfBirth { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public bool ACountry { get; set; }

    }
}
