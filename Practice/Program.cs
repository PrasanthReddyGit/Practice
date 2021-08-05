using System;
using System.Collections;

namespace Practice
{
    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Address { get; set; }

    //    public void Disply()
    //    {
    //        Console.WriteLine(Id);
    //        Console.WriteLine(Name);
    //        Console.WriteLine(Address);

    //    }
    //}

    //class MyClass
    //{
    //   public int x;
    //   public int y;
    //    public MyClass()
    //    {
    //        x = 0;
    //        y = 0;  
    //    }
    //}

    //public class Base
    //{
    //    public Base()
    //    {
    //        Console.WriteLine("Hi Am Base Constructor");
    //    }
    //    ~Base()
    //    {
    //        Console.WriteLine("Base Destructor");
    //    }
    //}
    //public class Derived:Base
    //{
    //    public Derived()
    //    {
    //        Console.WriteLine("Hi Am Derived Constructor");
    //    }
    //    ~Derived()
    //    {
    //        Console.WriteLine("Derived Destructor");
    //    }
    //

    //class prasanth
    //{
    //    public int id;
    //    public string Name;

    //    public prasanth(int eId,string eName)
    //    {
    //        id = eId;
    //        Name = eName;
    //    }
    //}

    //class Calculate
    //{
    //    internal int sqrt(int a)
    //    {
    //        int b = a * a;
    //        return b;
    //    }
    //    internal int cube(int a)
    //    {
    //        int c = a * a * a;
    //        return c;
    //    }
    //}

    // delegate int Number(int n);
    class Program
    {
        //static int num = 5;

        //public static int AddNum(int p)
        //{
        //    num += p;
        //    return num;
        //}
        //public static int MultNum(int q)
        //{
        //    num *= q;
        //    return num;
        //}
        //public static int getNum()
        //{
        //    return num;
        //}

        //static bool isSquare(int n)
        //{
        //    int sr = (int)Math.Sqrt(n);

        //    return (sr * sr == n);
        //}

        //// Prints all numbers less than or equal
        //// to n that are both Prime and Fibonacci.
        //static void printPrimeAndFib(int n)
        //{

        //    // Using Sieve to generate all
        //    // primes less than or equal to n.
        //    bool[] prime = new bool[n + 1];

        //    // memset(prime, true, sizeof(prime));
        //    for (int p = 0; p <= n; p++)
        //        prime[p] = true;

        //    for (int p = 2; p * p <= n; p++)
        //    {

        //        // If prime[p] is not changed,
        //        // then it is a prime
        //        if (prime[p] == true)
        //        {

        //            // Update all multiples of p
        //            for (int i = p * 2; i <= n; i += p)
        //                prime[i] = false;
        //        }
        //    }

        //    // Now traverse through the range and
        //    // print numbers that are both prime
        //    // and Fibonacci.
        //    for (int i = 1; i <= n; i++)
        //    {

        //        double sqrt = Math.Sqrt(5 * i * i + 4);
        //        double sqrt1 = Math.Sqrt(5 * i * i - 4);

        //        int x = (int)sqrt;
        //        int y = (int)sqrt1;

        //        if (prime[i] == true && (Math.Pow(sqrt, 2) ==
        //             Math.Pow(x, 2) || Math.Pow(sqrt1, 2) ==
        //                                    Math.Pow(y, 2)))
        //            Console.Write(i + " ");
        //    }
        //}
        //static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number = Int32.Parse(Console.ReadLine());

            int backupvalue = number;
            int sum = 0, remaider = 0;


            while(number != 0)
            {
                remaider = number % 10;
                sum = sum + remaider;
                number = number / 10;

            }
            Console.WriteLine("{0} sum is {1}",number,sum);

            //Console.WriteLine("Enter a Number");
            //int number = Int32.Parse(Console.ReadLine());


            //for(int i = 1; i <= number; i++)
            //{
            //    int a = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        a = a * j;
            //    }
            //    Console.WriteLine("{0}! is {1}", i, a);
            //}


            //Console.WriteLine("Enter a Number");
            //int number = Int32.Parse(Console.ReadLine());

            //int a = 0, b = 1, c;
            //Console.Write(a + "  " + b);

            //for(int i = 0; i <= number; i++)
            //{
            //    c = a + b;
            //    Console.Write("  " + c);
            //    a = b;
            //    b = c;
            //}




            //Console.WriteLine("Enter a Number");
            //int number = Int32.Parse(Console.ReadLine());

            //int division = number;
            //int sum = 0, remaider = 0;
            //while (number != 0)
            //{
            //    remaider = number % 10;
            //    sum = sum + remaider;
            //    number = number / 10;
            //}
            //Console.WriteLine("sum of {0} is {1}",division,sum);


            //Console.WriteLine("Enter a number");
            //int number = Int32.Parse(Console.ReadLine());

            //int a = 1;
            //for(int i = 1; i <= number; i++)
            //{
            //    a = a * i;
            //}

            //Console.WriteLine("{0}! is {1}",number,a);
            //int a = 0, b = 1, c;
            //Console.WriteLine("Enter a Number");
            //int number = Int32.Parse(Console.ReadLine());

            //Console.Write(a+"  "+b);

            //for(int i = 2; i < number; i++)
            //{
            //    c = a + b;
            //    Console.Write("  "+c);
            //    a = b;
            //    b = c;
            //}

            //Console.WriteLine("Enter a upper bound value");
            //int range = Int32.Parse(Console.ReadLine());

            //for(int i=1;i<=range;i++)
            //{
            //    int fact = 1;
            //    for(int j=1;j<=i;j++)
            //    {
            //        fact = fact * j;
            //    }
            //    Console.WriteLine("{0}! is {1}",i,fact);
            //}
        }
        //private static int Calculate(int number)
        //{
        //    int i = 1;
        //    if(number>0)
        //    {
        //        i = number * Calculate(number - 1);
        //    }
        //    return i;
        //}
        //Console.WriteLine("Enter a Number");
        //int number = Int32.Parse(Console.ReadLine());

        //int result = 1;

        //for (int i = 1; i <= number; i++) 
        //{
        //    result = result * i;
        //}
        //Console.WriteLine("{0}! Factorial is {1}", number, result);

        //Console.WriteLine("Enter a value");
        //int Count = Int32.Parse(Console.ReadLine());
        //Console.Write(p1 + "  " + p2);
        //for (int i=2; i<Count; i++)
        //{
        //    p3 = p1 + p2;
        //    Console.Write("  " + p3);
        //    p1 = p2;
        //    p2 = p3;

        //}
        //Console.WriteLine();

        //    Console.WriteLine("Enter a value");
        //    int Count = Int32.Parse(Console.ReadLine());
        //    Console.Write(p1 + "  " + p2);
        //    Fibonacci(Count - 2);
        //    Console.WriteLine();
        //}

        //private static void Fibonacci(int Count)
        //{
        //    if(Count>0)
        //    {
        //        p3 = p1 + p2;
        //        Console.Write("  " + p3);
        //        p1 = p2;
        //        p2 = p3;
        //        Fibonacci(Count - 1);

        //        Console.WriteLine();
        //    }

        //}






        //string Name = "Prasanth\tReddy\nBayyapu";
        //Console.WriteLine(Name);

        //int n = 100;

        //printPrimeAndFib(n);


        //int result;
        //int x = 10, y = 5;

        //// Addition
        //result = (x + y);
        //Console.WriteLine("Addition Operator: " + result);

        //// Subtraction
        //result = (x - y);
        //Console.WriteLine("Subtraction Operator: " + result);

        //// Multiplication
        //result = (x * y);
        //Console.WriteLine("Multiplication Operator: " + result);

        //// Division
        //result = (x / y);
        //Console.WriteLine("Division Operator: " + result);

        //// Modulo
        //result = (x % y); 
        //Console.WriteLine("Modulo Operator: " + result);

        //bool result;
        //int x = 5, y = 10;

        //// Equal to Operator
        //result = (x == y);
        //Console.WriteLine("Equal to Operator: " + result);

        //// Greater than Operator
        //result = (x > y);
        //Console.WriteLine("Greater than Operator: " + result);

        //// Less than Operator
        //result = (x < y);
        //Console.WriteLine("Less than Operator: " + result);

        //// Greater than Equal to Operator
        //result = (x >= y);
        //Console.WriteLine("Greater than or Equal to: " + result);

        //// Less than Equal to Operator
        //result = (x <= y);
        //Console.WriteLine("Lesser than or Equal to: " + result);

        //// Not Equal To Operator
        //result = (x != y);
        //Console.WriteLine("Not Equal to Operator: " + result);

        //int x = 1, y = 2, result;

        //// Bitwise AND Operator
        //result = x & y;
        //Console.WriteLine("Bitwise AND: " + result);

        //// Bitwise OR Operator
        //result = x | y;
        //Console.WriteLine("Bitwise OR: " + result);

        //// Bitwise XOR Operator
        //result = x ^ y;
        //Console.WriteLine("Bitwise XOR: " + result);

        //// Bitwise AND Operator
        //result = ~x;
        //Console.WriteLine("Bitwise Complement: " + result);

        //// Bitwise LEFT SHIFT Operator
        //result = x << 2;
        //Console.WriteLine("Bitwise Left Shift: " + result);

        //// Bitwise RIGHT SHIFT Operator
        //result = x >> 2;
        //Console.WriteLine("Bitwise Right Shift: " + result);


        //Hashtable hashtable = new Hashtable();
        //hashtable.Add("001", "Bheem");
        //hashtable.Add("002", "Lakshmi");
        //hashtable.Add("003", "Sagar");
        //hashtable.Add("004", "Sai");

        //foreach(var key in hashtable.Keys)
        //{
        //    Console.WriteLine(key);
        //}

        //Console.WriteLine(hashtable["002"].ToString());
        //Console.WriteLine("d"+"\b"+"fbsadhsjds");


        //Queue queue = new Queue();
        //queue.Enqueue("Bheem");
        //queue.Enqueue("Lakshmi");
        //queue.Enqueue("Sagar");
        //queue.Enqueue("Sai");

        //while(queue.Count>0)
        //    Console.WriteLine(queue.Dequeue());


        //Stack stack = new Stack();
        //stack.Push("Prasanth");
        //stack.Push("REddy");
        //stack.Push("king");
        //stack.Push("Bayyapu");

        //while(stack.Count>0)
        //    Console.WriteLine(stack.Pop());

        //int i = 100;
        //double s = 21.23;
        //string n = "Prasanth reddy";
        //ArrayList arrayList = new ArrayList();
        //arrayList.Add(s);
        //arrayList.Add(n);
        //arrayList.Add(i);

        //for(int index=0;index<arrayList.Count;index++)
        //    Console.WriteLine(arrayList[index]);


        //Number o;
        //Number o1 = new Number(AddNum);
        ////o1(25);
        ////Console.WriteLine(getNum());

        //Number o2 = new Number(MultNum);
        ////o2(5);
        ////Console.WriteLine(getNum());

        //o = o1;
        //o += o2;

        //o(5);

        //Console.WriteLine(getNum());


        //Console.WriteLine("Enter Your First Name:");
        //string f = Console.ReadLine();

        //Console.WriteLine("Enter Your Last Name:");
        //string l = Console.ReadLine();

        //Console.WriteLine("\n"+ "Your Full Name is:" + f + " " + l);


        //Console.WriteLine("Enter Number:");
        //int n = Convert.ToInt32(Console.ReadLine());

        //Calculate obj = new Calculate();

        //int i = obj.sqrt(n);
        //Console.WriteLine("square root is" + i);

        //int j = obj.cube(n);
        //Console.WriteLine("cube is"+j);



        //try
        //{
        //    Console.WriteLine("Enter Number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int rem, rev = 0;
        //    while (n != 0)
        //    {
        //        rem = n % 10;
        //        rev = rev * 10 + rem;
        //        n = n / 10;
        //    }
        //    Console.WriteLine(rev);
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}


        //for(int i = 10; i >= -10; i--)
        //{
        //    Console.WriteLine(i);
        //}

        // prasanth obj1 = new prasanth(1,"prasanth");
        //obj1.id = 1;
        //obj1.Name = "prasanth";

        // prasanth obj2 = new prasanth(2,"Sai");
        //obj2.id = 2;
        //obj2.Name = "Sai";

        // Console.WriteLine(obj1);

        //string serectword = "prasanth";
        //string guess = "";
        //int guessCount = 0;
        //int guessLimit = 3;
        //bool outOfGuesses = false;

        //while(guess != serectword && !outOfGuesses)
        //{
        //    if (guessCount < guessLimit)
        //    {
        //        Console.WriteLine("Enter Guess: ");
        //        guess = Console.ReadLine();
        //        guessCount++;
        //    }
        //    else
        //    {
        //        outOfGuesses = true;
        //    }

        //}
        //if (outOfGuesses)
        //{
        //    Console.WriteLine("You Lose!");
        //}
        //else
        //{
        //    Console.WriteLine("You Win!");
        //}

        //Console.ReadLine();

        //Console.WriteLine("       /|");
        //Console.WriteLine("      / |");
        //Console.WriteLine("     /  |");
        //Console.WriteLine("    /   |");
        //Console.WriteLine("   /____|");
        //Console.WriteLine("  /     |");
        //Console.WriteLine(" /      |");
        //Console.WriteLine("/       |");




        // Derived de = new Derived();

        //MyClass myClass = new MyClass();
        //Console.WriteLine(myClass.x);
        //Console.WriteLine(myClass.y);


        //Console.WriteLine("Enter a Number:");
        //int num = Convert.ToInt32(Console.ReadLine());

        //for(int i = 1; i <= num; i++)
        //{
        //    char ch = 'A';
        //    for(int j = 1; j <= i; j++)
        //    {
        //        Console.Write(ch + "" + j + " ");
        //        ch++;
        //    }
        //    Console.WriteLine();
        //}

        //Employee employee = new Employee();
        //employee.Id = 1;
        //employee.Name = "Prasanth Reddy";
        //employee.Address = "Hyderabad";
        //employee.Disply();


        //int[][] jaggedArr = new int[2][];

        //jaggedArr[0] = new int[4];
        //jaggedArr[1] = new int[8];


        //int[][] arr = new int[2][];

        //arr[0] = new int[5] { 1, 2, 3, 4, 5 };
        //arr[1] = new int[4] { 1, 2, 3, 4 };

        //for(int i = 0; i < arr.Length; i++)
        //{
        //    for(int j = 0; j < arr[i].Length; j++)
        //    {
        //        Console.Write("{0}",arr[i][j]);
        //         Console.Write("\t");
        //    }
        //    Console.WriteLine("");
        //}

        //int[] numbers = new int[10];

        //for (int index = 0; index < 10; index++)
        //    numbers[index] = index + 1;
        //for(int index=0;index<10;index++)
        //    Console.WriteLine(numbers[index]);


        //int x = 10;
        //Object obj = x;//Boxing

        //x = (int) obj;//Unboxing
        //Console.WriteLine(x);
        //int i = 1;
        //do
        //{
        //    Console.WriteLine(i++);
        //}
        //while (i <= 10);

        //int i = 1;
        //while (i <= 10)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}


        //for (int i = 1; i <= 10; i++)
        //{
        //    if (i > 5) break;

        //    Console.WriteLine(i);

        //}
        //Console.ReadLine();

        //Console.WriteLine("Enter a Number:");
        //int a = Convert.ToInt32(Console.ReadLine());

        //if((a % 2)==0)
        //{
        //    Console.WriteLine(a+"This is Even Number");
        //}
        //else
        //{
        //    Console.WriteLine("This is Odd Number");
        //}
    }
       
    }

