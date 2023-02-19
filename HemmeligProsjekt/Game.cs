using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmeligProsjekt
{
    public class Game
    {
        public bool CorrectGiftSelected { get; set; } = false;

        public void PlayGame()
        {
            //Part 1 of game
            IO.PrintWelcomeMessagePart1();

            while (true)
            {
                IO.PrintGifts();
                IO.PrintAskToRoll();
                CheckTomasAnswer(IO.InputYesOrNo());
                GivePrize(RollDice());
                break;
            }

            //Part 2 of game
            IO.PrintWelcomeMessagePart2();
            while (CorrectGiftSelected == false)
            {
                IO.PrintAskToSelectGift();
                GivePrize(IO.InputNumber());
            }

            IO.BirthdaySong();
            IO.PrintBirthdayCake();

        }
        public void CheckTomasAnswer(bool tomasAnswer)
        {
            if (tomasAnswer)
            {
                IO.PrintRollDice();
            }
            else
            {
                IO.PrintTomasTriesToAvoidToPlay();
                IO.PrintRollDice();
            }
        }
        public int RollDice()
        {
            //Dice will always return 0 because we can't afford the other gifts
            return 0;
        }

        public void GivePrize(int number)
        {
            switch (number)
            {
                case 0:
                    IO.PrintConsolationPrize();
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    IO.PrintExcuseForNotGivingGift(number);
                    break;
                case 6:
                    IO.PrintWonFruitBasket();
                    CorrectGiftSelected = true;
                    break;
                default:
                    IO.PrintUnknownError();
                    break;
            }
        }
    }
}
