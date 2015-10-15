using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.Add("first");
            myLinkedList.Add("second");
            myLinkedList.Add("third");
            myLinkedList.Add("fourth");

            // Loop through with this differently looking for loop to output
            // in here, the first part is initialization: setting x to the head
            // The second part is the test: if x != null, keep going
            // The last part is: set the current x to x's next pointer.
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            // Couple of blank lines
            Console.WriteLine(Environment.NewLine);

            // Delete the 2nd element in the list
            myLinkedList.Delete(2);

            // Delete the 2nd element in the list. Was 3rd before previous delete.
            myLinkedList.Delete(2);

            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

        }
    }
}
