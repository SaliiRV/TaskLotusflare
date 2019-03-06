using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLotusflare {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter task number: ");
            int Switch =  Convert.ToInt32(Console.ReadLine());

            switch (Switch) {
                case 1:
                    Console.WriteLine("Task 1.");
                    Console.WriteLine("Reverse word: " + ReverseWord());
                    break;
                case 2:
                    Console.WriteLine("Task 2");
                    Console.WriteLine("Identical elements: " + FindNumbers());
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.ReadKey();
        }



        public static string ReverseWord() {
            Console.WriteLine("Enter word please: ");
            string word = Console.ReadLine();
            string result = "";
            char[] wordarr = word.ToCharArray();
            for (int i = word.Length - 1; i >= 0; i--) {
                result += wordarr[i].ToString();
            }
            return result;
        }

        public static string FindNumbers() {
            string result = null;
            Console.WriteLine("Enter size of the first array: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter size of the second array: ");
            int size2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements of the first array: ");
            int[] array1 = new int[size1];
            for (int i = 0; i < size1; i++) {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter elements of the second array: ");
            int[] array2 = new int[size2];
            for (int i = 0; i < size2; i++) {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (size1 <= size2) {
                result = Result(size1, size2, array1, array2);
            }
            else {
                result = Result(size2, size1, array2, array1);
            }

            return result;
        }


        public static string Result(int size1, int size2, int[] array1, int[] array2) {
            string result = null;
            for (int i = 0; i < size1; i++) {
                for (int j = 0; j < size2; j++) {
                    if (array1[i] == array2[j]) {
                        result = result + " " + array2[j].ToString();
                    }
                }
            }
            return result;
        }

    }




}
