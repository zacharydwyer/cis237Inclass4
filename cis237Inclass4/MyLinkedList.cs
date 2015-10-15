using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class MyLinkedList
    {
        private Node current;               // At any point in time, we should be on a particular node. The last created node. 

        public Node Head { get; set; }      // The first node in the list

        public MyLinkedList()               // Constructor to set Head to null because there is nothing in the list yet.
        {   
            Head = null;                    // Useful to check if the Head is null in case the list is empty/we did something wrong when making the list
        }

        /* ADD A NODE TO THE LIST */
        public void Add(string content)
        {       
            Node newNode = new Node();      // Create a new node to add to the list
            newNode.Data = content;         // Set the data to the passed given content string

            if (Head == null)               // Is the list empty?
            {
                Head = newNode;                 // Set the new node as the first node in the list
            }
            else
            {                               // Is the list not empty?
                current.Next = newNode;         // Make the current node that we are on (the last in the list)'s Next node reference this node.
            }

            current = newNode;              // Finally, set the last node in this Linked List to the just-added node.
        }

        /* REMOVE A NODE FROM THE LIST */   // This is base 1, not base 0.
        public bool Delete(int position)
        {

            /* Delete the first node. */
            if (position == 1)              // If the position is the very first node in the list (we want to delete the first one in the list)
            {
                Head = current.Next;            // Set the head to the next one (position 2) in the list
                current = null;                 // 
                return true;
            }

            /* Delete a node other than the first. */
            if (position > 1)
            {
                Node temporaryNode = Head;      // Make temporary node reference Head (first) node in the series
                Node lastNode = null;           // This node will be used for the delete
                int count = 0;                  // Counter to know if we have reached the position given as an argument (position) or not

                /* If the temporary node is NOT null we can continue to walk through this linked list */
                /* If it IS null however, we have reached the end of the list. */
                while (temporaryNode != null) {

                    // If the count is equal to the position entered (minus 1) then we have found the node we want to delete. 
                    if (count == position - 1) 
                    {
                        // Set the last node's Next node to the TempNode's Next node.
                        lastNode.Next = temporaryNode.Next;

                        // We found the node.
                        return true;
                    }
                    
                    // Increment counter since we are moving foward in the list
                    count++;

                    // Set the last node equal to the tempnode. Now both variables are pointing to the same node.
                    lastNode = temporaryNode;

                    // Now set the tempnode to tempnode's Next node. This will move tempnode one more location forward in the list.
                    temporaryNode = temporaryNode.Next;
                }
            }

            return false;
        }



    }
}
