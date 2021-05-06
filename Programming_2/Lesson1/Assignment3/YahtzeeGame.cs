using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class YahtzeeGame
    {
        const int DICESIZE = 5;
        Dice[] dices = new Dice[DICESIZE];

        //public List<Dice[]> listThreeOfAKind = new List<Dice[]>();
        //public List<Dice[]> listFourOfAKind = new List<Dice[]>();

        public int ThreeOfAKind = 0;
        public int FourOfAKind = 0;
        public int FullHouse = 0;
        public int SmallStreet = 0;
        public int BigStreet = 0;

        public void Init()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new Dice();
            }

    }

        public void Throw()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].Throw();
            }
        }
        
        public void DisplayValues()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].DisplayValue();
            }

            Console.WriteLine();

        }

        public bool Yahtzee()
        {
            int num = dices[0].value;
            for (int i = 1; i < dices.Length; i++)
            {
                if (num != dices[i].value)
                    return false;
            }

            return true;
        }

        public bool IsThreeOfAKind()
        {
            bool returnValue = IsNumOfAKind(3);
            //if (returnValue)
            //    listThreeOfAKind.Add(dices);
            return returnValue;
        }

        public bool IsFourOfAKind()
        {
            bool returnValue = IsNumOfAKind(3);
            //if (returnValue)
            //    listFourOfAKind.Add(dices);
            return returnValue;
        }

        public bool IsNumOfAKind(int amount)
        {
            int[] result = new int[6];

            for (int i = 0; i < dices.Length; i++)
                result[dices[i].value-1]++;

            for (int i = 0; i < dices.Length; i++)
            {
                if (result[i] >= amount)
                    return true;
            }
            return false;
        }

        public bool IsFullHouse()
        {
            int[] result = new int[6];
            bool threeSame = false;
            bool twoSame = false;

            for (int i = 0; i < dices.Length; i++)
                result[dices[i].value - 1]++;

            for (int i = 0; i < dices.Length; i++)
            {
                if (result[i] == 3)
                {
                    threeSame = true;
                    break;
                }   
            }

            for (int i = 0; i < dices.Length; i++)
            {
                if (result[i] == 2)
                {
                    twoSame = true;
                    break;
                }
            }

            return threeSame && twoSame;

        }

        public bool IsSmallStreet()
        {
            int[] result = new int[6];
            bool twoNums = false;

            for (int i = 0; i < dices.Length; i++)
                result[dices[i].value - 1]++;

            for (int i = 0; i < dices.Length; i++)
            {
                if (result[i] > 2 || (result[i] == 2 && twoNums))
                    return false;
                
                if (result[i] == 2)
                    twoNums = true;
            }

            return true;
        }

        public bool IsBigStreet()
        {
            int[] result = new int[6];

            for (int i = 0; i < dices.Length; i++)
                result[dices[i].value - 1]++;

            for (int i = 0; i < dices.Length; i++)
                if (result[i] > 2) return false;

            return true;
        }

        //public void DisplayStatistics()
        //{
        //    Console.WriteLine("\nThree of a Kind:");
        //    for (int i = 0; i < listThreeOfAKind.Count; i++)
        //    {
        //        dices = listThreeOfAKind[i];
        //        Console.WriteLine(convertArrayToString(dices));
        //    }
                

        //}

        //public string convertArrayToString(Dice[] array)
        //{
        //    string returnValue = "";
        //    for(int i = 0; i < array.Length; i++)
        //        returnValue += array[i].value + " ";

        //    return returnValue;
        //}

    }
}
