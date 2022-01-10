using DATA_STRUCTURES.Stacks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Ninja
{
    class TestArrayStack
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Assert_IsEmpty_Returns_True_Before_Pushing_Anything()
        {
            var stack = new CustomStackUsingArray<int>(5);

            Assert.AreEqual(true, stack.IsEmpty());
        }

        [Test]
        public void Assert_IsEmpty_Returns_False_After_Pushing()
        {
            var stack = new CustomStackUsingArray<int>(5);

            stack.Push(9);

            Assert.AreEqual(false, stack.IsEmpty());
        }

        [Test]
        public void Assert_Pushing_Into_Stack_Works()
        {
            var stack = new CustomStackUsingArray<int>(5);

            stack.Push(9);

            Assert.AreEqual(9,stack.data[0]);
        }

        [Test]
        public void Assert_Peeking_Into_Stack_Works()
        {
            var stack = new CustomStackUsingArray<int>(10);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);

            Assert.AreEqual(10, stack.Peek());
        }

        [Test]
        public void Assert_Peeking_Into_Empty_Stack_Throws()
        {
            var stack = new CustomStackUsingArray<int>(10);

            Assert.Throws<Exception>(()=> stack.Peek(),"The stack is empty");
        }

        [Test]
        public void Assert_Poping_Empty_Stack_Throws()
        {
            var stack = new CustomStackUsingArray<int>(10);

            Assert.Throws<Exception>(() => stack.Pop(), "The stack is empty");
        }

        [Test]
        public void Assert_Poping_From_A_Stack_Returns_The_Poped_Value()
        {
            var stack = new CustomStackUsingArray<int>(10);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);

            Assert.AreEqual(10, stack.Pop());
        }
    }

}
