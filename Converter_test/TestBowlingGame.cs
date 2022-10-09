
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;
using BowlingGame;

namespace Converter_test

{
    [TestClass]
    
    public class TestBowlingGame
    {
        private Game _game;

        
        public void SetUp()
        {
            _game = new Game();
        }
        
        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                _game.Roll(pins);
            }
        }
       
        private void RollSpare()
        {
            _game.Roll(6);
            _game.Roll(4);
        }


        [TestMethod]
        public void TestGameClass()
        {
            Assert.AreEqual(_game, typeof(Game));
        }

        [TestMethod]
        public void TestGutterGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(_game.Score, 0);
        }

        [TestMethod]
        public void TestAllOnes()
        {
            RollMany(20, 1);

            Assert.AreEqual(_game.Score, 20);
        }

        [TestMethod]
        public void TestOneSpare()
        {
            RollSpare();
            _game.Roll(4);
            RollMany(17, 0);
            Assert.AreEqual(_game.Score, 18);
        }

        [TestMethod]
        public void TestOneStrike()
        {
            _game.Roll(10);
            _game.Roll(4);
            _game.Roll(5);
            RollMany(17, 0);

            Assert.AreEqual(_game.Score, 28);
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            RollMany(12, 10);

            Assert.AreSame(_game.Score, 300);
        }
    }
}