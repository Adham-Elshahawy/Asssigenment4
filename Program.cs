namespace Asssigenment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Console.WriteLine("Enter your Number");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("******");

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q2

            //Console.WriteLine("Enter your number ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12 ; i++)
            //{
            //    Console.WriteLine(i*5);
            //}

            #endregion

            #region Q3

            //Console.WriteLine(" Enter your number ");

            //int number = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= number; i++)
            //{
            //  if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Q4
            //Console.WriteLine("Enter first Number");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter seconde Number ");
            //int number2 = int.Parse(Console.ReadLine());

            //double result = Math.Pow(number1, number2);

            //Console.WriteLine($"{number1} ^ {number2} = {result}" );
            #endregion

            #region Q5
            //Console.WriteLine("Enter Name");
            //string name = Console.ReadLine();

            //char[] charArray = name.ToCharArray(); 
            //Array.Reverse(charArray); 
            //string reversedString = new string(charArray); 

            //Console.WriteLine(reversedString);
            #endregion

            #region Q6

            //bool isPrime = true;

            //Console.WriteLine(" Test Data :");
            //Console.Write("input starting number of range : ");
            //int name1 = int.Parse(Console.ReadLine());
            //Console.Write(" input ending number of range :  ");
            //int name2 = int.Parse(Console.ReadLine());

            //for (int i = name1; i <= name2; i++) 
            //{

            //   for (int j = 2; j >= name2/2 ; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            // if (isPrime && i > 1)  // Numbers <= 1 are not prime
            //  {
            //        Console.WriteLine(i);
            //  }

            //}

            //Console.WriteLine("Test Data:");


            //Console.Write("Input starting number of range: ");
            //int name1 = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int name2 = int.Parse(Console.ReadLine());


            //Console.WriteLine($"Prime numbers between {name1} and {name2}:");
            //for (int i = name1; i <= name2; i++)  
            //{
            //    bool isPrime = true;  


            //    for (int j = 2; j <= i/2 ; j++)  
            //    {
            //        if (i % j == 0)  
            //        {
            //            isPrime = false;
            //            break;  
            //        }
            //    }


            //    if (isPrime && i > 1)  
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Q7
            //Console.WriteLine("Test Data:");

            //Console.Write($"Enter number to Convert: ");
            //int num1 = int.Parse(Console.ReadLine());

            //if (num1 == 0)
            //{
            //    Console.WriteLine("0");
            //}
            //else
            //{
            //    string binaryRepresentation = "";
            //    int originalNum = num1; 

            //    while (num1 > 0)
            //    {
            //        int remainder = num1 % 2;
            //        binaryRepresentation = remainder + binaryRepresentation;
            //        num1 = num1 / 2;
            //    }

            //    Console.WriteLine("Expected output:");
            //    Console.WriteLine($"The binary of {originalNum} is {binaryRepresentation}");
            //}
            #endregion

            #region Q8
            //Console.WriteLine("Enter your number : ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= N; i++)
            //{
            //    for (int j = 0; j <= N; j++)
            //    {
            //        if (i == j) 
            //        {
            //            Console.Write("1 ");
            //        }
            //        else 
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Q9
            //Console.Write("Enter the original string: ");
            //string originalString = Console.ReadLine();


            //Console.Write("Enter the starting position (0-based index): ");
            //int startPosition = int.Parse(Console.ReadLine());

            //Console.Write("Enter the length of the substring: ");
            //int length = int.Parse(Console.ReadLine());


            //string substring = originalString.Substring(startPosition, length);
            //Console.WriteLine($"Extracted Substring: {substring}");
            #endregion

            #region Q10
            //Console.WriteLine("Enter your first string ");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("Enter your seconde string ");
            //string name2 = Console.ReadLine();

            //Console.WriteLine($"{name1}{name2}");
            #endregion

            #region Q11
            /*same as 8 */
            #endregion

            #region Q12

            //Console.Write("Enter array elements separated by spaces: ");
            //string[] input = Console.ReadLine().Split(' ');


            //int sum = 0;
            //foreach (string element in input)
            //{
            //    sum += int.Parse(element);
            //}


            //Console.WriteLine($"The sum of all elements in the array is: {sum}");


            #endregion

            #region Q13

            //Console.Write("Enter  first array (no space): ");
            //int[] array1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //Console.Write("Enter  second array (no space): ");
            //int[] array2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            //int[] mergedArray = new int[array1.Length + array2.Length];
            //array1.CopyTo(mergedArray, 0);
            //array2.CopyTo(mergedArray, array1.Length);
            //Array.Sort(mergedArray);


            //Console.WriteLine("The merged and sorted array is:");
            //Console.WriteLine(string.Join(" ", mergedArray));



            #endregion

            #region Q14
            //int[] array = { 1, 2, 3, 4, 5 };


            //int count = array.Length;


            //Console.WriteLine($"The array contains {count} elements.");
            #endregion

            #region Q15
            //int[] array = { 5, 8, 2, 1, 10, 4 };


            //int min = array.Min();
            //int max = array.Max();


            //Console.WriteLine($"Minimum value: {min}");
            //Console.WriteLine($"Maximum value: {max}");
            #endregion

            #region Q16
            //int[] array = { 12, 35, 1, 10, 34, 1 };


            //if (array.Length < 2)
            //{
            //    Console.WriteLine("Array must have at least two elements.");
            //    return;
            //}


            //Array.Sort(array);
            //int secondLargest = array[array.Length - 2];


            //Console.WriteLine($"The second largest number is: {secondLargest}");

            #endregion

            #region Q17


            #endregion

            #region Q18

            //Console.WriteLine("Enter the number of rows and columns for the array:");
            //Console.Write("Rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Columns: ");
            //int cols = int.Parse(Console.ReadLine());


            //int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];


            //Console.WriteLine("Enter values for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element [{i}, {j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}


            //Console.WriteLine("\nThe second array after copying values from the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(array2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q19
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());


            //int[] array = new int[size];
            //Console.WriteLine("Enter the elements of the array:");

            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}


            //Array.Reverse(array);
            //Console.WriteLine("\nArray in reverse order:");
            //foreach (int element in array)
            //{
            //    Console.Write(element + " ");
            //}
            #endregion

            #region Demo 4 

            #region Loop statment 

            //Console.WriteLine("1");
            //Console.WriteLine("2"); 
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");
            /************************/

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region for - foreach 
            //int[] Numbers = { 1, 2, 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{   

            //    Numbers[i] += 10; /*valid because we can change the indexes inisde our array  */

            //    if (Numbers[i] == 5)
            //    {
            //        break ; /* it will print until 4 and stop */
            //    }

            //    if (Numbers[i] == 5)
            //    {
            //        continue; /* it will print all except 5  */
            //    }

            //    Console.WriteLine(Numbers[i]);
            //    Console.WriteLine(Numbers[i] + 10) ; /*we can change normally in the the way of printing */
            //}

            /******************************************/

            //foreach (int Number in Numbers)
            //{
            //    Numbers += 10;              /*Invalid in for each to do operation inside our array because it take copy of array not changeing the original one */ 
            //    Console.WriteLine(Number);
            //    Console.WriteLine(Number + 10); /*we can change normally in the the way of printing */
            //}
            #endregion

            #region while - do while 
            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Enter Even number ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (Number % 2 == 1 || !Flag );

            //Console.WriteLine($"{Number} is Even number ");

            /*****************************************************************/
            //int Number = 3; 
            //bool Flag = false;
            //while (Number%2 == 1 || !Flag)
            //{
            //    Console.WriteLine("Enter Even Number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}

            //Console.WriteLine($"{Number} is Even Number");

            #endregion

            #region String 
            //string name01 = "Ahmed";
            //string name02 = "Ahmed";
            //Console.WriteLine(name01);
            //Console.WriteLine($"name01 => {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"name02 => {name02.GetHashCode()}");

            ///*****************************************************************/
            //Console.WriteLine("****///////****");

            //name01 = name02;
            //Console.WriteLine(name01);
            //Console.WriteLine($"name01 => {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"name02 => {name02.GetHashCode()}");

            ///*****************************************************************/
            //name01 = "mostafa";
            //Console.WriteLine($"name01 => {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"name02 => {name02.GetHashCode()}");

            ///****************************************************************/
            //string name = "Hello"; 
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());

            //name += " Route "; 
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());

            #endregion

            #region stringbuilder 
            //StringBuilder Name ;
            //Name = new StringBuilder("hello");

            //Console.WriteLine(Name);
            //Console.WriteLine(name.GetHashCode());

            //Name += "Route";  /*not allowed */
            //Name.Append("Route"); /*instead of it */

            //Console.WriteLine(Name);
            //Console.WriteLine(name.GetHashCode());

            #endregion

            #region stringbuilder method 
            //StringBuilder message = new StringBuilder();

            //message.Append("to route");
            //message.AppendLine("mostafa");
            //message.AppendLine("hany");

            //message.Remove("0,7");
            //message.Insert(0, "hellp");
            //Console.WriteLine(message);


            //int age = 20;
            //string name = "ali";
            //message.AppendFormat("Name , {0} , {1} " , name , age);
            //Console.WriteLine(message);

            //message.AppendJoin("/","mohamed","Hany","mahmoud");



            #endregion

            #region Array 1 D 
            //int[] Numbers = new int[3] { 1, 2, 3 };
            //int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers = { 1, 2, 3, 4, 5}; 

            //int[] numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($" Enter Element Number {i +1}");
            //    numbers[i] = int.Parse( Console.ReadLine() );

            //}
            //for (int i = 0;i < numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.Rank);

            #endregion

            #region Array 2 D 

            //int[,] marks = new int[3 , 5];
            //Console.WriteLine(marks.Length);
            //Console.WriteLine(marks.Rank);
            //Console.WriteLine(marks.GetLength(0));
            //Console.WriteLine(marks.GetLength(1));

            //for(int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter subject ({i + 1})");
            //    for (int k = 0; k < marks.GetLength(1); k++)
            //    {
            //        bool  Flag;
            //        Console.WriteLine($"Enter grade ({k + 1})");
            //       Flag = int.TryParse(Console.ReadLine(), out marks[i,k]);

            //        if ( Flag && marks[i,k] >=0 )
            //        {
            //            k++;
            //        }
            //        k = Flag && marks[i,k] >= 0 ? ++k : k;
            //    }
            //}


            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"grades subject ({i + 1})");
            //    for (int k = 0; k < marks.GetLength(1); k++)
            //    {
            //        Console.WriteLine($"grade subject ({k + 1})");
            //        Console.WriteLine(marks[i, k]);
            //    }
            //}
            #endregion

            #region judged array 
            //int[][] number = new int [3][];

            //number[0] = new int[3] {1,2,3};
            //number[1] = new int[2] { 3, 4 };
            //number[2] = new int [1] { 6 };

            //for (int i = 0; i < number.Length; i++)
            //{
            //    for (int j = 0; j < number[i].Length; j++)
            //    {
            //        Console.WriteLine(number[i][j]);
            //    }
            //}


            #endregion

            #endregion
        }
    }
}
