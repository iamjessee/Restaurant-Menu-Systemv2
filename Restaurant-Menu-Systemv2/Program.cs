﻿using Restaurant_Menu_System_V3;

class Program
{
    static void Main(string[] args)
    {
        // calls class and methods for greeting user and collecting name for order
        OrderName ordername = new OrderName();
        ordername.DisplayGreetingAndCollectName();

        // calls class and methods for creating customers order
        OrderInputAndOptions orderchoice = new OrderInputAndOptions();
        orderchoice.ChooseTortilla();
        orderchoice.ChooseProtein();
        orderchoice.ChooseRice();
        orderchoice.ChooseBeans();
        orderchoice.ChooseAddOns();

        // prompt user to edit their order if needed


        // clears console and displays user receipt
        //Console.Clear();
        //Console.WriteLine("\x1b[3J");
        CustomerReceipt receipt = new CustomerReceipt(orderchoice);
        receipt.GetReceiptDisplay(ordername);
    }
}