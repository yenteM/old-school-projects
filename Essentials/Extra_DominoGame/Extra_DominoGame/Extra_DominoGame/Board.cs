using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Extra_DominoGame
{
    internal class Board
    {
        private readonly Block[,] _board;
        private readonly int _boardDimension;
        private readonly StreamWriter _movesOutput;
        private string _blockPosition;
        private string _nextBlockPosition;


        public Board(int boardDimension, Canvas drawCanvas)
        {
            _boardDimension = boardDimension;
            _board = new Block[boardDimension, boardDimension];
            CurrentPlayer = 1;

            var movesDestination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var newFile = Path.Combine(movesDestination, "domino.txt");
            _movesOutput = File.CreateText(newFile);

            for (var i = 0; i < boardDimension; i++)
            for (var j = 0; j < boardDimension; j++)
                _board[i, j] = new Block(boardDimension, drawCanvas, i, j);
        }

        public int CurrentPlayer { get; private set; }

        public void ColorBlock(Point point)
        {
            var currentBlock = FindCurrentBlock(point);
            var nextBlock = FindNextBlock(currentBlock);

            if (nextBlock == null)
                throw new DominoException("Move not possible, block outside range.");

            if (currentBlock.CheckBlockColor() && nextBlock.CheckBlockColor()) //add isMovePossible() where?
            {
                _blockPosition = $"[{currentBlock.Row + 1},{currentBlock.Column + 1}]";
                _nextBlockPosition = $"[{nextBlock.Row + 1},{nextBlock.Column + 1}]";

                _movesOutput.WriteLine($"Player{CurrentPlayer} {_blockPosition} \t {_nextBlockPosition}");

                if (CurrentPlayer == 1)
                {
                    currentBlock.FillColor(Colors.Blue);
                    nextBlock.FillColor(Colors.Blue);
                    CurrentPlayer = 2;
                }
                else
                {
                    currentBlock.FillColor(Colors.Red);
                    nextBlock.FillColor(Colors.Red);
                    CurrentPlayer = 1;
                }
            }
            else
            {
                throw new DominoException("Move not possible!");
            }
        }

        private Block FindCurrentBlock(Point point)
        {
            for (var i = 0; i < _boardDimension; i++)
            for (var j = 0; j < _boardDimension; j++)
                if (_board[i, j].ContainsPoint(point))
                    return _board[i, j];

            throw new DominoException("Block not found!");
        }

        private Block FindNextBlock(Block currentBlock)
        {
            if (CurrentPlayer == 1)
            {
                if (currentBlock.Row + 1 >= _boardDimension)
                    return null;
                return _board[currentBlock.Row + 1, currentBlock.Column];
            }
            if (currentBlock.Column + 1 >= _boardDimension)
                return null;
            return _board[currentBlock.Row, currentBlock.Column + 1];
        }

        public string GetBlokPosition()
        {
            return _blockPosition;
        }

        public bool IsMovePossible()
        {
            for (var i = 0; i < _boardDimension; i++)
            for (var j = 0; j < _boardDimension; j++)
            {
                var currentBlock = _board[i, j];
                var nextBlock = FindNextBlock(currentBlock);

                if (nextBlock != null && currentBlock.CheckBlockColor() && nextBlock.CheckBlockColor())
                    return true;
            }
            return false;
        }

        public void EndGame()
        {
            _movesOutput.Close();
        }
    }
}