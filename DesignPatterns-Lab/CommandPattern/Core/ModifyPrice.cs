namespace CommandPattern.Core
{
    using System.Collections.Generic;
    using System.Linq;

    public class ModifyPrice
    {
        private readonly List<ICommand> commands;
        private ICommand command;

        public ModifyPrice()
        {
            this.commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void Invoke()
        {
            this.commands.Add(command);
            this.command.ExecuteAction();
        }

        public void UndoActions()
        {
            foreach (var command in Enumerable.Reverse(this.commands))
            {
                command.UndoAction();
            }
        }
    }
}
