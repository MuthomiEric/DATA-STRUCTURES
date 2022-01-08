using DATA_STRUCTURES.Arrays;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Ninja
{
    public class TestArrayOperations
    {
        ArrayOperations ops;

        int[] commonArray = new int[7];
        [SetUp]
        public void Setup()
        {
            ops = new ArrayOperations();

            commonArray[0] = 10;
            commonArray[1] = 11;
            commonArray[2] = 12;
            commonArray[3] = 13;
            commonArray[4] = 14;
            commonArray[5] = 15;
        }

        [Test]
        public void Assert_Reversed_CharArray_Equal_imohtum()
        {
            var name = "Muthomi";

            var nameChars = name.ToCharArray();

            Assert.AreEqual(ops.reverseArray(nameChars), "imohtuM".ToCharArray());

        }

        [Test]
        public void Assert_Index_Of_13_Equal_3()
        {
            Assert.AreEqual(ops.IndexOfAKeySearch(commonArray, 13), 3);

        }

        [Test]
        public void Assert_Index_Of_Number_Not_In_Array_Equal_Negative_One()
        {
            Assert.AreEqual(ops.IndexOfAKeySearch(commonArray, 400), -1);

        }
        [Test]
        public void Assert_Inserting_In_The_Middle_Works()
        {
            Assert.AreEqual(ops.InsertInTheMiddleOfAnArray(commonArray, 7, 3, 8), new int[] { 10, 11, 12,8,13, 14, 15 });

        }
    }
}
