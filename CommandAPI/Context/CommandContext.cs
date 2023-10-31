using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.CommandContext
{
    public class CommandContextApi : DbContext 
    {
        public CommandContextApi(DbContextOptions<CommandContextApi> options) : base(options)
        {

        }

        public DbSet<Command> Command {get;set;}
    }
}