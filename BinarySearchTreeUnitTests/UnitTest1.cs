using BinarySearchTreeFromUnsortedArray;

namespace BinarySearchTreeUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenAnArrayWithOneItem_CreateSubTree_ShouldReturnOnlyRootNode()
        {
            //Arrange
            var input = new int[] { 2 };

            //Act
            var result = BinaryTree.CreateSubTree(input);

            //Assert
            Assert.Equal(result.Data, input[0]);
            Assert.Null(result.Left);
            Assert.Null(result.Right);
        }

        [Fact]
        public void GivenAnNullOrEmptyArray_CreateSubTree_ShouldThrowException()
        {
            //Arrange
            //Act


            //Assert
            Assert.Throws<ArgumentNullException>(() => BinaryTree.CreateSubTree(null));
            Assert.Throws<ArgumentNullException>(() => BinaryTree.CreateSubTree(new int[] { }));
        }

        [Fact]
        public void GivenASortedArray_CreateSubTree_ShouldBuildABalancedBinarySearchTree()
        {
            
        }
    }
}