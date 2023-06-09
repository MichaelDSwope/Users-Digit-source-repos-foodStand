using System;


namespace vendingMachine
{

    class Shop
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========    VENDING MACHINE    ==========");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===========================================");
            Console.WriteLine("=====    SODA     CANDY     CHIPS      ====");
            Console.WriteLine("===========================================");
            {

                //  soda full 100, soda restock 40

                //full stock
                int SodaFullStock = 100;
                int CandyFullStock = 60;
                int ChipFullStock = 40;

                //stock count after purchase
                int sodaLeftCount;
                int candyLeftCount;
                int chipLeftCount;
                
                //strictly for storing user input
                int sodaOrder;
                int candyOrder;
                int chipOrder;

                //soda
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=========         SODA         ============");
                Console.WriteLine("===========================================\n\n");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($" Soda in stock : {SodaFullStock}\n");               
                {
                    Console.WriteLine(" How much soda have we sold today? ");


                    Console.ForegroundColor= ConsoleColor.Magenta;
                    Console.Write(" Enter amount of soda sold today : ");

                    Console.ForegroundColor = ConsoleColor.Green;

                    sodaOrder = int.Parse(Console.ReadLine());
                    sodaOrder = Convert.ToInt32(sodaOrder);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                   

                    sodaLeftCount = SodaFullStock - sodaOrder;

                    Console.WriteLine($" Total Soda amount left instock  : {sodaLeftCount}");
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    //===== if order is between 60 and 100 restock
                    
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (sodaOrder >= 60) 
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" Please restock soda now. ");
                    }
                     
                    if (sodaOrder <= 40) 
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" No need for restock currently. \n ");    
                    }
                    
                    // candy full 100, candy restock 40        0rder 60 to reach 40            
                    //============================== candy ===================================================

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    
                    Console.WriteLine("=========          CANDY           ========");
                    Console.WriteLine("===========================================");

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(" How much candy have we sold today? ");
                    {
                        candyOrder = int.Parse(Console.ReadLine());
                        Console.WriteLine($" Candy in stock : {CandyFullStock}");
                        candyOrder = Convert.ToInt32(candyOrder);

                        candyLeftCount = CandyFullStock - candyOrder;


                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(" Enter amount of candy sold today : ");

                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.ReadLine();

                        candyLeftCount = CandyFullStock - candyOrder;
                        Console.WriteLine($" Soda amount left instock : {candyLeftCount}");
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        // chip full 40, chip restock 20
                        //===== candy 60 full  40 restock =========

                        Console.ForegroundColor = ConsoleColor.Cyan;

                        if (candyOrder >= 40 && candyOrder <= 60) 
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" Please Restock Candy Now.  \n ");

                        }

                        if (candyOrder > 60) 
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" Sorry. Can't complete order. Order too large.  ");
                        }
                        //candyOrder = int.Parse(Console.ReadLine());


                        //============================  chips ========================================================


                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("=========          CHIPS           ========");
                        Console.WriteLine("===========================================");
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine(" How many chips have we sold today? ");
                        {
                            chipOrder = int.Parse(Console.ReadLine());
                            chipLeftCount = ChipFullStock - chipOrder;
                            Console.WriteLine($" Candy in stock : {ChipFullStock}");
                            chipOrder = Convert.ToInt32(chipOrder);


                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(" Enter amount of candy sold today : ");

                            Console.ForegroundColor = ConsoleColor.Green;

                            candyOrder = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Magenta;

                            Console.ReadLine();

                            chipLeftCount = ChipFullStock - chipOrder;
                            Console.WriteLine($" chip amount left instock : {chipLeftCount}");
                            Console.ForegroundColor = ConsoleColor.Magenta;

                            //===== chip  40 full  20 restock

                            Console.ForegroundColor = ConsoleColor.Cyan;

                            if (chipOrder >= 20 && chipOrder <= 40) 
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" Please Restock Chips Now.  \n ");

                            }

                            if (chipOrder > 40) 
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" Sorry. Can't complete order. Order too large.  \n\n");
                            }
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            //chipOrder = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Soda restock :  { sodaLeftCount } restock at 40");
                            Console.WriteLine($"Candy restock:  { candyLeftCount} restock at 40");
                            Console.WriteLine($"Chip restock :  { chipLeftCount } restock at 20");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }


                    }

                }
                
                
                
            }
        }
    }
}
               