﻿using System.Collections.Generic;
using Main.Domain.DefuseAttempts;
using Main.Domain.Players;
using NUnit.Framework;

namespace Test.Editor.Domain.DefuseAttempts
{
    [TestFixture]
    public class DefuseAttemptTest
    {
        private readonly Player _player1 = new Player("player1");
        private readonly Player _player2 = new Player("player2");
        private readonly Player _player3 = new Player("player3");

        [Test]
        public void IsDefuser_ShouldReturnTrueWithDefuserPlayer()
        {
            // Given
            var defuserPlayers = new List<Player> {_player1, _player2};
            var defuseAttempt = new DefuseAttempt(defuserPlayers);
            
            // When
            var isDefuser = defuseAttempt.IsDefuser(_player1);
            
            // Then
            Assert.IsTrue(isDefuser);
        }

        [Test]
        public void IsDefuser_ShouldReturnFalseWithNotDefuserPlayer()
        {
            // Given
            var defuserPlayers = new List<Player> {_player1, _player2};
            var defuseAttempt = new DefuseAttempt(defuserPlayers);
            
            // When
            var isDefuser = defuseAttempt.IsDefuser(_player3);
            
            // Then
            Assert.IsFalse(isDefuser);
        }


//
//        [Test]
//        public void IsDefuser_ShouldReturnTrueForLastPlayerAndFalseForOthers_WhenRandomReturnMaxValue_WithThreePlayers()
//        {
//            // Given
//            var players = new List<Player> {_player1, _player2, _player3};
//
//            _random.Range(Arg.Any<int>(), Arg.Any<int>())
//                .Returns(players.Count - 1);
//
//            var defuseAttempt = new DefuseAttempt(_random, players);
//
//            // When
//            var isPlayer1Defuser = defuseAttempt.IsDefuser(_player1);
//            var isPlayer2Defuser = defuseAttempt.IsDefuser(_player2);
//            var isPlayer3Defuser = defuseAttempt.IsDefuser(_player3);
//
//            // Then
//            Assert.IsFalse(isPlayer1Defuser);
//            Assert.IsFalse(isPlayer2Defuser);
//            Assert.IsTrue(isPlayer3Defuser);
//        }
//
//        [Test]
//        public void IsDefuser_ShouldReturnTrueForTwoFirstPlayersAndFalseForOthers_WhenRandomReturnAlwaysZero_WithFivePlayers()
//        {
//            // Given
//            var players = new List<Player> {_player1, _player2, _player3, _player4, _player5};
//
//            _random.Range(Arg.Any<int>(), Arg.Any<int>())
//                .Returns(0);
//            
//            var defuseAttempt = new DefuseAttempt(_random, players);
//            
//            // When
//            var isPlayer1Defuser = defuseAttempt.IsDefuser(_player1);
//            var isPlayer2Defuser = defuseAttempt.IsDefuser(_player2);
//            var isPlayer3Defuser = defuseAttempt.IsDefuser(_player3);
//            var isPlayer4Defuser = defuseAttempt.IsDefuser(_player4);
//            var isPlayer5Defuser = defuseAttempt.IsDefuser(_player5);
//            
//            // Then
//            Assert.IsTrue(isPlayer1Defuser);
//            Assert.IsTrue(isPlayer2Defuser);
//            Assert.IsFalse(isPlayer3Defuser);
//            Assert.IsFalse(isPlayer4Defuser);
//            Assert.IsFalse(isPlayer5Defuser);
//        }
//
//        [Test]
//        public void IsDefuser_ShouldReturnTrueForTwoLastPlayersAndFalseForOthers_WhenRandomReturnMaxValue_WithSixPlayers()
//        {
//            // Given
//            var players = new List<Player> {_player1, _player2, _player3, _player4, _player5, _player6};
//
//            _random.Range(0, 6).Returns(5);
//            _random.Range(0, 5).Returns(4);
//            
//            var defuseAttempt = new DefuseAttempt(_random, players);
//            
//            // When
//            var isPlayer1Defuser = defuseAttempt.IsDefuser(_player1);
//            var isPlayer2Defuser = defuseAttempt.IsDefuser(_player2);
//            var isPlayer3Defuser = defuseAttempt.IsDefuser(_player3);
//            var isPlayer4Defuser = defuseAttempt.IsDefuser(_player4);
//            var isPlayer5Defuser = defuseAttempt.IsDefuser(_player5);
//            var isPlayer6Defuser = defuseAttempt.IsDefuser(_player6);
//            
//            // Then
//            Assert.IsFalse(isPlayer1Defuser);
//            Assert.IsFalse(isPlayer2Defuser);
//            Assert.IsFalse(isPlayer3Defuser);
//            Assert.IsFalse(isPlayer4Defuser);
//            Assert.IsTrue(isPlayer5Defuser);
//            Assert.IsTrue(isPlayer6Defuser);
//        }
    }
}
