using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace my_LinkedList
{
        class Program
        {
        ////public static void My_test()
        //{
        //    var timer = new Stopwatch();
        //    Random rnd = new Random();
        //    int[] arrive_numbers = new int[1000000];
        //    timer.Start();
        //    LinkedList<int> numbers = new LinkedList<int>();
        //    for (int i = 0; i < arrive_numbers.Length; i++)
        //    {
        //        arrive_numbers[i] = rnd.Next(1, 100000);
        //        numbers.AddLast(arrive_numbers[i]);
        //    }
        //    numbers.AddFirst(51462);
        //    int a = numbers.First();
        //    numbers.RemoveFirst();
        //    numbers.AddLast(123545);
        //    numbers.RemoveLast();
        //    int b = numbers.Last();
        //    bool f = numbers.Contains('/');
        //    timer.Stop();
        //    TimeSpan timeTaken = timer.Elapsed;
        //    string foo = timeTaken.ToString(@"m\:ss\.fff");
        //    Console.WriteLine("Время оригинала:" + foo);
        //    timer.Start();
        //    Link_list<int> my_numbers = new Link_list<int>();
        //    my_numbers.RemoveFirst();
        //    my_numbers.AddFirst(51462);
        //    int d = my_numbers.First();
        //    my_numbers.RemoveFirst();
        //    my_numbers.AddLast(123545);
        //    my_numbers.RemoveLast();
        //    int r = my_numbers.Last();
        //    bool h = my_numbers.Contains('/');
        //    timer.Stop();
        //    TimeSpan timeTakenn = timer.Elapsed;
        //    string fooo = timeTakenn.ToString(@"m\:ss\.fff");
        //    Console.WriteLine("Время подделки:" + fooo);
        //}
        public static void Main()
        {
            // Create the link list.
            string[] words =
                { "the", "fox", "jumps", "over", "the", "dog" };
            Link_list<string> sentence = new Link_list<string>(words);
            Display(sentence, "The linked list values:");
            Console.WriteLine("sentence.Contains(\"jumps\") = {0}",
                sentence.Contains("jumps"));

            // Add the word 'today' to the beginning of the linked list.
            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

            // Move the first node to be the last node.
            Items<string> mark1 = sentence.First();
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be last node:");

            // Change the last node to 'yesterday'.
            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test 3: Change the last node to 'yesterday':");

            // Move the last node to be the first node.
            mark1 = sentence.Last();
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence, "Test 4: Move last node to be first node:");

            // Indicate the last occurence of 'the'.
            sentence.RemoveFirst();
            Items<string> current = sentence.FindLast("the");
            IndicateNode(current, "Test 5: Indicate last occurence of 'the':");

            // Add 'lazy' and 'old' after 'the' (the LinkedListNode named current).
            sentence.RemoveFirst();
            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            sentence.AddFirst("the");
            IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");

            // Indicate 'fox' node.
            current = sentence.Find("fox");
            IndicateNode(current, "Test 7: Indicate the 'fox' node:");

            // Add 'quick' and 'brown' before 'fox':
            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "brown");
            IndicateNode(current, "Test 8: Add 'quick' and 'brown' before 'fox':");

            // Keep a reference to the current node, 'fox',
            // and to the previous node in the list. Indicate the 'dog' node.
            mark1 = current;
            Items<string> mark2 = current.Before;
            current = sentence.Find("dog");
            IndicateNode(current, "Test 9: Indicate the 'dog' node:");

            // The AddBefore method throws an InvalidOperationException
            // if you try to add a node that already belongs to a list.
            Console.WriteLine("Test 10: Throw exception by adding node (fox) already in the list:");
            try
            {
                sentence.AddBefore(current, mark1);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }
            Console.WriteLine();

            // Remove the node referred to by mark1, and then add it
            // before the node referred to by current.
            // Indicate the node referred to by current.
            sentence.Remove(mark1);
            sentence.AddBefore(current, mark1);
            IndicateNode(current, "Test 11: Move a referenced node (fox) before the current node (dog):");

            // Remove the node referred to by current.
            sentence.Remove(current);
            IndicateNode(current, "Test 12: Remove current node (dog) and attempt to indicate it:");

            // Add the node after the node referred to by mark2.
            sentence.AddAfter(mark2, current);
            IndicateNode(current, "Test 13: Add node removed in test 11 after a referenced node (brown):");

            // The Remove method finds and removes the
            // first node that that has the specified value.
            sentence.Remove("old");
            Display(sentence, "Test 14: Remove node that has the value 'old':");

            // When the linked list is cast to ICollection(Of String),
            // the Add method adds a node to the end of the list.
            sentence.RemoveLast();
            ICollectionn<string> icoll = sentence;
            icoll.Add("rhinoceros");
            Display(sentence, "Test 15: Remove last node, cast to ICollection, and add 'rhinoceros':");

            Console.WriteLine("Test 16: Copy the list to an array:");
            // Create an array with the same number of
            // elements as the linked list.
            string[] sArray = new string[sentence.Count];
            sentence.CopyTo(sArray, 0);

            foreach (string s in sArray)
            {
                Console.WriteLine(s);
            }

            // Release all the nodes.
            sentence.Clear();

            Console.WriteLine();
            Console.WriteLine("Test 17: Clear linked list. Contains 'jumps' = {0}",
                sentence.Contains("jumps"));

            Console.ReadLine();
        }

        private static void Display(Link_list<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IndicateNode(Items<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Node '{0}' is not in the list.\n",
                    node.Value);
                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            Items<string> nodeP = node.Before;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Before;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }

}

