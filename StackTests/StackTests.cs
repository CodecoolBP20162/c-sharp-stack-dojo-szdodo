using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void StackTestNotNull()
        {
            Stack<int> testStack = new Stack<int>(5);
            Assert.IsNotNull(testStack);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The stack's size cannot be 0 or lower")]
        public void StackTestNull()
        {
            Stack<int> testStack = new Stack<int>(0);
        }

        [TestMethod()]
        public void pushTestOneElement()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(1);
            Assert.AreEqual(1,testStack.getUsedSize());
        }

        [TestMethod()]
        public void pushTestSeveralElement()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(1);
            testStack.push(1);
            testStack.push(1);
            testStack.push(1);
            Assert.AreEqual(4, testStack.getUsedSize());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The stack is already full")]
        public void pushTestToFullStack()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(1);
            testStack.push(1);
            testStack.push(1);
            testStack.push(1);
            testStack.push(1);
            testStack.push(6);
        }

        [TestMethod()]
        public void popTestReturnsTheRightElementOneItem()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(1);
            Assert.AreEqual(1,testStack.pop());
        }

        [TestMethod()]
        public void popTestReturnsTheRightElementSeveralItem()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(1);
            testStack.push(3);
            testStack.push(5);
            Assert.AreEqual(5, testStack.pop());
        }

        [TestMethod()]
        public void popTestUsedSizeChanged()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(1);
            testStack.push(21);
            testStack.push(24);
            testStack.pop();
            Assert.AreEqual(2, testStack.getUsedSize());
        }

        [TestMethod()]
        public void popTestSizeUnchanged()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(1);
            testStack.push(21);
            testStack.push(24);
            testStack.pop();
            Assert.AreEqual(5, testStack.getSize());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The stack is empty")]
        public void popTestEmtyStackException()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.pop();
        }

        [TestMethod()]
        public void peekTestReturnsRightElementOneItem()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(1);
            Assert.AreEqual(1, testStack.peek());
        }

        [TestMethod()]
        public void peekTestReturnsRightElementSeveralItem()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(4);
            testStack.push(21);
            testStack.push(4);
            testStack.push(2);
            Assert.AreEqual(2, testStack.peek());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The stack is empty")]
        public void peekTestEmtyStackException()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.peek();
        }

        [TestMethod()]
        public void getSizeTest()
        {
            Stack<int> testStack = new Stack<int>(5);
            Assert.AreEqual(5, testStack.getSize());
        }

        [TestMethod()]
        public void getUsedSizeTestEmptyStack()
        {
            Stack<int> testStack = new Stack<int>(5);
            Assert.AreEqual(0, testStack.getUsedSize());
        }

        [TestMethod()]
        public void getUsedSizeTestAlmostFullStack()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(4);
            testStack.push(21);
            testStack.push(4);
            testStack.push(2);
            Assert.AreEqual(4, testStack.getUsedSize());
        }

        [TestMethod()]
        public void getUsedSizeTestFullStack()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(4);
            testStack.push(21);
            testStack.push(4);
            testStack.push(3);
            testStack.push(2);
            Assert.AreEqual(5, testStack.getUsedSize());
        }

        [TestMethod()]
        public void getFreeSpacesTestEmptyStack()
        {
            Stack<int> testStack = new Stack<int>(5);
            Assert.AreEqual(5, testStack.getFreeSpaces());
        }

        [TestMethod()]
        public void getFreeSpacesTestAlmostFullStack()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(4);
            testStack.push(21);
            testStack.push(2);
            Assert.AreEqual(2, testStack.getFreeSpaces());
        }

        [TestMethod()]
        public void getFreeSpacesTestFullStack()
        {
            Stack<int> testStack = new Stack<int>(5);
            testStack.push(4);
            testStack.push(21);
            testStack.push(4);
            testStack.push(3);
            testStack.push(2);
            Assert.AreEqual(0, testStack.getFreeSpaces());
        }
    }
}