namespace CommandPattern.Core
{
    public interface ICommand
    {
        void ExecuteAction();

        void UndoAction();
    }
}