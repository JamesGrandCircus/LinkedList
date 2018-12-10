using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list
{
    class Reverse
    {



        public void PrintListReverseOrder(LinkedListNode head)
        {
            if (head == null)
            {
                return;
            }
            PrintListReverseOrder(head.GetNext());
            Console.WriteLine(head.Data);
        }





        //}

        //{ 
        //    public class ReverseLinkedList(LinkedList list, int index)
        //    {
        //        LinkedListNode start = linkedList.Head;
        //        LinkedListNode temp = null;

        //        // ------------------------------------------------------------
        //        // Loop through until null node (next node of the latest node) is found
        //        // ------------------------------------------------------------

        //        while private static object linkedList;

        //public System.Collections.Generic.LinkedListNode Start { get => start; set => start = value; }

        //(start != null)
        //        {
        //            // ------------------------------------------------------------
        //            // Swap the "Next" and "Previous" node properties
        //            // ------------------------------------------------------------

        //            temp = start.Next;
        //            start.Next = start.Previous;
        //            start.Previous = temp;

        //            // ------------------------------------------------------------
        //            // Head property needs to point to the latest node
        //            // ------------------------------------------------------------

        //            if (start.Previous == null)
        //            {
        //                linkedList.Head = start;
        //            }

        //            // ------------------------------------------------------------
        //            // Move on to the next node (since we just swapped 
        //            // "Next" and "Previous"
        //            // "Next" is actually the "Previous"
        //            // ------------------------------------------------------------

        //            start = start.Previous;
        //        }



    }
}
