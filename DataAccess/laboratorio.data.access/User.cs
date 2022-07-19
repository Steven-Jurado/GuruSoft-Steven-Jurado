using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laboratorio.data.access
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdUser")]
        [JsonIgnore]
        public Guid IdUser { get; set; }

        public string UserName { get; set; }

        public string LastName { get; set; }

        public DateTime DateRequest { get; set; } = DateTime.Now;

        public DateTime DateResponse { get; set; } = DateTime.Now;
    }
}
