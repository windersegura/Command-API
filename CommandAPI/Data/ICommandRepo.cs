using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandRepo
    {
        public List<Command> getAllCommand();
        public Command getCommand();
    }
}