using Command.Interfaces;
using System.Collections.Generic;


namespace Command.Command
{
    public class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);

            command.Execute();
        }
    }
}
