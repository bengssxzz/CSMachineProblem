using System;
using System.Collections.Generic;
using BST2;
namespace MachineProblem
{
    //Kepp it object oriented, use functions and remember to comment anything that you yourself have trouble explaining.
    class Program
    {
        // Standard Main Loop that lets User select Customer (Ordering) or Employee (Delivering)
        static void Main(string[] args)
        {
            //Create BST and Quuue class here
            while (true)
            {
                Console.WriteLine("Welcome to RESTAURANT's Delivery Service.");
                Console.WriteLine("Are you\n1)Ordering\n2)Delivering");
                Console.WriteLine("X)Exit");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        Order();
                        continue;
                    case "2":
                        Deliver();
                        continue;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        continue;
                }
            }
        }
        //Menu to enter an order
        static void Order()
        {
            //Create and display customer's order number (Randomly generated number not in the bst yet)
            //Create and display current order items
            //Provide option to add more to your order
            //Provide option to delete from order
            /*Only send order if it has content in string otherwise loops
             * Then as agreed it sends the order number and order content to be INSERTED into the BST and ONLY the order number to the Queue
             */
            // Option to return
        }
        //Menu to deliver and access delivery related functions
        static void Deliver()
        {
            //Option that DELIVERS, thus deleting whatever was next in queue and the associated BST entry
            //Option that DISPLAYS ORDERS, that traverses INORDER
            //Option that Displays next order (PEEKS at Queue but then searches and displays the associated BST entry
            //Option to return
        }
    }
}
