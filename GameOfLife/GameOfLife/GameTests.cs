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
    }

    public class Cell
    {
        public Cell(int i, int i1)
        {
        }

        public bool IsAlive()
        {
            return true;
        }
    }

    public class Game
    {
    }
}
