using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLotusflare {
    class Program {
        static void Main(string[] args) {
        }

        public static string ReverseWords(string str) {
            String[] words = str.Split(new char[] { ' ' });
            string result = words[words.Length - 1];
            for (int i = words.Length - 2; i >= 0; i--) {
                result = result + " " + words[i];
            }
            return result;
        }

        public static string FindNumbers(int[] array1, int[] array2) {
            string result = null;
            int size1 = array1.Length;
            int size2 = array2.Length;
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
