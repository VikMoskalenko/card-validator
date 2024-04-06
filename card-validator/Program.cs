using System;
namespace card-validator

{

    public class Program

{

    public static void Main(string[] args)

    {

        string[] cardNum = { "378-2822-4621-0005", "55555555555555", "4916 1085 2103 5937", "378-2822-4631-0005" };

        foreach (var card in cardNum)

        {

            if (CardIsValid(card))



                Console.WriteLine($"You are good to go");



            else



                Console.WriteLine("Sorry mate");



        }

        Console.ReadLine();

    }

    public static bool CardIsValid(string card)

    {

        int sum = 0;

        string reversedCardNum = string.Empty;

        string digits = string.Empty;



        card = card.Replace(" ", null).Replace("-", null);

        for (int i = card.Length - 1; i >= 0; i--)

        {

            reversedCardNum += card[i];



        }

        for (int i = 0; i < reversedCardNum.Length; i++)

        {

            if ((i + 1) % 2 == 0)

                digits += Convert.ToInt32(reversedCardNum.Substring(i, 1)) * 2;

            else

                digits += reversedCardNum.Substring(i, 1);

        }

        for (int i = 0; i < digits.Length; i++)

        {

            sum += Convert.ToInt32(digits.Substring(i, 1));

        }

        if (sum % 10 == 0)

            return true;



        return false;

    }

}

}
