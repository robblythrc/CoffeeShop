using System;
using System.Text;

namespace Com.ManchesterDigital.CoffeeShop
{
    public class CoffeeShop
    {
        public void ServeCustomer()
        {
            Console.WriteLine("Welcome to the coffee shop. Let me take your order");
            bool withMilk = AskIfWithMilk();
            int numberOfSugars = AskHowManySugars();

            Console.WriteLine();
            Console.WriteLine("Thanks, I'll make that for you now");
            MakeCoffee(withMilk, numberOfSugars);

            Console.WriteLine();
            TakePayment(2.20, numberOfSugars);

            Console.WriteLine();
            Console.WriteLine("Here you go.");
            DescribeCoffee(withMilk, numberOfSugars);
        }

        private bool AskIfWithMilk()
        {
            Console.WriteLine("Do you want milk?");

            bool? result = null;
            while (result == null)
            {
                String input = Console.ReadLine();

                if ("yes".Equals(input, StringComparison.OrdinalIgnoreCase) || "y".Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    result = true;
                }
                else if ("no".Equals(input, StringComparison.OrdinalIgnoreCase) || "n".Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    result = false;
                }
                else
                {
                    Console.WriteLine("Please enter 'yes' or 'no'");
                }
            }

            return result.Value;
        }

        private int AskHowManySugars()
        {
            Console.WriteLine("How many sugars do you want?");

            int? result = null;
            while (result == null)
            {
                String input = Console.ReadLine();

                try
                {
                    result = int.Parse(input);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a number");
                }
            }

            return result.Value;
        }

        private void MakeCoffee(bool withMilk, int numberOfSugars)
        {
            Console.WriteLine("  click click");
            Console.WriteLine("  chug chug chug");
            Console.WriteLine("  grrrrrrrk");
            Console.WriteLine("  gurgle");
            Console.WriteLine("  blop blop");
        }

        private void TakePayment(double priceOfCoffee, int numberOfSugars)
        {
            double sugarTax = numberOfSugars * 0.1;
            double totalPrice = priceOfCoffee + sugarTax;

            String formattedPrice = String.Format("£{0:F}", totalPrice);
            Console.WriteLine("That will be " + formattedPrice + " please");
            Console.WriteLine("Please beep your card");

            bool beeped = false;
            while (!beeped)
            {
                String theBeep = Console.ReadLine();
                beeped = theBeep.Equals("beep", StringComparison.OrdinalIgnoreCase);

                if (!beeped)
                {
                    Console.WriteLine("Sorry that didn't read properly could you beep it again please");
                }
                else
                {
                    Console.WriteLine("Thanks.");
                    Console.WriteLine("  chrrrt chrrrt");
                    Console.WriteLine("  rrrip");
                    Console.WriteLine("Here is your receipt for " + formattedPrice + ".");
                    Console.ReadLine();
                }
            }
        }

        private void DescribeCoffee(bool withMilk, int numberOfSugars)
        {
            StringBuilder descriptionBuilder = new StringBuilder("A delicious coffee ")
                    .Append(withMilk ? "with milk" : "without milk");

            if (numberOfSugars > 0)
            {
                descriptionBuilder.Append(" and " + numberOfSugars + " sugars.");
            }
            else
            {
                descriptionBuilder.Append(" and no sugar.");
            }

            Console.WriteLine(descriptionBuilder.ToString());
        }
    }
}