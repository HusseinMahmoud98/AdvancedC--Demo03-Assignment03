namespace Demo03
{
    internal class Program
    {
       
        public delegate int StringFuncDelegate(string str);

        public static List<int> FindOddNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();
            if (numbers?.Count>0)
            {
                foreach (var item in numbers)
                {
                    if (item % 2 != 0)
                    {
                       result.Add(item);
                    }
                }
            }
            

            return result;
        }

        public static List<int> FindNumbers(List<int> numbers, ConditionFuncDelegate reference)
        {
            List<int> result = new List<int>();
            if (numbers?.Count > 0)
            {
                foreach (var item in numbers)
                {
                    if (reference.Invoke(item))
                    {
                        result.Add(item);
                    }
                }
            }


            return result;
        }

        public static List<string> FindElements(List<string> list, ConditionFuncDelegateString reference)
        {
            List<string> Result = new List<string>();
            if(list?.Count > 0)
            {
                foreach (var item in list)
                {
                    if (reference.Invoke(item))
                    {
                        Result.Add(item);
                    }
                }
            }

            return Result;
        }

        public static List<T> FindElementsT<T>(List<T> list, ConditionFuncDelegateT<T> reference)
        {
            List<T> Result = new List<T>();
            if (list?.Count > 0)
            {
                foreach (var item in list)
                {
                    if (reference.Invoke(item))
                    {
                        Result.Add(item);
                    }
                }
            }

            return Result;
        }
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (var item in values)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }
        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (var item in values)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }
        public static int Func01() { return 1; }
        public static string Func02(int x) { return $"{x}"; }
        public static void PrintHelloWorld() { Console.WriteLine("Hello World"); }
        public static Action Func02()
        {
            Action action = PrintHelloWorld;
            //Action actio2 = () => Console.WriteLine("Hello World2");
            //Action action3 =  delegate ()  { Console.WriteLine("Hellow World3"); };
            return action;
        }

        
        static void Main(string[] args)
        {
            #region Delegate Ex01
            ////New Delegate(class): Reference (Pointer) can refer to function or more
            //// Thees Function must have the same signature of the delegate
            ////StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChars);
            //StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars;
            //Console.WriteLine(X.Invoke("Hello World")); //2

            //X += StringFunctions.GetCountOfLowerCaseChars;
            //Console.WriteLine(X("Hello World")); //8 

            #endregion

            #region Delegate Ex02
            //int[] Numbers = { 1, 7, -1, 0, 11, 29, 2 };

            //PrintArray<int>(Numbers);

            //SortingAlgorithms.BubbleSortAscending(Numbers);
            //PrintArray<int>(Numbers);

            //SortingAlgorithms.BubbleSortDescending(Numbers);
            //PrintArray<int>(Numbers);



            //SortingAlgorithms.BubbleSort(Numbers, SortingConditions.CompareGtr);
            //PrintArray<int>(Numbers);

            //SortingAlgorithms.BubbleSort(Numbers, SortingConditions.CompareLess);
            //PrintArray<int>(Numbers);

            //string[] names = { "Hussein", "Mahmoud", "Fouad", "ElSaid", "Ibrahim" };
            //PrintArray(names);

            //SortingAlgorithms.BubbleSort(names,  SortingConditions.CompareGtr);
            //PrintArray(names);

            //SortingAlgorithms.BubbleSort(names, SortingConditions.CompareLess);
            //PrintArray(names);

            //SortingAlgorithms.BubbleSortT<string>(names, SortingConditions.CompareGtr);
            //PrintArray(names);

            //SortingAlgorithms.BubbleSortT<string>(names, SortingConditions.CompareLess);
            //PrintArray(names); 
            #endregion

            #region Delegate Ex03
            //List<int> Numbers = Enumerable.Range(0, 10).ToList();
            //PrintList(Numbers);



            //List<int> OddNumbers = FindNumbers(Numbers, ConditionsFunctions.CheckOdd);
            //List<int> EvenNumbers = FindNumbers(Numbers, ConditionsFunctions.CheckEven);
            //List<int> DividbleByFourNumbers = FindNumbers(Numbers, ConditionsFunctions.CheckDivisableByFour);

            //PrintList(OddNumbers);
            //PrintList(EvenNumbers);
            //PrintList(DividbleByFourNumbers);

            //List<string> names = new List<string> { "Hussein", "Mahmoud", "Fouad", "ElSaid", "Ibrahim" };
            //PrintList(names);
            ////PrintList(FindElements(names, ConditionsFunctions.CheckStringLengthGreaterThanFive));
            //PrintList(FindElementsT<string>(names, ConditionsFunctions.CheckStringLengthGreaterThanFive));
            #endregion

            #region Built-in Delegates
            //// Built-in Delegates (Predicate, Func, Action)

            ////1. Predicate
            //Predicate<int> predicate = ConditionsFunctions.CheckEven;
            //Console.WriteLine(predicate.Invoke(1)); //False

            ////2. Func
            //Func<int> func1 = Func01;
            //Func<int, string> func2 = Func02;

            ////3. Action
            //Action action = PrintHelloWorld;
            //action.Invoke();
            //action(); 
            #endregion

            #region Anomymous Methods and Lamda Expression
            //List<int> Numbers = new List<int>() { 1, 2, 3 , 4, 5, 6};

            ////Anomymous Method
            //Func<int, bool> func = x =>  x % 2 == 0; ; 

            //FindElementsT(Numbers, N => N % 2 == 0);
            //FindElementsT(Numbers, N => N % 2 != 0);

            //Enumerable.Where(Numbers, ConditionsFunctions.CheckOdd);
            //Enumerable.Where(Numbers, delegate (int N) { return N % 2 == 0; });
            //Enumerable.Where(Numbers, N => N%2 == 0);  
            #endregion

            #region var keyword
            //var x = 12;
            //var predicate = ConditionsFunctions.CheckDivisableByFour;
            //Console.WriteLine(predicate.Invoke(x)); //True

            #endregion

            #region Function Returns Function
            //Action action = Func02();
            //action.Invoke(); //Hello World
            //Func02()(); //Hello World

            #endregion
        }
    }
}
