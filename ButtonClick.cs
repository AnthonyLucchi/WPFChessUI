using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChessDemo
{
    class ButtonClick : ICommand
    {
        private BoardViewModel _model;

        public ButtonClick(BoardViewModel m)
        {
            _model = m;
        }
        public bool CanExecute(object parameter)
        {
            // When to execute
            // Validation logic goes here
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            // What to Execute
            // Execution logic goes here
            _model.DoMove();
        }
    }
}
