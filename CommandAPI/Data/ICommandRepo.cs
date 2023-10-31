using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandRepo
    {
        public List<Command> getAllCommand();
        public Command getCommand(int id);
        public void CreateCommand(Command command);
    }
}