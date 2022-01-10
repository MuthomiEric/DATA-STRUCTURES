using Data_STRUCTURES.Linked_List;
using DATA_STRUCTURES.Linked_List;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Ninja
{
    class TestLinkedListOperations
    {
        CustomLinkedList linkedList;


        [SetUp]
        public void Setup()
        {
           linkedList = new CustomLinkedList();

        }

        [Test]
        public void Assert_That_Finding_A_Node_By_Value_Works()
        {
            linkedList.Add(1, 2, 3, 4);

            Assert.AreEqual(linkedList.Find(2).Data, new Node(2).Data);
        }

        [Test]
        public void Assert_That_It_Throws_If_List_Is_Empty()
        {
            Assert.Throws<NullReferenceException>(()=> linkedList.FindByIndex(1));
        }

        [Test]
        public void Assert_That_It_Returns_Null_If_Index_Not_Found()
        {

            linkedList.Add(1, 2, 3, 4);

            Assert.AreEqual(linkedList.FindByIndex(8), null);
        }

        [Test]
        public void Assert_That_The_Correct_Node_Is_Returned_For_A_Given_Index()
        {
           
            linkedList.Add(1, 2, 3, 4);

            Assert.AreEqual(linkedList.FindByIndex(1).Data,new Node(2).Data);
        }

    }
}
