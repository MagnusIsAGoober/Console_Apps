/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: 
 */
using System.Diagnostics;

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("Welcome To Magnus' Deliceous Pizza Planet");

            //sizes
            string SmallP = "Small\t(10in)";
            string MediumP = "Medium\t(12in)";
            string LargeP = "Large\t(14in)";
            string XLargeP = "XLarge\t(16in)";

            //crusts
            string HandTossed = "Hand Tossed ";
            string ThinCrust = "Thin Crust ";
            string GlutenFree = "Gluten Free ";
            string DeepDish = "Deep Dish ";

            //toppings

            string Pepperoni = "Pepperoni ";
            string Pineapple = "Pineapple ";
            string Bacon = "Bacon ";
            string Mushroom = "Mushrooms ";
            string GreenPepper = "Green Pepper ";
            string ItalianSausage = "Italian Sausage";
            //prices
            double Smallprice = 10.99;
            double Mediumprice = 12.99;
            double Largeprice = 14.99;
            double XLargeprice = 16.99;


            double GFPrice = 2.99;
            double DDPrice = 3.99;

            double CheesePrice = 2.99;
            //Selections
            string SelectedSize = "None";
            string SelectedCrust = "None";
            string SelectedTopping = "None";
            string SelectedMoreCheese = "Y";
            double SelectedTip = 0.00;

            //selected prices
            double SizePrice = 0.00;
            double CrustPrice = 0.00;
            double ToppingPrice = 0.00;
            

            int step = 0;
        Ordering:
            switch (step)
            {
                case 0:
                    Console.WriteLine("********************************************************************");
                    step++;
                    goto Ordering;
                    break;
                case 1: //Size


                    Console.WriteLine("Please select your pizza size (inches)");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("(1) \t " + SmallP + "\t " + "$" + Smallprice);
                    Console.WriteLine("(2) \t " + MediumP + "\t " + "$" + Mediumprice);
                    Console.WriteLine("(3) \t " + LargeP + "\t " + "$" + Largeprice);
                    Console.WriteLine("(4) \t " + XLargeP + "\t " + "$" + XLargeprice);


                    Console.WriteLine("Please type 1, 2, 3, 4 to select your pizza size ");
                    int ChosenSize = Convert.ToInt32(Console.ReadLine());
                    if (ChosenSize != 1 && ChosenSize != 2 && ChosenSize != 3 && ChosenSize != 4)
                    {
                        Console.WriteLine("That is not an option");
                        goto Ordering;
                    }
                    switch (ChosenSize)
                    {
                        case 1:
                            Console.WriteLine("you chose Small (10in)");
                            SelectedSize = "Small";
                            SizePrice = Smallprice;
                            break;
                        case 2:
                            Console.WriteLine("you chose Medium (12in)");
                            SelectedSize = "Medium";
                            break;
                        case 3:
                            Console.WriteLine("you chose Large (14in)");
                            SelectedSize = "Large";
                            break;
                        case 4:
                            Console.WriteLine("you chose Extra Large (16in)");
                            SelectedSize = "XLarge";
                            break;
                    }

                    step++;

                    goto Ordering;
                    break;
                case 2: // Crust

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Please choose the pizza crust");

                    Console.WriteLine("(0) \t [Go Back]");
                    Console.WriteLine("(1) \t " + HandTossed);
                    Console.WriteLine("(2) \t " + ThinCrust);
                    Console.WriteLine("(3) \t " + GlutenFree + " \t " + "+ $" + GFPrice);
                    Console.WriteLine("(4) \t " + DeepDish + " \t " + "+ $" + DDPrice);


                    Console.WriteLine("Please type 1, 2, 3, 4 to select your pizza crust ");
                    int ChosenCrust = Convert.ToInt32(Console.ReadLine());
                    if (ChosenCrust != 0 && ChosenCrust != 1 && ChosenCrust != 2 && ChosenCrust != 3 && ChosenCrust != 4)
                    {
                        Console.WriteLine("That is not an option");
                        goto Ordering;
                    }
                    else if (ChosenCrust == 0)
                    {
                        step--;
                    }
                    else
                    {
                        switch (ChosenCrust)
                        {
                            case 1:
                                Console.WriteLine("you chose Hand Tossed");
                                SelectedCrust = "HandTossed";
                                CrustPrice = 0;
                                break;
                            case 2:
                                Console.WriteLine("you chose Thin Crust");
                                SelectedCrust = "ThinCrust";
                                CrustPrice = 0;
                                break;
                            case 3:
                                Console.WriteLine("you chose Gluten Free");
                                SelectedCrust = "GlutenFree";
                                CrustPrice = GFPrice;
                                break;
                            case 4:
                                Console.WriteLine("you chose Deep Dish");
                                SelectedCrust = "DeepDish";
                                CrustPrice = DDPrice;
                                break;
                        }
                        step++;
                    }
                    goto Ordering;
                    break;
                    
                case 3: // Toppings

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Please choose the pizza toppings");

                    Console.WriteLine("(0) \t [Go Back]");
                    Console.WriteLine("(1) \t " + Pepperoni);
                    Console.WriteLine("(2) \t " + Pineapple);
                    Console.WriteLine("(3) \t " + Bacon);
                    Console.WriteLine("(4) \t " + Mushroom);
                    Console.WriteLine("(5) \t " + GreenPepper);
                    Console.WriteLine("(6) \t " + ItalianSausage);
                    Console.WriteLine("(7) \t None");


                    Console.WriteLine("Please type 1, 2, 3, 4 to select your pizza topping ");
                    int ChosenTopping = Convert.ToInt32(Console.ReadLine());
                    if (ChosenTopping != 0 && ChosenTopping != 1 && ChosenTopping != 2 && ChosenTopping != 3 && ChosenTopping != 4 && ChosenTopping != 5 && ChosenTopping != 6 && ChosenTopping != 7)
                    {
                        Console.WriteLine("That is not an option");
                        goto Ordering;
                    }
                    else if (ChosenTopping == 0)
                    {
                        step--;
                    }
                    else
                    {
                        switch (ChosenTopping)
                        {
                            case 1:
                                Console.WriteLine("you chose Pepperoni");
                                SelectedTopping = "Pepperoni";
                                
                                break;
                            case 2:
                                Console.WriteLine("you chose Pineapple");
                                SelectedTopping = "Pineapple";
                                break;
                            case 3:
                                Console.WriteLine("you chose Bacon");
                                SelectedTopping = "Bacon";
                                break;
                            case 4:
                                Console.WriteLine("you chose Mushroom");
                                SelectedTopping = "Mushroom";
                                break;
                            case 5:
                                Console.WriteLine("you chose Green Peppers");
                                SelectedTopping = "GreenPepper";
                                break;
                            case 6:
                                Console.WriteLine("you chose Italian Sausage");
                                SelectedTopping = "ItalianSausage";
                                break;
                        }

                        step++;

                    }
                    goto Ordering;
                    break;
                    
                case 4:// Cheese
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Would you like extra cheese? (+"+ CheesePrice + ")\t(Y/N)");

                    string ExtraCheese = Console.ReadLine();
                    ExtraCheese = ExtraCheese.ToUpper();
                    if (ExtraCheese != "Y" && ExtraCheese != "N")
                    {
                        Console.WriteLine("That is not an option");
                        goto Ordering;
                    }
                    else if (ExtraCheese == "Y")
                    {
                        SelectedMoreCheese = "Y";
                    }
                    else
                    {
                        SelectedMoreCheese = "N";
                    }
                    step++;
                    goto Ordering;
                    break;
                case 5: // Address

                    Console.WriteLine("Please enter your addresss");
                    string Address = Console.ReadLine();

                    step++;
                    goto Ordering;
                    break;

                case 6: //Tip
                    Console.WriteLine("(0) \t [Go Back]");
                    Console.WriteLine("(1) \t for 5% tip");
                    Console.WriteLine("(2) \t for 10% tip");
                    Console.WriteLine("(3) \t for 15% tip");
                    Console.WriteLine("(4) \t for 20% tip");
                    Console.WriteLine("(5) \t for No tip");
                    Console.WriteLine("(6) \t Custom Tip");

                    double ChosenTip = Convert.ToDouble(Console.ReadLine());

                    if (ChosenTip != 0 && ChosenTip != 1 && ChosenTip != 2 && ChosenTip != 3 && ChosenTip != 4 && ChosenTip != 5 && ChosenTip != 6)
                    {
                        Console.WriteLine("That is not an option");
                        goto Ordering;
                    }
                    else if (ChosenTip == 0)
                    {
                        step = step - 2;
                    }
                    else
                    {
                        switch (ChosenTip)
                        {
                            case 1:
                                Console.WriteLine("5% Tip added");
                                SelectedTip = 1.05;
                                break;
                            case 2:
                                Console.WriteLine("10% Tip added");
                                SelectedTip = 1.10;
                                break;
                            case 3:
                                Console.WriteLine("15% Tip added");
                                SelectedTip = 1.15;
                                break;
                            case 4:
                                Console.WriteLine("20% Tip added");
                                SelectedTip = 1.20;
                                break;
                            case 5:
                                Console.WriteLine("Zero Tip added");
                                SelectedTip = 0;
                                break;
                            case 6:
                                Console.WriteLine("How much would like to tip (%)");
                                double TipPercent = Convert.ToDouble(Console.ReadLine());
                                SelectedTip = (TipPercent / 100) + 1;
                                break;
                        }

                        step++;
                        goto Ordering;
                    }
                    break;

            case 7: // bill

                    Console.WriteLine("Your order is as follows:");
                    Console.WriteLine("Size \t\t" + SelectedSize + "\t\t$" + SizePrice);
                    Console.WriteLine("Crust \t\t" + SelectedCrust + "\t$" + CrustPrice);
                    Console.WriteLine("Topping \t" + SelectedTopping + "\t$" + ToppingPrice);

                    if (SelectedMoreCheese == "Y") { Console.WriteLine("Extra Cheese " + "$" + CheesePrice); }




                    break;
            }
        }
    }

}
