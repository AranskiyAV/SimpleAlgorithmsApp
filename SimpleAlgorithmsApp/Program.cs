using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleAlgorithmsApp
{


    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Выберети структуру данных: \n" +
                                   "1 - \"Односвязный список\"\n" +
                                   "2 - \"Двусвязный список\"\n" +
                                   "3 - \"Стек на основе массива\"\n" +
                                   "4 - \"Стек на основе односвязного списка\"\n" +
                                   "5 - \"Очередь\"\n" +
                                   "6 - \"Двусторонняя очередь(Дек)\"\n" +
                                   "7 - \"Кольцевой односвязный список\"\n" +
                                   "8 - \"Кольцевой двусвязный список\"\n" +
                                   "9 - \"Словарь\"\n" +
                                   "10 - \"Отсортированный словарь\"\n"
                                   );
                string myAlgorithms = Console.ReadLine();

                sw1(myAlgorithms);

                Console.ReadLine();
            }

            // Данный метод выводит выбор пользователя
            static void sw1(string s)
            {
                bool isPresent;
                switch (s)
                {
                    case "1":
                        Console.WriteLine("Вы выбрали \"Односвязный список\"\n");

                        LinkedList<string> linkedList = new LinkedList<string>();
                        // добавление элементов
                        linkedList.Add("Tom");
                        linkedList.Add("Alice");
                        linkedList.Add("Bob");
                        linkedList.Add("Sam");

                        // выводим элементы
                        Console.WriteLine("Выводим элементы:\n");
                        foreach (var item in linkedList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();

                        // удаляем элемент
                        Console.WriteLine("Удаляем элемент: Alice\n");
                        linkedList.Remove("Alice");
                        foreach (var item in linkedList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();

                        // проверяем наличие элемента
                        Console.WriteLine("Проверяем наличие элемента: Sam\n");
                        isPresent = linkedList.Contains("Sam");
                        Console.WriteLine(isPresent == true ? "Sam присутствует" : "Sam отсутствует");
                        Console.ReadLine();

                        // добавляем элемент в начало    
                        Console.WriteLine("Добавляем элемент Bill в начало очереди\n");
                        linkedList.AppendFirst("Bill");
                        Console.ReadLine();

                        // выводим элементы
                        Console.WriteLine("Выводим элементы:\n");
                        foreach (var item in linkedList)
                        {
                            Console.WriteLine(item);
                        }

                        break;
                    case ("2"):
                        Console.WriteLine("Вы выбрали \"Двусвязный список\"\n");
                        DoublyLinkedList<string> DoublyList = new DoublyLinkedList<string>();
                        // добавление элементов
                        DoublyList.Add("Bob");
                        DoublyList.Add("Bill");
                        DoublyList.Add("Tom");
                        DoublyList.AddFirst("Kate");

                        // выводим элементы
                        Console.WriteLine("Выводим элементы:\n");
                        foreach (var item in DoublyList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();

                        // проверяем наличие элемента
                        Console.WriteLine("Проверяем наличие элемента: Kate\n");
                        isPresent = DoublyList.Contains("Kate");
                        Console.WriteLine(isPresent == true ? "Kate присутствует" : "Kate отсутствует");
                        Console.ReadLine();

                        // удаление
                        Console.WriteLine("Удаляем элемент: Bill\n");
                        DoublyList.Remove("Bill");
                        Console.ReadLine();
                        // выводим элементы
                        Console.WriteLine("Выводим элементы после удаления:\n");
                        foreach (var item in DoublyList)
                        {
                            Console.WriteLine(item);
                        }

                        // перебор с последнего элемента
                        Console.WriteLine("Выводим элементы в обратном порядке:\n");
                        foreach (var t in DoublyList.BackEnumerator())
                        {
                            Console.WriteLine(t);
                        }
                        Console.ReadLine();
                        break;

                    case ("3"):
                        Console.WriteLine("Вы выбрали \"Стек на основе массива\"");

                        // добавление элементов
                        Stack<string> numbers = new Stack<string>();
                        numbers.Push("Tom");
                        numbers.Push("Bill");
                        numbers.Push("Alice");
                        numbers.Push("Bob");
                        numbers.Push("Kate");

                        Console.WriteLine("Выводим элементы:\n");
                        foreach (string number in numbers)
                        {
                            Console.WriteLine(number);
                        }
                        Console.ReadLine();

                        Console.WriteLine("Находим и Удаляем элемент в вверхней части стека '{0}'", numbers.Pop());
                        Console.ReadLine();

                        Console.WriteLine("Находим элемент в вверхней части стека: {0}", numbers.Peek());
                        Console.ReadLine();

                        Console.WriteLine("Находим и Удаляем элемент в вверхней части стека '{0}'", numbers.Pop());
                        Console.ReadLine();

                        // Create a copy of the stack, using the ToArray method and the 
                        // constructor that accepts an IEnumerable<T>. 
                        Stack<string> stack2 = new Stack<string>(numbers.ToArray());

                        Console.WriteLine("Создаем копию первого стека:");
                        foreach (string number in stack2)
                        {
                            Console.WriteLine(number);
                        }
                        Console.ReadLine();

                        // Create an array twice the size of the stack and copy the 
                        // elements of the stack, starting at the middle of the  
                        // array.  
                        string[] array2 = new string[numbers.Count * 2];
                        numbers.CopyTo(array2, numbers.Count);

                        // Create a second stack, using the constructor that accepts an 
                        // IEnumerable(Of T). 
                        Stack<string> stack3 = new Stack<string>(array2);

                        Console.WriteLine("Contents of the second copy, with duplicates and nulls:");
                        foreach (string number in stack3)
                        {
                            Console.WriteLine(number);
                        }
                        Console.ReadLine();

                        isPresent = stack2.Contains("Bill");
                        Console.WriteLine(isPresent == true ? "\"Bill\" присутствует" : "\"Bill\" отсутствует");
                        Console.ReadLine();

                        Console.WriteLine("stack2.Clear()");
                        stack2.Clear();
                        Console.WriteLine("stack2.Count = {0}", stack2.Count);
                        Console.ReadLine();

                        Console.WriteLine("stack3.Count = {0}", stack3.Count);
                        Console.ReadLine();

                        Console.WriteLine("stack.Count = {0}", numbers.Count);
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("\nВы выбрали \"Стек на основе односвязного списка\"\n");

                        NodeStack<string> stack = new NodeStack<string>();
                        stack.Push("Tom");
                        stack.Push("Alice");
                        stack.Push("Bob");
                        stack.Push("Kate");

                        foreach (var item in stack)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine();
                        Console.ReadLine();

                        string header = stack.Peek();
                        Console.WriteLine($"Верхушка стека: {header}");
                        Console.WriteLine();
                        Console.ReadLine();

                        header = stack.Pop();
                        foreach (var item in stack)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();

                        break;
                    case "5":
                        Console.WriteLine("Вы выбрали \"Очередь\"");
                        Queue<string> queue = new Queue<string>();
                        queue.Enqueue("Kate");
                        queue.Enqueue("Sam");
                        queue.Enqueue("Alice");
                        queue.Enqueue("Tom");
                        foreach (string item in queue)
                            Console.WriteLine(item);
                        Console.WriteLine();
                        Console.ReadLine();

                        string first = queue.First;
                        Console.WriteLine($"Первый элемент очереди: {first}");

                        string last = queue.Last;
                        Console.WriteLine($"Последний элемент очереди: {last}");

                        string firstItem = queue.Dequeue();
                        Console.WriteLine($"Извлеченный элемент: {firstItem}");
                        Console.ReadLine();


                        foreach (string item in queue)
                            Console.WriteLine(item);
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine("Вы выбрали \"Двусторонняя очередь(Дек)\"\n");
                        Deque<string> usersDeck = new Deque<string>();
                        usersDeck.AddFirst("Alice");
                        usersDeck.AddLast("Kate");
                        usersDeck.AddLast("Tom");
                        usersDeck.AddLast("Bill");
                        usersDeck.AddLast("Bob");

                        foreach (string q in usersDeck)
                            Console.WriteLine(q);
                        Console.ReadLine();

                        string removedItem = usersDeck.RemoveFirst();
                        Console.WriteLine("\n Удален первый: {0} \n", removedItem);

                        string removedItemLast = usersDeck.RemoveLast();
                        Console.WriteLine("\n Удален последний: {0} \n", removedItemLast);

                        foreach (string q in usersDeck)
                            Console.WriteLine(q);
                        Console.ReadLine();

                        break;

                    case "7":
                        Console.WriteLine("Вы выбрали \"Кольцевой односвязный список\"\n");
                        CircularLinkedList<string> circularList = new CircularLinkedList<string>();

                        circularList.Add("Tom");
                        circularList.Add("Bob");
                        circularList.Add("Alice");
                        circularList.Add("Jack");
                        foreach (var item in circularList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();

                        circularList.Remove("Bob");
                        Console.WriteLine("\n После удаления: \n");
                        foreach (var item in circularList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();

                        circularList.Add("Halk");
                        Console.WriteLine("\n После добавления: \n");
                        foreach (var item in circularList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();
                        break;

                    case "8":
                        Console.WriteLine("Вы выбрали \"Кольцевой двусвязный список\"\n");
                        CircularDoublyLinkedList<string> circulardoubleList = new CircularDoublyLinkedList<string>();
                        circulardoubleList.Add("Tom");
                        circulardoubleList.Add("Bob");
                        circulardoubleList.Add("Alice");
                        circulardoubleList.Add("Sam");

                        foreach (var item in circulardoubleList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();

                        string removeItem = "Bob";
                        circulardoubleList.Remove(removeItem);
                        Console.WriteLine("\nПосле удаления: {0} \n", removeItem);
                        foreach (var item in circulardoubleList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();
                        string addItem = "Boby";
                        circulardoubleList.Add(addItem);
                        Console.WriteLine("\nПосле добавления: {0} \n", addItem);
                        foreach (var item in circulardoubleList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();

                        isPresent = circulardoubleList.Contains("Alice");
                        Console.WriteLine(isPresent == true ? "\"Alice\" присутствует" : "\"Alice\" отсутствует");
                        Console.ReadLine();

                        break;

                    case "9":
                        Console.WriteLine("Вы выбрали \"Словарь\"\n");
                        Console.Write("Сколько сотрудников добавить? ");
                        try
                        {
                            int i = int.Parse(Console.ReadLine());
                            Dictionary<int, string> dic = UserInfo.MyDic(i);

                            // Получить коллекцию ключей
                            ICollection<int> keys = dic.Keys;

                            Console.WriteLine("База данных содержит: ");
                            foreach (int j in keys)
                                Console.WriteLine("ID -> {0}  Name -> {1}", j, dic[j]);

                            //Console.WriteLine();
                            //foreach (KeyValuePair<int, string> kvp in dic)
                            //{
                            //    Console.WriteLine("Key = {0}, Value = {1}",
                            //        kvp.Key, kvp.Value);
                            //}

                            // Поиск по ключу
                            Console.Write("Введите ключ:");
                            int k = int.Parse(Console.ReadLine());
                                                 
                            string value = "";
                            if (dic.TryGetValue(k, out value))
                            {
                                Console.WriteLine("Для ключа = {0}, значение = {1}.", k, value);
                            }
                            else
                            {
                                Console.WriteLine("Ключ = {0} не найден.", k);
                            }
                           
                            // Поиск по ключу
                            //Console.Write("Введите ключ:");
                            //int k = int.Parse(Console.ReadLine());

                            //string value = "";
                            //if (dic.TryGetValue(k, out value))
                            //{
                            //    Console.WriteLine("Для ключа = {0}, значение = {1}.", k, value);
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Ключ = {0} не найден.", k);
                            //}

                            Console.Write("Введите ключ удаляемого значения:");
                            int a = int.Parse(Console.ReadLine());
                            dic.Remove(a);
                            Console.WriteLine();
                            foreach (KeyValuePair<int, string> kvp in dic)
                            {
                                Console.WriteLine("Key = {0}, Value = {1}",
                                    kvp.Key, kvp.Value);
                            }

                            int count = dic.Count();
                            Console.WriteLine("Count = {0}", count);
                            int hashcode =  dic.GetHashCode();
                            Console.WriteLine("hashcode = {0}", hashcode);
                            Console.WriteLine();
                            foreach (KeyValuePair<int, string> kvp in dic)
                            {
                                Console.WriteLine("Key = {0}, Value = {1}",
                                    kvp.Key, kvp.Value);
                            }
                            
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Неверный ввод");
                        }

                        Console.ReadLine();
                        break;
                    case "10":
                        Console.WriteLine("Вы выбрали \"Отсортированный cловарь\"\n");
                        Console.Write("Сколько сотрудников добавить? ");
                        try
                        {
                            int i = int.Parse(Console.ReadLine());
                            SortedDictionary<string, string> dic = SortedDictionary.MyDic(i);

                            // Получить коллекцию ключей
                            ICollection<string> keys = dic.Keys;

                            Console.WriteLine("\nСортированная база данных содержит: ");
                            foreach (string j in keys)
                                Console.WriteLine("ID -> {0}  Name -> {1}", j, dic[j]);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Неверный ввод");
                        }

                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("\nТаких данных нет :(");
                        break;
                }

            }
        }

    }

}
