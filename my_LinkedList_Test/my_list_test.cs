using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace my_LinkedList_Test
{
    [TestClass]
    public class my_list_test
    {
        [TestMethod]
        public void Equal_Method_First_Last()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }
            // act
            //assert 
            //Assert.AreEqual(true, true);
            Assert.AreEqual(numbers.First(), my_array.First());
            Assert.AreEqual(numbers.Last(),my_array.Last());
        }
        [TestMethod]
        public void Equal_Method_AddFirst()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }

            // act
            for (int i = 0; i < array_numbers.Length; i++)
            {
                int random_number = rnd.Next(1, 100);
                numbers.AddFirst(random_number);
                my_array.AddFirst(random_number);
            }
            string output_string_LinkedList = "";
            string output_string_my_array = "";
            foreach (int number in numbers)
            {
                output_string_LinkedList += Convert.ToString(number);
            }
            foreach (int number in my_array)
            {
                output_string_my_array += Convert.ToString(number);
            }
            //assert 
            Assert.AreEqual(output_string_LinkedList, output_string_my_array);
        }
        [TestMethod]
        public void Equal_Method_AddLast()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }

            // act
            string output_string_LinkedList = "";
            string output_string_my_array = "";
            foreach (int number in numbers)
            {
                output_string_LinkedList += Convert.ToString(number);
            }
            foreach (int number in my_array)
            {
                output_string_my_array += Convert.ToString(number);
            }
            //assert 
            Assert.AreEqual(output_string_LinkedList, output_string_my_array);
        }
        [TestMethod]
        public void Equal_Method_RemoveLast()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }

            // act
            for (int i = 0; i < 10; i++)
            {
                numbers.RemoveLast();
                my_array.RemoveLast();
            }
            string output_string_LinkedList = "";
            string output_string_my_array = "";
            foreach (int number in numbers)
            {
                output_string_LinkedList += Convert.ToString(number);
            }
            foreach (int number in my_array)
            {
                output_string_my_array += Convert.ToString(number);
            }
            //assert 
            Assert.AreEqual(output_string_LinkedList, output_string_my_array);
        }
        [TestMethod]
        public void Equal_Method_RemoveFirst()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }

            // act
            for (int i = 0; i < 10; i++)
            {
                numbers.RemoveFirst();
                my_array.RemoveFirst();
            }
            string output_string_LinkedList = "";
            string output_string_my_array = "";
            foreach (int number in numbers)
            {
                output_string_LinkedList += Convert.ToString(number);
            }
            foreach (int number in my_array)
            {
                output_string_my_array += Convert.ToString(number);
            }
            //assert 
            Assert.AreEqual(output_string_LinkedList, output_string_my_array);
        }
        [TestMethod]
        public void Equal_Method_Contains()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }
            // act
            bool flag = true;
            for (int i = 0; i <20 ; i++)
            {
                int proof = rnd.Next(-100, 100);
                if (numbers.Contains(proof) != my_array.Contains(proof))
                {
                    flag = false;
                    break;
                }
            }
            //assert 
            Assert.AreEqual(true, flag);
        }
        [TestMethod]
        public void Equal_Method_AddBefore()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }

            // act
            for (int i = 0; i < 10; i++)
            {
                int index = rnd.Next(1, array_numbers.Length-1);
                int element_which_changes = array_numbers[2];
                //numbers.AddBefore(5, 1);
                //my_array.AddBefore(5, 1);
            }
            string output_string_LinkedList = "";
            string output_string_my_array = "";
            foreach (int number in numbers)
            {
                output_string_LinkedList += Convert.ToString(number);
            }
            foreach (int number in my_array)
            {
                output_string_my_array += Convert.ToString(number);
            }
            //assert 
            Assert.AreEqual(output_string_LinkedList== output_string_my_array, true);
        }
        [TestMethod]
        public void Equal_Method_AddAfter()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }

            // act
            for (int i = 0; i < 10; i++)
            {
                int index = rnd.Next(1, array_numbers.Length - 1);
                int element_which_changes = array_numbers[2];
                //numbers.AddAfter(5, 1);
                //my_array.AddAfter(5, 1);
            }
            string output_string_LinkedList = "";
            string output_string_my_array = "";
            foreach (int number in numbers)
            {
                output_string_LinkedList += Convert.ToString(number);
            }
            foreach (int number in my_array)
            {
                output_string_my_array += Convert.ToString(number);
            }
            //assert 
            Assert.AreEqual(output_string_my_array== output_string_LinkedList, true);
        }
        [TestMethod]
        public void Equal_Method_Clear()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }
            // act
            string output_string_LinkedList = "";
            my_array.Clear();
            numbers.Clear();
            string output_string_my_array = "";
            foreach (int number in numbers)
            {
                output_string_LinkedList += Convert.ToString(number);
            }
            foreach (int number in my_array)
            {
                output_string_my_array += Convert.ToString(number);
            }
            //assert 
            Assert.AreEqual(output_string_LinkedList, output_string_my_array);
        }
        [TestMethod]
        public void Equal_Method_for_Inumerable()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[100];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }

            // act
            string output_string_LinkedList = "";
            string output_string_my_array = "";
            foreach (int number in numbers)
            {
                output_string_LinkedList += Convert.ToString(number);
            }
            foreach (int number in my_array)
            {
                output_string_my_array += Convert.ToString(number);
            }
            //assert 
            Assert.AreEqual(output_string_LinkedList, output_string_my_array);
        }
        [TestMethod]
        public void Equal_Method_for_IComparable()
        {
            //arange 
            Random rnd = new Random();
            my_LinkedList.Link_list<int> my_array_1 = new my_LinkedList.Link_list<int>();
            my_LinkedList.Link_list<int> my_array_2 = new my_LinkedList.Link_list<int>();
            int Count_1 = rnd.Next(1, 150);
            int Count_2 = rnd.Next(1, 150);
            int[] array_numbers_1 = new int[Count_1];
            for (int i = 0; i < array_numbers_1.Length; i++)
            {
                array_numbers_1[i] = rnd.Next(1, 100000);
                my_array_1.AddLast(array_numbers_1[i]);
            }
            int[] array_numbers_2 = new int[Count_2];
            for (int i = 0; i < array_numbers_2.Length; i++)
            {
                array_numbers_2[i] = rnd.Next(1, 100000);
                my_array_2.AddLast(array_numbers_2[i]);
            }
            // act
            int Equal_Length = my_array_1.CompareTo(my_array_2);
            int Equal_int = Count_1.CompareTo(Count_2);
            //assert 
            Assert.AreEqual(Equal_Length, Equal_int);
        }
        [TestMethod]
        public void Equal_Method_Sort()
        {
            //arange 
            Random rnd = new Random();
            int[] array_numbers = new int[10000];
            my_LinkedList.Link_list<int> my_array = new my_LinkedList.Link_list<int>();
            LinkedList<int> numbers = new LinkedList<int>();
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = rnd.Next(1, 100);
                numbers.AddLast(array_numbers[i]);
                my_array.AddLast(array_numbers[i]);
            }
            // act
            my_array.Sort();
            //sort для linkedlist
            for (int i=0; i< array_numbers.Length; i++) 
            {
                for (int j = 0; j < array_numbers.Length-1; j++) 
                {
                    if (array_numbers[j]> array_numbers[j+1])
                    {
                        int follow = array_numbers[j];
                        array_numbers[j] = array_numbers[j + 1];
                        array_numbers[j + 1] = follow;
                    }
                }
            }
            string output_string_original_numbers = "";
            string output_string_my_array = "";
            foreach (int number in array_numbers)
            {
                output_string_original_numbers += Convert.ToString(number);
            }
            foreach (int number in my_array)
            {
                output_string_my_array += Convert.ToString(number);
            }
            //assert 
            Assert.AreEqual(output_string_original_numbers, output_string_my_array);
        }



    }
}
