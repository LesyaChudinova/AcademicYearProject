using System;
using System.Collections.Generic;

namespace AcademicYearProject
{
    public class BinaryTree<TKey, TValue> 
    {
        public TreePoint<TKey, TValue> root; //корень дерева
        public int count; //счетчик
        public int Count => count; //свойство для счетчика

        public static int GetHeight(TreePoint<TKey, TValue> node) //полуаем высоту дерева
        {
            if (node == null) return 0;
            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right)); //левое поддерево, правое поддерево и корень
        }


        private static TreePoint<TKey, TValue> Add(TreePoint<TKey, TValue> node, TKey key, TValue value)
        {
            if (node == null)
            {
                return new TreePoint<TKey, TValue>(key, value);
            }
            //сравнивем по хэш-коду (там номер вагона)
            if (key.GetHashCode() < node.Key.GetHashCode())
            {
                node.Left = Add(node.Left, key, value); //меньшие относим влево значения
            }
            else if (key.GetHashCode() > node.Key.GetHashCode()) //большие значения вправо
            {
                node.Right = Add(node.Right, key, value);
            }
            else
            {
                node.Value = value; //пока что обработка коллизий просто заменой значения
            }

            return node;
        }

        public void Add(TKey key, TValue value) //прошлый метод возвращает обновленное дерево (не процедура, потому что
                                                //используется рекурсия), сделаем процедуру для легкого вызова в программе
        {
            root = Add(root, key, value);
            count++;
        }

        public void BalanceTree() //процедура для балансировки дерева
        {
            int nodeCount = CountNodes(root); //надо понимать сколько всего узлов
            //балансировать будем через массив
            TreePoint<TKey, TValue>[] nodes = new TreePoint<TKey, TValue>[nodeCount]; //создаем его
            int index = 0;
            FillArrayInOrderTrav(root, nodes, ref index); //заполняем массив узлами дерева

            root = BuildBalancedTree(nodes, 0, nodes.Length - 1); //возвращаем корень дереву
        }

        public void FillArrayInOrderTrav(TreePoint<TKey, TValue> node, TreePoint<TKey, TValue>[] array, ref int index)
        {
            if (node == null) return; //если узлов нет в дереве, то и массив будет нулевой

            FillArrayInOrderTrav(node.Left, array, ref index); //рекурсивно заполняем массив узлами сначала левого дерева
            array[index++] = node;
            FillArrayInOrderTrav(node.Right, array, ref index); //потом правого
        }

        //получили массив - делаем сбалансированное дерево
        public static TreePoint<TKey, TValue> BuildBalancedTree(TreePoint<TKey, TValue>[] nodes, int start, int end)
        {
            if (start > end)
                return null; //когда границы "схлопнутся" - закончим

            //находим середину - это будет корень поддерева; каждый раз при рекурсивном входе будет пересчитываться
            int mid = (start + end) / 2;
            TreePoint<TKey, TValue> root = nodes[mid];

            root.Left = BuildBalancedTree(nodes, start, mid - 1); //рекурсией строим поддеревья
            root.Right = BuildBalancedTree(nodes, mid + 1, end);

            //обновляем высоту узла
            root.Height = 1 + Math.Max(GetHeight(root.Left), GetHeight(root.Right));

            return root;
        }
        public int CountByKey(TreePoint<TKey, TValue> node, TKey key) //метод для поиска элемента по ключу (для задания)
        {
            if (node == null) return 0; //если узлов нет - сразу возвращаем 0, т.к. элементов не найдем

            int count = 0; //заводим локальный счетчик. то поле - приватное, поэтому назвала так же
            if (node.Key.Equals(key)) //если находим элемент с искомым номером
                count++; //увеличиваем

            return count + CountByKey(node.Left, key) + CountByKey(node.Right, key); //рекурсивно проходим по поддеревьям
        } //в результате получим количество найденных элементов с нужным ключом

        public void PrintOutfitsByKey(TreePoint<TKey, TValue> node, int key) //добавила потом - чтобы подробно информацию всю вывести,
                                                                          //параметры - узел и искомый ключ. Пригодится только при выполнении задания, просто для удобства своего

        {
            if (node == null) return; //если узла нет - заканчиваем

            if (node.Key.Equals(key)) //находим нужный ключ
            {
                Console.WriteLine($"- {node.Value}"); //находим - значит выводим значение
            }

            PrintOutfitsByKey(node.Left, key); //и так рекурсивно по всему дереву
            PrintOutfitsByKey(node.Right, key);
        }

        //вывод дерева более красиво
        //но здесь мы будем использовать только ключи, чтобы структура дерева прослеживалась
        //для вывода информации (ключа и значения) о каждом элементе дерева будет использоваться PrintByLevels
        public void PrintAsTree(TreePoint<TKey, TValue> item, int lenght)
        {
            if (item != null) //если корень не нулевой
            {
                PrintAsTree(item.Left, lenght + 3); //рекурсивно запускаем функцию
                for (int i = 0; i < lenght; i++)
                    Console.Write(" "); //выводим отступы
                Console.WriteLine(item.Key); //и непосредственно ключ
                PrintAsTree(item.Right, lenght + 3);
            }
        } //функция добавлена, чтобы лучше отследить повороты в AVL


        public void PrintByLevels() //функция печати дерева по уровням
        {
            if (root == null) //если дерево пустое, то выводим сообщение
            {
                Console.WriteLine("Дерево пустое");
                return;
            }

            int height = GetHeight(root); //узнаем высоту дерева
            for (int level = 1; level <= height; level++) //проходим по этой высоте, отдельно выводя уровни
            {
                Console.WriteLine($"Уровень {level}");
                PrintLevel(root, level);
            }
            return;
        }

        private static void PrintLevel(TreePoint<TKey, TValue> node, int level) //функция для вывода уровня
        {
            if (node == null)
            {
                return; //уровня нет - ничего не выводим, заканчиваем
            }

            if (level == 1)
            {
                Console.WriteLine(node.Value + " <------------\n"); //когда рекурсивно доходим до корня, который надо вывести - выоводим
            }
            else if (level > 1) //если у узла есть потомки - уходим в них рекурсивно
            {
                PrintLevel(node.Left, level - 1);
                PrintLevel(node.Right, level - 1);
            }
            return;
        }

        public BinaryTree<TKey, TValue> ToAvlTree() //преобразование в avl
        {
            int count = CountNodes(root); //пересчитываем узлы
            TreePoint<TKey, TValue>[] nodes = new TreePoint<TKey, TValue>[count];
            int index = 0;
            FillArrayInOrderTrav(root, nodes, ref index); //переделываем их в массив

            BinaryTree<TKey, TValue> avlTree = new BinaryTree<TKey, TValue>();
            avlTree.root = BuildBalancedTree(nodes, 0, nodes.Length - 1); //строим avl (аналогично балансировке)
            return avlTree;
        }

        public static int CountNodes(TreePoint<TKey, TValue> node) //подсчет узлов
        {
            if (node == null) return 0;
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }

        public static TreePoint<TKey, TValue> MinValueNode(TreePoint<TKey, TValue> node)//найти
                                                                                        //наименьший элемент дерева
        {
            TreePoint<TKey, TValue> current = node; //вводим указатель, указывающий на текущий узел
            while (current.Left != null) //пока не дойдем до конца левого поддерева
                current = current.Left; //спускаемся влево
            return current;
        }

        public static int GetBalance(TreePoint<TKey, TValue> node) =>
            node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);//лямбда-функция для вычисления
        //разницы от сбалансированного дерева (между самой короткой и длинной веткой дерева

        //функции правого и левого поворотов
        public static TreePoint<TKey, TValue> RightRotate(TreePoint<TKey, TValue> node)
        {
            //подробно объяснены в разделе проектирования в отчете, заключаются в том, чтобы
            //повернуть дерево относительно одного из потомков
            TreePoint<TKey, TValue> leftChild = node.Left;
            TreePoint<TKey, TValue> rightChildOfLeftChild = leftChild.Right;

            leftChild.Right = node;
            node.Left = rightChildOfLeftChild;

            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
            leftChild.Height = Math.Max(GetHeight(leftChild.Left), GetHeight(leftChild.Right)) + 1;

            return leftChild; //если правый поворот, то корнем становится левый потомок
        }

        public static TreePoint<TKey, TValue> LeftRotate(TreePoint<TKey, TValue> node)
        {
            TreePoint<TKey, TValue> rightChild = node.Right;
            TreePoint<TKey, TValue> leftChildOfRightChild = rightChild.Left;

            rightChild.Left = node;
            node.Right = leftChildOfRightChild;

            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
            rightChild.Height = Math.Max(GetHeight(rightChild.Left), GetHeight(rightChild.Right)) + 1;

            return rightChild; //а если левый поворот, то наоборот, правый
        }

        public TreePoint<TKey, TValue> Remove(TreePoint<TKey, TValue> node, TKey key) //тоже сначала функция рекурсивная
        {
            if (node == null) return null;
            //ищем элемент, который нужно удалить
            if (key.GetHashCode() < node.Key.GetHashCode()) //сравнивать будем по хэш-коду,
                                                            //вычисляется в базовом классе через номер вагона
            {
                node.Left = Remove(node.Left, key); //меньшие в левое поддерево
            }
            else if (key.GetHashCode() > node.Key.GetHashCode())
            {
                node.Right = Remove(node.Right, key); //большие в правое
            }
            else //если ключ все же равен искомому
            {
                if (node.Left == null) //если это дерево, у которого есть только правый потомок
                    return node.Right; //то новым корнем становится он
                else if (node.Right == null) //если левый, то наоборот
                    return node.Left;

                //если у дерева есть оба потомка
                TreePoint<TKey, TValue> temporary = MinValueNode(node.Right); //во временную переменную записываем
                //самый левый потомок правого поддерева
                node.Key = temporary.Key; //переприсваиваем ключ и значение
                node.Value = temporary.Value;
                node.Right = Remove(node.Right, temporary.Key); //удаляем
            }

            return node;
        }

        public void Remove(TKey key) //процедура удаления
        {
            root = Remove(root, key);
        }

        public void AvlAdd(TKey key, TValue value) //процедура добавления в avl
        {
            root = AvlAdd(root, key, value);
        }

        //и функция добавления в AVL
        public TreePoint<TKey, TValue> AvlAdd(TreePoint<TKey, TValue> node, TKey key, TValue value)
        {//в функции сначала все так же, как просто при добавлении
            if (node == null)
                return new TreePoint<TKey, TValue>(key, value);

            if (key.GetHashCode() < node.Key.GetHashCode())
                node.Left = AvlAdd(node.Left, key, value);
            else if (key.GetHashCode() > node.Key.GetHashCode())
                node.Right = AvlAdd(node.Right, key, value);
            else
            {
                node.Value = value;
                return node;
            }

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            //но делаем другую перебалансировку: поворотами
            int balance = GetBalance(node); //смотрим, нужна ли она, и в каую сторону

            if (balance > 1 && GetBalance(node.Left) >= 0) //если дерево смещено влево и внутри потомок тоже
                //перевешивает влево
                return RightRotate(node);

            if (balance < -1 && GetBalance(node.Left) <= 0) //если в правом перевешивающем поддереве смещение вправо
                return LeftRotate(node);

            if (balance > 1 && GetBalance(node.Right) >= 0) //если в левом перевес вправо
            {
                node.Left = LeftRotate(node.Left); //то двойной поворот: сначала влево, потом вправо
                return RightRotate(node);
            }

            if (balance < -1 && GetBalance(node.Left) >= 0) //если в правом влево - то наоборот
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        public void Clear() //процедура очищения дерева из памяти
        {
            ClearTree(root);
            root = null;
            GC.Collect();
        }

        public static void ClearTree(TreePoint<TKey, TValue> node) //рекурсивная функция очищения
        {
            if (node == null) return;
            ClearTree(node.Left);
            ClearTree(node.Right);
            node.Left = null;
            node.Right = null;
        }
    }
}