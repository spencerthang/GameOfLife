using System.Collections.Generic;
using NUnit.Framework;

namespace GameOfLife
{
    public class GameTests
    {
        [Test]
        public void CellIsAliveByDefault()
        {
            var cell = new Cell(0, 0);
            Assert.That(cell.IsAlive(), Is.True);
        }

        [Test]
        public void CanAddCellToGame()
        {
            var game = new Game();
            var cell = new Cell(0, 0);
            game.AddCell(cell);
            Assert.AreEqual(1, game.CellCount);
        }

        [Test]
        public void IsCellAlive()
        {
            var game = new Game();
            var cell = new Cell(1, 2);
            game.AddCell(cell);
            Assert.That(game.CellIsAlive(1, 2), Is.True);
        }

        [Test]
        public void DeadCellIsNotAlive()
        {
            var game = new Game();
            Assert.That(game.CellIsAlive(1, 2), Is.False);
        }
    }

    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsAlive()
        {
            return true;
        }
    }

    public class Game
    {
        private List<Cell> m_Cells = new List<Cell>();
        public int CellCount { get { return m_Cells.Count;  } }

        public void AddCell(Cell cell)
        {
            m_Cells.Add(cell);
        }


        public bool CellIsAlive(int x, int y)
        {
            var cell = m_Cells.Find(c => c.X == x && c.Y == y);
            return cell != null && cell.IsAlive();
        }
    }
}
