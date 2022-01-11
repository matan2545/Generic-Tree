using System;
using System.Collections.Generic;

namespace GenericsWork
{
    class Program
    {
        static GenericTree<int> tree = new GenericTree<int>();
        static void Main(string[] args)
        {
            try {
                int index;
                string input = Constants.EMPTY_INPUT;

                Dictionary<int, Action> menuDictionary = new Dictionary<int, Action>();
                menuDictionary.Add(Constants.INSERT_INDEX, InsertValue); //1
                menuDictionary.Add(Constants.DELETE_INDEX, DeleteValue); //2
                menuDictionary.Add(Constants.PRE_ORDER_INDEX, PrintPreOrder); //3
                menuDictionary.Add(Constants.IN_ORDER_INDEX, PrintInOrder); //4
                menuDictionary.Add(Constants.POST_ORDER_INDEX, PrintPostOrder); //5
                menuDictionary.Add(Constants.EXIT_INDEX, Exit); //6

                Console.WriteLine(Constants.MENU, tree.GetGenericType().Name);
                while (true) {
                    try {
                        input = Console.ReadLine();
                        index = int.Parse(input);
                        menuDictionary[index]();
                        Console.WriteLine(Constants.DONE_MESSAGE);
                    }
                    catch (InvalidTypeException e) {
                        Console.WriteLine(e.Message);
                    }
                    catch (FormatException) {
                        Console.WriteLine(Constants.INVALID_INDEX);
                    }
                    catch (KeyNotFoundException) {
                        Console.WriteLine(Constants.MENU_ERROR, input);
                    }
                    catch (ValueNotFoundException e) {
                        Console.WriteLine(e.Message);
                    }
                    finally {
                        Console.WriteLine(Constants.CONTINUE_MESSAGE);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(Constants.MENU, tree.GetGenericType().Name);
                    }
                }
            }
            catch (Exception) {
                Console.WriteLine(Constants.ERROR);
            }
        }
        private static void InsertValue()
        {
            dynamic userInput;
            Console.WriteLine(Constants.INSERT_MESSAGE);
            if (tree.GetGenericType() == typeof(int)) {
                userInput = int.Parse(Console.ReadLine());
                tree.Insert(userInput);
            }
            else if (tree.GetGenericType() == typeof(string)) {
                userInput = Console.ReadLine();
                tree.Insert(userInput);
            }
            else
                throw new InvalidTypeException(Constants.INVLID_TYPE);
        }
        private static void DeleteValue()
        {
            if (tree.IsEmpty()) {
                Console.WriteLine(Constants.EMPTY_TREE);
            }
            else {
                dynamic userInput;
                Console.WriteLine(Constants.DELETE_MESSAGE);
                if (tree.GetGenericType() == typeof(int)) {
                    userInput = int.Parse(Console.ReadLine());
                    tree.Remove(userInput);
                }
                else if (tree.GetGenericType() == typeof(string)) {
                    userInput = Console.ReadLine();
                    tree.Remove(userInput);
                }
                else
                    throw new InvalidTypeException(Constants.INVLID_TYPE);
            }
        }
        private static void PrintPreOrder()
        {
            if (tree.IsEmpty())
                Console.WriteLine(Constants.EMPTY_TREE);
            else {
                Utils<int>.PrintPreOrder(tree.Root);
            }
        }
        private static void PrintInOrder()
        {
            if (tree.IsEmpty())
                Console.WriteLine(Constants.EMPTY_TREE);
            else {
                Utils<int>.PrintInOrder(tree.Root);
            }
        }
        private static void PrintPostOrder()
        {
            if (tree.IsEmpty())
                Console.WriteLine(Constants.EMPTY_TREE);
            else {
                Utils<int>.PrintPostOrder(tree.Root);
            }
        }
        private static void Exit()
        {
            Console.WriteLine(Constants.EXIT_MESSAGE);
            Environment.Exit(Constants.EXIT_CODE);
        }
    }
}
