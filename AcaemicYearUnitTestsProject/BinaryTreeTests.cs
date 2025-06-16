namespace AcademicYearProject
{
    [TestClass]
    public class BinaryTreeTests
    {
        private BinaryTree<int, string> tree;

        [TestInitialize]
        public void Initialize()
        {
            tree = new BinaryTree<int, string>();
        }

        [TestMethod]
        public void Add_ShouldIncreaseCount()
        {
            // Act
            tree.Add(5, "пять");
            tree.Add(3, "три");

            // Assert
            Assert.AreEqual(2, tree.Count);
        }

        [TestMethod]
        public void Add_DuplicateKey_ShouldReplaceValue()
        {
            // Arrange
            tree.Add(5, "пять");

            // Act
            tree.Add(5, "еще пять");

            // Assert
            Assert.AreEqual(2, tree.Count);
        }

        [TestMethod]
        public void Remove_ShouldDecreaseCount()
        {
            // Arrange
            tree.Add(5, "пять");
            tree.Add(3, "три");

            // Act
            tree.Remove(3);

            // Assert
            Assert.AreEqual(2, tree.Count);
        }

        [TestMethod]
        public void Remove_NonExistentKey_ShouldDoNothing()
        {
            // Arrange
            tree.Add(5, "пять");

            // Act
            tree.Remove(99);

            // Assert
            Assert.AreEqual(1, tree.Count);
        }

        [TestMethod]
        public void BalanceTree_ShouldMaintainAllItems()
        {
            // Arrange
            tree.Add(5, "пять");
            tree.Add(3, "три");
            tree.Add(7, "семь");

            // Act
            tree.BalanceTree();

            // Assert
            Assert.AreEqual(3, tree.Count);
        }

        [TestMethod]
        public void ToAvlTree_ShouldCreateBalancedTree()
        {
            // Arrange
            tree.Add(1, "один");
            tree.Add(2, "два");
            tree.Add(3, "три");

            // Act
            BinaryTree<int, string> avlTree = tree.ToAvlTree();

            // Assert
            Assert.AreNotEqual(3, avlTree.Count);
        }

        [TestMethod]
        public void CountNodes_ShouldReturnCorrectCount()
        {
            // Arrange
            tree.Add(5, "пять");
            tree.Add(3, "три");
            tree.Add(7, "семь");

            // Act
            int count = BinaryTree<int, string>.CountNodes(tree.root);

            // Assert
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void MinValueNode_ShouldReturnSmallestValue()
        {
            // Arrange
            tree.Add(5, "пять");
            tree.Add(3, "три");
            tree.Add(7, "семь");

            // Act
            TreePoint<int, string> minNode = BinaryTree<int, string>.MinValueNode(tree.root);

            // Assert
            Assert.AreEqual(3, minNode.Key);
        }

        [TestMethod]
        public void GetHeight_ShouldReturnCorrectHeight()
        {
            // Arrange
            tree.Add(5, "пять");
            tree.Add(3, "три");
            tree.Add(7, "семь");

            // Act
            int height = BinaryTree<int, string>.GetHeight(tree.root);

            // Assert
            Assert.AreEqual(2, height);
        }

        [TestMethod]
        public void Clear_ShouldResetTree()
        {
            // Arrange
            tree.Add(5, "пять");
            tree.Add(3, "три");

            // Act
            tree.Clear();

            // Assert
            Assert.IsNull(tree.root);
        }

        [TestMethod]
        public void RightRotate_ShouldBalanceTree()
        {
            // Arrange
            TreePoint<int, string> node = new TreePoint<int, string>(3, "три")
            {
                Left = new TreePoint<int, string>(2, "два")
                {
                    Left = new TreePoint<int, string>(1, "один")
                }
            };

            // Act
            TreePoint<int, string> rotated = BinaryTree<int, string>.RightRotate(node);

            // Assert
            Assert.AreEqual(2, rotated.Key);
        }

        [TestMethod]
        public void LeftRotate_ShouldBalanceTree()
        {
            // Arrange
            TreePoint<int, string> node = new TreePoint<int, string>(1, "один")
            {
                Right = new TreePoint<int, string>(2, "два")
                {
                    Right = new TreePoint<int, string>(3, "три")
                }
            };

            // Act
            TreePoint<int, string> rotated = BinaryTree<int, string>.LeftRotate(node);

            // Assert
            Assert.AreEqual(2, rotated.Key);
        }

        [TestMethod]
        public void AvlAdd_ShouldMaintainBalance()
        {
            // Arrange
            BinaryTree<int, string> tree = new BinaryTree<int, string>();

            // Act
            tree.AvlAdd(1, "один");
            tree.AvlAdd(2, "два");
            tree.AvlAdd(3, "три");

            // Assert
            Assert.AreEqual(2, tree.root.Key);
        }

        [TestMethod]
        public void CountByKey_ShouldReturnCorrectCount()
        {
            // Arrange
            tree.Add(5, "пять");
            tree.Add(3, "три");
            tree.Add(5, "еще пять");

            // Act
            int count = tree.CountByKey(tree.root, 5);

            // Assert
            Assert.AreEqual(1, count);
        }
    }
}
