namespace AcademicYearProject
{
    [TestClass]
    public class TreePointTests
    {
        [TestMethod]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange & Act
            TreePoint<int, string> treePoint = new TreePoint<int, string>(1, "тестовое значение");

            // Assert
            Assert.AreEqual(1, treePoint.Key);
            Assert.AreEqual("тестовое значение", treePoint.Value);
            Assert.IsNull(treePoint.Left);
            Assert.IsNull(treePoint.Right);
            Assert.AreEqual(1, treePoint.Height);
        }

        [TestMethod]
        public void LeftProperty_CanBeSetAndRetrieved()
        {
            // Arrange
            TreePoint<int, string> parent = new TreePoint<int, string>(2, "родитель");
            TreePoint<int, string> leftChild = new TreePoint<int, string>(1, "левый потомок");

            // Act
            parent.Left = leftChild;

            // Assert
            Assert.IsNotNull(parent.Left);
            Assert.AreEqual(leftChild, parent.Left);
            Assert.AreEqual("левый потомок", parent.Left.Value);
        }

        [TestMethod]
        public void RightProperty_CanBeSetAndRetrieved()
        {
            // Arrange
            TreePoint<int, string> parent = new TreePoint<int, string>(1, "родитель");
            TreePoint<int, string> rightChild = new TreePoint<int, string>(2, "правый потомок");

            // Act
            parent.Right = rightChild;

            // Assert
            Assert.IsNotNull(parent.Right);
            Assert.AreEqual(rightChild, parent.Right);
            Assert.AreEqual("правый потомок", parent.Right.Value);
        }

        [TestMethod]
        public void HeightProperty_CanBeModified()
        {
            // Arrange
            TreePoint<int, string> node = new TreePoint<int, string>(1, "тест");

            // Act
            node.Height = 3;

            // Assert
            Assert.AreEqual(3, node.Height);
        }

        [TestMethod]
        public void ValueProperty_CanBeUpdated()
        {
            // Arrange
            TreePoint<int, string> node = new TreePoint<int, string>(1, "значение");

            // Act
            node.Value = "новое значение";

            // Assert
            Assert.AreEqual("новое значение", node.Value);
        }

        [TestMethod]
        public void KeyProperty_CanBeUpdated()
        {
            // Arrange
            TreePoint<int, string> node = new TreePoint<int, string>(1, "значение");

            // Act
            node.Key = 2;

            // Assert
            Assert.AreEqual(2, node.Key);
        }

        [TestMethod]
        public void DefaultHeight_IsOne()
        {
            // Arrange & Act
            TreePoint<int, string> node = new TreePoint<int, string>(1, "тест");

            // Assert
            Assert.AreEqual(1, node.Height);
        }

        [TestMethod]
        public void CanStoreDifferentValueTypes()
        {
            // Arrange & Act
            TreePoint<int, string> stringNode = new TreePoint<int, string>(1, "строковое значение");
            TreePoint<string, int> intNode = new TreePoint<string, int>("ключ", 42);
            TreePoint<string, Outfit> complexNode = new TreePoint<string, Outfit>("аутфит",
                new Outfit(1, "рубашка", "верхняя", "верх", "м", "в", "обычное", "нет", "кэжуал", "лето", "солнечно"));

            // Assert
            Assert.AreEqual("строковое значение", stringNode.Value);
            Assert.AreEqual(42, intNode.Value);
            Assert.AreEqual("рубашка", complexNode.Value.Name);
        }

        [TestMethod]
        public void CanStoreNullValues()
        {
            // Arrange & Act
            TreePoint<int, string> node = new TreePoint<int, string>(1, null);

            // Assert
            Assert.IsNull(node.Value);
        }
    }
}
