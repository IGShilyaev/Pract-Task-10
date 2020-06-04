using Microsoft.VisualStudio.TestTools.UnitTesting;
using PractTask10;

namespace TestPractTask10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int[] arr = new int[10];
            MyIdealTree<int> tree = new MyIdealTree<int>(arr);
            //Act
            tree.TerminateTree(ref tree.root);
            //Assert
            Assert.AreEqual(tree.root, null);
        }

        [TestMethod]
        public void CountTest()
        {
            //Arrange
            int[] arr = new int[10];
            MyIdealTree<int> tree = new MyIdealTree<int>(arr);
            int expected = 10;
            //Act
            int actual = tree.Count;
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void EnumeratorTest()
        {
            //Arrange
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++) arr[i] = 1;
            MyIdealTree<int> tree = new MyIdealTree<int>(arr);
            int expected = 10;
            //Act
            int actual = 0;
            foreach (int x in tree) actual += x;
            //Assert
            Assert.AreEqual(actual, expected);

        }
    }
}
