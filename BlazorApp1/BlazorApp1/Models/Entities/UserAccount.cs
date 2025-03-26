using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models.Entities
{
    [Table("user_account")]
    public class UserAccount
    {
        public Guid guid { get; set; } = Guid.NewGuid();
        public int Id { get; set; }

        public string UserName { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Role { get; set; }

        public byte[] Salt { get; set; }
    }
}
