using Linkedlists_algorithim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Linkedlists_algorithim

{

    public static class LinkedListExtensions

    {


    }



        public static bool InsertAt<T>(this LinkedList<T> list, int index)

        {

            ValidateNode(node);
            LinkedListNode<T> result = new LinkedListNode<T>(list.First, index);
            InternalInsertNodeBefore(node.next, result);

            return false;

        }
    }






    public static class StringExtension

    {

        public static string ToCamelCase(this string value)

        {

            return string.Empty;

        }

    }



    class Program

    {

    static void Main(string[] args)

    {

        int[] numbers = new int[] { 1, 1, 1, 2, 4, 7, 7, 8, 9, 5 };

        var list = new LinkedList<int>();



        list.PrintReverse();

        list.RemoveAt(5);

        list.InsertAt(12, );



        string variable = "Jason";

        string camelCasedString = variable.ToCamelCase();

    


        //PART 2


                int[] array = { 3, 4, 5, 3, 2, 4, 7, 5, 3, 1, 2, 3, 5, 7, 5, 4 };
                int size = 16;
                int max = array[0];



                for (int i = 0; i < size; i++)
                {
                    if (array[i] > max) max = array[i];//find max number
                }
                int[] freq = new int[max];
                for (int i = 0; i < max; i++)
                {
                    freq[i] = 0;//initialize the frequencey array with max
                }
                for (int i = 0; i < size; i++)
                {
                    freq[array[i] - 1]++;//count
                }
                for (int i = 0; i < max; i++)
                {
                    if (freq[i] != 0) Console.WriteLine((i + 1) + "->" + freq[i]);//print them then
                }

                //this is the array part


                Dictionary<int, int> hashmap = new Dictionary<int, int>();
                for (int i = 0; i < size; i++)

                {
                    if (hashmap.ContainsKey(array[i]))
                    {
                        hashmap[array[i]]++; //just increase the count by 1
                    }
                    else
                    {
                        hashmap.Add(array[i], 1);//add a new value with count 1
                    }

                }
                foreach (KeyValuePair<int, int> node in hashmap)
                {
                    Console.WriteLine(node.Key + " " + node.Value);//printing each key in the map
                }

            }
        }
    