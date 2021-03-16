using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoveWaffle_API.Models
{
    public class User
    {
        [Column("ID")]
        [Key]
        [Required]
        public Guid ID { get; set; }
        [Column("UserName")]
        [Required]
        public string UserName { get; set; }
        [Column("JoinDate")]
        [Required]
        public DateTime JoinDate { get; set; }
    }
}
