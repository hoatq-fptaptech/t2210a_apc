using T2210A_CSharp.demo2;
using System.Collections.Generic;
using T2210A_CSharp.demo3;
using T2210A_CSharp.demo4;
public class Program
{

    public static void Main(string[] args)
    {
        try
        {
            int x = 10;
            int y = 0;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            if (y < 5)
            {
                throw new Exception("Phải chia cho 5 mới tiết kiệm");
            }
            int z = x / y;
            Console.WriteLine("z = " + z);
        }catch(ArithmeticException e)
        {
            Console.WriteLine("Math"+e.Message);
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {

        }
    }
    public static void Main5(string[] args)
    {
        VoidStringDelegate vsd = new VoidStringDelegate(DemoDelegate.Goodbye);
        //DemoDelegate.Goodbye("Xin chao");
        vsd("Xin chao");
        VoidStringDelegate vsd1 = new VoidStringDelegate(new DemoDelegate().SayHello);
        vsd1("Hello");

        var t2 = new DemoDelegate();
        t2.SayHello("T2210A");
        DemoDelegate.Goodbye("T2210A");

        VoidStringDelegate vsd2 = new VoidStringDelegate(new DemoDelegate().SayHello);
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;

        vsd2("T2210A");

        DisplayMessage("Hello world",DemoDelegate.Goodbye);

        VoidStringDelegate vsd3 = delegate (string s) // anonymous method
        {
            Console.WriteLine(s);
        };
        VoidStringDelegate vsd4 =  s => Console.WriteLine(s); // lambda expression

        vsd3("ABC");
        vsd4("XYZ");
    }

    static void DisplayMessage(string message,VoidStringDelegate callback)
    {
        callback(message);
    }

    public static void Main4(string[] args)
    {
        Teacher t = new Teacher();
        t.Tels.Add("09876543");
        t.Tels.Add("12345678");
        Console.WriteLine(t.Tels[0]);

        t[0] = "0111222333"; // t.Tels[0] = "0111222333"
        Console.WriteLine(t[0]);

        List<string> ls = new List<string>();

        //AbstractTeacher at = new AbstractTeacher();
        //ITeacher t2 = () => { }
    }

    public static void Main3(string[] args) {
        Student s = new Student();
        s.Name = "Nguyen Van An";
        s.Eat("aaa");
        s.Eat();

        List<Student> listStudents = new List<Student>();
        listStudents.Add(s);
    }

    public static void Main2(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        //Console.WriteLine("Hello, World!");
        int x = 10;
        float y = 3.14159f;
        double z = 3.14159;

        Console.WriteLine("Result:" + (x + y + z));

        var k = 19;
        //k = "hello world";
        //k = 22;

        //var pi = 3.14159;

        var input = Console.ReadLine();// 128 -> string "128"
        int inputInt = Convert.ToInt32(input);
        if (k > 10)
        {

        }
        else
        {

        }

        int[] arr = new int[10];

        for (int i = 0; i < arr.Length; i++)
        {
            // arr[i]
        }

        foreach (int ar in arr)
        {
            // ar <=> arr[i]
        }

    }
}