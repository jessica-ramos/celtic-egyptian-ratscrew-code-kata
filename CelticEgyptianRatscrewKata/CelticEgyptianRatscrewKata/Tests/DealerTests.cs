﻿using System.Collections.Generic;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class DealerTests
    {
        [Test]
        public void DealingAnEmptyDeckToOnePile()
        {
            var deck = Cards.Empty();
            var dealer = new Dealer();

            var hands = dealer.Deal(1, deck);

            var expectedHands = new List<Cards> { Cards.Empty() };
            CollectionAssert.AreEqual(expectedHands, hands);
        }

        [Test]
        public void DealingOneCardToOnePile()
        {
            var deck = new Cards(new List<Card> {new Card(Suit.Clubs, Rank.Ace)});
            var dealer = new Dealer();

            var hands = dealer.Deal(1, deck);

            var expectedHands = new List<Cards> {new Cards(new List<Card> {new Card(Suit.Clubs, Rank.Ace)})};
            CollectionAssert.AreEqual(expectedHands, hands);
        }

        [Test]
        public void DealingThreeCardsToThreePiles()
        {
            var deck = new Cards(new List<Card>
                                 {
                                     new Card(Suit.Clubs, Rank.Ace),
                                     new Card(Suit.Clubs, Rank.Two),
                                     new Card(Suit.Clubs, Rank.Three)
                                 });
            var dealer = new Dealer();

            var hands = dealer.Deal(3, deck);

            var expectedHands = new List<Cards>
                                {
                                    new Cards(new List<Card> { new Card(Suit.Clubs, Rank.Ace) }),
                                    new Cards(new List<Card> { new Card(Suit.Clubs, Rank.Two) }),
                                    new Cards(new List<Card> { new Card(Suit.Clubs, Rank.Three) })
                                };
            CollectionAssert.AreEqual(expectedHands, hands);
        }
    }
}