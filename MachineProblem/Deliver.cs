using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BST2;

namespace MachineProblem
{
    class Deliver
    {
        public void deliverCurrentOrder(BinarySearchTree<int, string> tree, Queue<int> orderQueue)
        {
            //Option that DELIVERS, thus deleting whatever was next in queue and the associated BST entry
            Console.WriteLine("Current order");
            try
            {
                int getOrderNumber = orderQueue.Dequeue(); //Get first order number in queue

                Console.WriteLine("Order number: {0}\n", tree.Search(getOrderNumber).key); //Get the order number
                Console.WriteLine("Orders: {0}\n", tree.Search(getOrderNumber).value); //Get the orders

                tree.Delete(getOrderNumber); //delete in bst
            }
            catch (InvalidOperationException) //if the queue is empty
            {
                Console.WriteLine("Empty orders");
            }
        }

        public void displayCurrentOrder(BinarySearchTree<int, string> tree, Queue<int> orderQueue)
        {
            //Option that Displays next order (PEEKS at Queue but then searches and displays the associated BST entry
            Console.WriteLine("Next order");
            try
            {
                int peekOrderNumber = orderQueue.Peek(); //Get first order number in queue without removing it from queue

                Console.WriteLine("Order number: {0}\n", tree.Search(peekOrderNumber).key);
                Console.WriteLine("Orders: {0}\n", tree.Search(peekOrderNumber).value);
            }
            catch (InvalidOperationException) //if the queue is empty
            {
                Console.WriteLine("There's no more orders");
            }
        }

        public void delayOrder(Queue<int> orderQueue)
        {
            try
            {
                int getOrderNumber = orderQueue.Dequeue(); //Get first order number in queue
                orderQueue.Enqueue(getOrderNumber); // Enqueues the number
                Console.WriteLine("Order delayed...");
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("There's no more orders");
            }
        }
    }
}
