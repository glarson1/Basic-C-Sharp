using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{ // ********* adding a ":" and then the class "Game"  MEANS TWENTYONEGAME IS INHERITING FROM GAME
    //THIS AVOIDS HAVING TO REWRITE CODE ...Also is able to also inherit from IWalkAway because IWalkAway is an interface
    //and not a class. You can only inherit one class but can inherit multiple interfaces
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        //override keyword satisfies that we are using the abstract method Play from abstract Game class
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            //Players is a list class from the class Players
            foreach (Player player in Players)
            {
                //we want the players hand to change after each round
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            //also want the dealers hand to be a new hand
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            //created a new deck each time to avoid card counting and have a full deck
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                //if successfullyBet is false
                if (!successfullyBet)
                {
                    //This means end this method and go back to the while loop in program.cs which will restart this play()
                    return;
                }
                //if the bet was successfull. Bets = the dictionary, player = the key for key value pair
                Bets[player] = bet;
            }
            //going to do this twice so i < 2
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    //Console.Write is different than writeLine. it means lets write something to the console but not
                    //automatically press enter. So the next thing thats after it won't be on a new line
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    //this means its now the second round
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {       //Bets[player] is the amount the player bet on that hand
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            //gives his bet back plus 1.5 times his bet for the blackjack
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            //Once player gets blackjack that round is now over
                            return;
                        }
                    }
                }
                //doing what we did above but for dealer
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!");
                        //takes the bets of the players and give to dealer because dealer wins
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break; //break ends the loop
                    }
                    else if (answer == "hit") ;
                    {
                        Dealer.Deal(player.Hand);
                    }
                    //all of this is to check if the player is busted
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Hand, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "ya" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }

                    }
                }
            }
            //Now this is to check if the dealer is busted
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    //looping through each key value pair and finding the person in the list where the name matches the entry
                    //and take their balance and add what they bet times two
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    //Dealer loses so we take away the winnings
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            //This will be for the scenario where both the dealer and the player dont bust and we 
            //have to determines who wins out of the two
            foreach (Player player in Players)
            {
                //this allows us to assign null to the value
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                //null would mean that it's a push. Neither dealer nor player wins but player gets to keep his wager
                if (playerWon == null)
                {
                    player.Balance += Bets[player];
                }
                //true means the player won and gets *2 his money. while the dealer loses
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "ya" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                    return;
                }
                else
                {
                    player.isActivelyPlaying = false;
                    return;
                }
            }
           
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
