using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChessDemo
{
    class BoardViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ChessPiece> _pieces;
        private MainWindow _board;

        private ButtonClick objCommand;
        public ObservableCollection<ChessPiece> Pieces
        {
            get { return _pieces; }
        }
        public event PropertyChangedEventHandler PropertyChanged;


        public BoardViewModel()
        {
            _board = new MainWindow();

            _pieces = _board.Pieces;
            objCommand = new ButtonClick(this);
        }

        public void DoMove()
        {
            _board.Move();

            if (PropertyChanged != null) // Point 2
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Pieces"));
                // Point 3
            }
        }

        public ICommand btnClick // Point 3
        {
            get
            {
                return objCommand;
            }
        }
    }
}
