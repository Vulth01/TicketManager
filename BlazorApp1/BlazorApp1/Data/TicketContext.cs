using BlazorApp1.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace BlazorApp1.Data;

public class TicketContext : DbContext
{
    public TicketContext (DbContextOptions<TicketContext> options) : base(options)
    {

    }

    public DbSet<BlazorApp1.Models.Ticket> Tickets { get; set; } = default!;

    public DbSet<UserAccount> UserAccounts { get; set; } = default!;

}