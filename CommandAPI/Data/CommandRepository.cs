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
            var commands = _context.Command.AsNoTracking();
            List<Command> _commands = new List<Command>();

            foreach (var command in commands)
            {
                _commands.Add(command);
            }

            return _commands;
        }

        public Command getCommand()
        {
            throw new NotImplementedException();
        }
    }
}