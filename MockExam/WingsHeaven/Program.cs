using System;

namespace WingsHeaven
{
    /**
     * Name: Tiandre Turner
     * Date: 09/16/2020
     * Purpose: Create a program 
     * Caveats: N/A
     */
    class Program
    {
        static void Main(string[] args)
        {
            // misc prices
            const double SALES_TAX = .08; // sales tax
            const double DISCOUNT_PERCENTAGE = .18;
            // prices for wings
            const double BONELESS_WINGS_PRICE = 7.99;
            const double TRADITIONAL_WINGS_PRICE = 9.99;
            const double COMBO_PRICE = BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE - ((BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE) * DISCOUNT_PERCENTAGE);
            // combo price
            // prices for sauces
            const double BUFFALO_SAUCE_PRICE = .29;
            const double MILD_SAUCE_PRICE = .39;
            const double BBQ_SAUCE_PRICE = .99;
            // prices for sides
            const double WAFFLE_FRIES_PRICE = 3.49;
            const double ONION_RINGS_PRICE = 2.49;

            double subtotal = 0; // running subtotal
            string receipt = ""; // add the information to the receipt


            // menus in two different ways of formatting
            string wingsMenu = $"Enter the kind of wings [b - boneless ({BONELESS_WINGS_PRICE:C})"
                + $", t - traditional ({TRADITIONAL_WINGS_PRICE:C}), c - both ({(BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE):C}): ";
            string sauceMenu = "\n1. Buffalo Sauce ($" + BUFFALO_SAUCE_PRICE +
                ")\n2. Mild Sauce ($" + MILD_SAUCE_PRICE + ")\n3. BBQ Sauce ($" +
                BBQ_SAUCE_PRICE + ")\n4. Plain (no charge)\nSelect one of the preferred sauce: ";


            Console.Write(wingsMenu);
            string option = Console.ReadLine();
            if(option == "b")
            {
                // adding information to string by using the concentation operator.
                receipt = $"Boneless Wings - {BONELESS_WINGS_PRICE:C}\n";
                subtotal = subtotal + BONELESS_WINGS_PRICE;
            }
            else if(option == "t")
            {
                receipt = $"Traditional Wings - {TRADITIONAL_WINGS_PRICE:C}\n";
                subtotal = subtotal + TRADITIONAL_WINGS_PRICE;
            }
            else if(option == "c")
            {
                receipt = $"Combined Wings - {(BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE):C}\n" 
                   + $"Discount - {((BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE) * DISCOUNT_PERCENTAGE):C}\n";
                subtotal = subtotal + COMBO_PRICE;
            }

            Console.Write(sauceMenu);
            switch (Console.ReadLine())
            {
                case "1":
                    receipt = receipt + $"Buffalo Sauce - {BUFFALO_SAUCE_PRICE:C}\n";
                    subtotal = subtotal + BUFFALO_SAUCE_PRICE;
                    break;
                case "2":
                    receipt = receipt + $"Mild Sauce - {MILD_SAUCE_PRICE:C}\n";
                    subtotal = subtotal + MILD_SAUCE_PRICE;
                    break;
                case "3":
                    receipt = receipt + $"BBQ Sauce - {BBQ_SAUCE_PRICE:C}\n";
                    subtotal = subtotal + BBQ_SAUCE_PRICE;
                    break;
                case "4":
                    receipt = receipt + $"No Sauce\n";
                    break;
            }

            Console.Write("\n1. Waffles Fries ({0:C})\n2. Onion Rings ({1:C})\n3. Both ({2:C})\n4. None\nSelect one of the sides: ",
                WAFFLE_FRIES_PRICE, ONION_RINGS_PRICE, WAFFLE_FRIES_PRICE + ONION_RINGS_PRICE);
            // alternative approach to use Console.ReadLine() for switch
            option = Console.ReadLine();
            switch(option)
            {
                case "1":
                    receipt = receipt + $"Waffle Fries - {WAFFLE_FRIES_PRICE:C}\n";
                    subtotal = subtotal + WAFFLE_FRIES_PRICE;
                    break;
                case "2":
                    receipt = receipt + $"Onion Rings - {ONION_RINGS_PRICE:C}\n";
                    subtotal = subtotal + ONION_RINGS_PRICE; 
                    break;
                case "3":
                    receipt = receipt + $"Waffle Fries and Onion Rings - {(WAFFLE_FRIES_PRICE + ONION_RINGS_PRICE):C}\n";
                    subtotal = subtotal + (WAFFLE_FRIES_PRICE + ONION_RINGS_PRICE); 
                    break;
                case "4":
                    receipt = receipt + $"No Sides\n";
                    break;
            }

            // calculate to get the tax and total
            double tax = subtotal * SALES_TAX;
            double total = subtotal + tax;

            Console.WriteLine("\nWings Heaven\n");
            // display the receipt depending on the user's selected options
            Console.WriteLine(receipt);
            Console.WriteLine($"Subtotal: {subtotal:C}\nTax: {tax:C}\nTotal: {total:C}");





        }
    }
}
