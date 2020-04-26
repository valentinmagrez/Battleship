﻿using Battleship.Server.Models;
using NFluent;
using NUnit.Framework;

namespace Battleship.Server.Tests.Models
{
    [TestFixture]
    class CreateGameTest
    {
        [Test]
        public void ReturnCorrectUrlToken()
        {
            var game = Game.Create();

            Check.That(game.UrlId).IsNotNull();
            Check.That(game.UrlId.Length).IsEqualTo(32);
        }
    }
}
