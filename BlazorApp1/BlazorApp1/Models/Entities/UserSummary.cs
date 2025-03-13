using System;

namespace BlazorApp1.Models
{
    public class UserSummary
    {
        public Guid guid { get; set; }
        public int Id { get; set; } 

        public string UserName { get; set; }
        public string Role { get; set; }
    }
}
