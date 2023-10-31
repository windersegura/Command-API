using CommandAPI.CommandContext;
using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Data
{
    public class CommandRepository : ICommandRepo
    {
        private readonly CommandContextApi _context;
        public CommandRepository(CommandContextApi context)
        {
            _context = context;
        }
        public List<Command> getAllCommand()
        {
            try
            {
                var commands = _context.Command.AsNoTracking().ToList();
                return commands;
            }
            catch (System.Exception ex)
            {             
                throw ex;
            }
            
        }

        public Command getCommand(int id)
        {
            var command = _context.Command.Find(id);
            return command;
        }

        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}