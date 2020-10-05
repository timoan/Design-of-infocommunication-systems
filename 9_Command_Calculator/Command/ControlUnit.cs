using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /*блок управления должен сохранять историю использования команд, а также
отменять и восстанавливать ранее выполненные команды;*/
    class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;
        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }
        public void ExecuteCommand() //выполнение
        {
            commands[current].Execute(); current++;
        }
        public void Undo() //отмена
        {
            commands[current - 1].UnExecute();
        }
        public void Undo(int n) //отмена
        {
            commands[current - n].UnExecute();
        }
        public void Redo() //повтор
        {
            commands[current - 1].Execute();
        }
        public void Redo(int n) //повтор
        {
            commands[current - n].Execute();
        }
    }
}
