using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    class TwentyOneRules
    {
        //made it private because it will only be used in this class. Naming convention for private classes is to start with _
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        //Create method will return int array. Passes in a hand and returns int array of the possible values
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            //Find out how many aces there are. For each item were checking if the Card.Face = Ace
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            //When we know how many aces there are we can create an array. +1 because if we have two aces there is 3 possible results
            //ex: 1 + 11, 1 + 1, 11 + 11
            int[] result = new int[aceCount + 1];
            //This finds the value of a hand when Ace = 1. This takes each item and looks them up in the _cardValues and adds them
            int value = Hand.Sum(x => _cardValues[x.Face]);
            //taking the first entry in int[] and giving it a value
            result[0] = value;
            //if theres only one result then it will return the result no need for an else
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                //same as saying value = value + (i * 10);
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        //Creating a method that will return true or false, does this hand contain a blackjack
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            //Checking if value is equal to 21. If is return true if not return false
            if (value == 21) return true;
            else return false;
        }
        //method to determine if the player has busted or not. Checking min hand value and not max 
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }
        //Creating the rules for what the dealer will do with their hand
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }
        //method will return a nullable boolean. Trying to determine which hand wins.(dealer or player)
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
