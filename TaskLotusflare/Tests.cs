using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLotusflare {
    [TestFixture]
    public class Tests {
        [Test]
        [TestCase("abc bca aaa", "aaa bca abc")]
        [TestCase("aaa sss ddd fff ggg hhh jjjjjj", "jjjjjj hhh ggg fff ddd sss aaa")]
        public void Task1Test(string str, string expectedResult) {
            var actualResult = Program.ReverseWords(str);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4, 5 }, " 2 3 4")]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4, 5, 6, 7 }, " 2 3")]
        [TestCase(new int[] { 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3 }, " 2 3")]
        public void Task2Test(int[] array1, int[] array2, string expectedResult) {
            var actualResult = Program.FindNumbers(array1, array2);
            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}
