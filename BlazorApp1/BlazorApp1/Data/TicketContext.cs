using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public class TicketContext : DbContext
    {
        public TicketContext (DbContextOptions<TicketContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp1.Models.DocumentDetails> DocumentDetails { get; set; } = default!;
    }
}
