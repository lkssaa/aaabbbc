using System;
using System.Security.Cryptography;
class a
{
    public int sumLastNums(int x)
    {
        if (Math.Abs(x).ToString().Length < 2)
        {
            Console.WriteLine("need two digits");
            return -1;
        }
        else return Math.Abs(x) % 10 + Math.Abs(x) % 100 / 10;
    }

    public bool isPositive(int x)
    {
        return x == Math.Abs(x);
    }
    public bool isUpperCase(char x)
    {
        return x != Char.ToLower(x);
    }
    public bool isDivisor(int a, int b)
    {
        return (((float)a / b == a / b) || ((float)b / a == b / a));
    }
    public int lastNumSum(int a, int b)
    {
        return Math.Abs(a) % 10 + Math.Abs(b) % 10;
    }
    public double safeDiv(int x, int y)
    {
        if (y == 0) return 0;
        return (float)x / y;
    }
    public String makeDecision(int x, int y)
    {
        String d = " == ";
        if (x > y) d = " > ";
        if (y > x) d = " < ";
        return $"{x}{d}{y}";
    }
    public bool sum3(int x, int y, int z)
    {
        return ((x + y - z) == 0 || (x + z - y) == 0 || (z + y - x) == 0);
    }
    public String age(int x)
    {
        if (x < 0) return "negative age";
        if (x > 10 && x < 15) return $"{x} лет";
        if (x % 10 == 1) return $"{x} год";
        if (x % 10 > 1 && x % 10 < 5) return $"{x} года";
        return $"{x} лет";
    }
    public void printDays(String x)
    {
        switch (x)
        {
            case "понедельник":
                Console.WriteLine("понедельник\nвторник\nсреда\nчетверг\nпятница\nсуббота\nвоскресенье\n");
                break;
            case "вторник":
                Console.WriteLine("вторник\nсреда\nчетверг\nпятница\nсуббота\nвоскресенье\n");
                break;
            case "среда":
                Console.WriteLine("среда\nчетверг\nпятница\nсуббота\nвоскресенье\n");
                break;
            case "четверг":
                Console.WriteLine("четверг\nпятница\nсуббота\nвоскресенье\n");
                break;
            case "пятница":
                Console.WriteLine("пятница\nсуббота\nвоскресенье\n");
                break;
            case "суббота":
                Console.WriteLine("суббота\nвоскресенье\n");
                break;
            case "воскресенье":
                Console.WriteLine("воскресенье\n");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;

        }
    }
    public String reverseListNums(int x)
    {
        string s = "";
        for (int i = x; i >= 0; i--)
        {
            s = s + Convert.ToString(i) + " ";
        }
        return s;
    }
    public int pow(int x, int y)
    {
        int c = 1;
        for (int i = 0; i < y; i++)
        {
            c *= x;
        }
        return c;
    }
    public bool equalNum(int x)
    {
        bool f = true;
        while (x / 10 > 1)
        {
            if (Math.Abs(x) % 10 != Math.Abs(x) % 100 / 10)
            {
                f = false;
            }
            x /= 10;
        }
        return f;
    }
    public void leftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int i1 = 0; i1 < i; i1++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
    public void guessGame()
    {
        int a, a1, c = 0;
        Random rand = new Random();
        a = rand.Next(10);
        a1 = a + 1;
        while (a != a1)
        {
            if (c != 0) Console.WriteLine("вы не угадали");
            Console.WriteLine("введите число от 0 до 9");
            a1 = Convert.ToInt32(Console.ReadLine());
            c++;
        }
        Console.WriteLine($"вы угадали с {c} попытки");
    }
    public int findLast(int[] arr, int x)
    {
        int l = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) l = i;
        }
        return l;
    }
    public int[] add(int[] arr, int x, int pos)
    {
        int[] a = arr;
        a[pos] = x;
        return a;
    }
    public void reverse(int[] arr)
    {
        int n;
        for (int i = 0; i < arr.Length/2; i++)
        {
            n = arr[arr.Length - i - 1];
            arr[arr.Length-i-1] = arr[i];
            arr[i] = n;

        }
    }

    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] a = new int[arr1.Length + arr2.Length];
        for (int i = 0; i< arr1.Length; i++)
        {
            a[i] = arr1[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            a[arr1.Length + i] = arr2[i];
        }
        return a;
    }

    static void OutputArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public int[] deleteNegative(int[] arr)
    {
        int n = 0, i1 = 0;
        foreach (int i in arr)
        {
            if (i > 0) { n++; }
        }
        int[] arr1 = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                arr1[i] = arr[i1];
                i1++;
                    }
        }
        return arr1;
    }



    static void Main()
    {
        int n, x, y, z;
        int[] ns1, ns2;
        string h;
        a a1 = new a();
        Random rand = new Random();

        n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.WriteLine("more than two digit integer inclusive: ");

                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("sum of last two numbers: " + a1.sumLastNums(n).ToString());
                break;



            case 2:
                Console.WriteLine("any integer: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("positive: " + a1.isPositive(n).ToString());
                break;



            case 3:
                char s;
                Console.WriteLine("any character: ");
                s = Console.ReadLine()[0];
                Console.WriteLine("upper case: " + a1.isUpperCase(s).ToString());
                break;



            case 4:
                Console.WriteLine("any integer 1: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("any integer 2: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("can be divided: " + a1.isDivisor(x, y).ToString());
                break;



            case 5:
                Console.WriteLine("sum of the last digits: ");
                int[] ns = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    ns[i] = rand.Next(100);
                    Console.Write($"{ns[i]} ");
                    if (i != 4) Console.Write("+ ");
                }
                int t = a1.lastNumSum(ns[0], ns[1]);
                for (int i = 2; i < 5; i++)
                {
                    t = a1.lastNumSum(ns[i], t);
                }
                Console.WriteLine($"= {t}");

                break;



            case 6:
                Console.WriteLine("any integer 1: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("any integer 2: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("divide result: " + a1.safeDiv(x, y).ToString());
                break;



            case 7:
                Console.WriteLine("any integer 1: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("any integer 2: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("decision result: " + a1.makeDecision(x, y));
                break;



            case 8:
                Console.WriteLine("any integer 1: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("any integer 2: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("any integer 3: ");
                z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("is sum: " + a1.sum3(x, y, z).ToString());
                break;



            case 9:
                Console.WriteLine("any integer: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("age: " + a1.age(n));
                break;



            case 10:
                Console.WriteLine("any russian day of the week with a small letter: ");
                h = Console.ReadLine();
                a1.printDays(h);
                break;



            case 11:
                Console.WriteLine("any integer: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("previous numbers:" + a1.reverseListNums(n));
                break;



            case 12:
                Console.WriteLine("any integer 1(base): ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("any integer 2(power): ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("result: " + a1.pow(x, y).ToString());
                break;



            case 13:
                Console.WriteLine("any integer: ");
                n = Convert.ToInt32(Console.ReadLine());
                a1.leftTriangle(n);
                break;



            case 14:
                Console.WriteLine("any integer: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("equal numbers: " + a1.equalNum(n).ToString());
                break;



            case 15:
                a1.guessGame();
                break;



            case 16:
                Console.WriteLine("array length: ");
                n = Convert.ToInt32(Console.ReadLine());
                ns1 = new int[n];
                rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    ns1[i] = rand.Next(100);
                    Console.Write($"{ns1[i]} ");
                    if (i != n - 1) Console.Write(", ");
                }
                Console.WriteLine("\nnumber to find: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("last index of this number: " + a1.findLast(ns1, n).ToString());
                break;



            case 17:
                Console.WriteLine("array length: ");
                n = Convert.ToInt32(Console.ReadLine());
                ns1 = new int[n];
                rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    ns1[i] = rand.Next(100);
                    Console.Write($"{ns1[i]} ");
                    if (i != n - 1) Console.Write(", ");
                }
                Console.WriteLine("number to replace: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("position to replace: ");
                y = Convert.ToInt32(Console.ReadLine());

                OutputArray(a1.add(ns1, x, y - 1));
                break;



            case 18:
                Console.WriteLine("array length: ");
                n = Convert.ToInt32(Console.ReadLine());
                ns1 = new int[n];
                rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    ns1[i] = rand.Next(100);
                    Console.Write($"{ns1[i]} ");
                    if (i != n - 1) Console.Write(", ");
                }
                Console.Write("\n");
                a1.reverse(ns1);
                OutputArray(ns1);
                break;



            case 19:
                Console.WriteLine("array 1 length: ");
                n = Convert.ToInt32(Console.ReadLine());
                ns1 = new int[n];
                rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    ns1[i] = rand.Next(100);
                    Console.Write($"{ns1[i]} ");
                    if (i != n - 1) Console.Write(", ");
                }
                Console.Write("\n");
                Console.WriteLine("array 2 length: ");
                n = Convert.ToInt32(Console.ReadLine());
                ns2 = new int[n];
                rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    ns2[i] = rand.Next(100);
                    Console.Write($"{ns2[i]} ");
                    if (i != n - 1) Console.Write(", ");
                }
                Console.Write("\n");

                OutputArray(a1.concat(ns1, ns2));
                break;



            case 20:
                Console.WriteLine("array length: ");
                n = Convert.ToInt32(Console.ReadLine());
                ns1 = new int[n];
                rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    ns1[i] = rand.Next(100);
                    Console.Write($"{ns1[i]} ");
                    if (i != n - 1) Console.Write(", ");
                }
                Console.Write("\n");
                OutputArray(a1.deleteNegative(ns1));
                break;

        }
    }
}
