using System;

namespace CsharpDay09Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // please try to uncomment all lines after program class to avoid errors while running any problem region
            // problems 16,17,18,19 are of part02
            #region Problem 1 - Weekdays Enum
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //    Console.WriteLine($"{day} = {(int)day}");
            #endregion


            #region Problem 2 - Grades Enum short
            //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            //    Console.WriteLine($"{grade} = {(short)grade}");
            #endregion


            #region Problem 3 - Person Department
            //Person p1 = new Person { Name = "Ali", Department = "IT" };
            //Person p2 = new Person { Name = "Sara", Department = "HR" };
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            #endregion


            #region Problem 4 - Sealed Salary
            //Child child = new Child();
            //child.DisplaySalary();
            #endregion


            #region Problem 5 - Static Perimeter
            //Console.WriteLine("Perimeter: " + Utility.CalculatePerimeter(5, 3));
            #endregion


            #region Problem 6 - Complex Multiplication
            //ComplexNumber c1 = new ComplexNumber(2, 3);
            //ComplexNumber c2 = new ComplexNumber(4, 5);
            //Console.WriteLine(c1 * c2);
            #endregion


            #region Problem 7 - Gender Enum byte
            //Console.WriteLine($"int size: {sizeof(int)} bytes");
            //Console.WriteLine($"byte size: {sizeof(byte)} bytes");
            #endregion


            #region Problem 8 - Temperature Converter
            //Console.WriteLine(Utility.CelsiusToFahrenheit(25));
            //Console.WriteLine(Utility.FahrenheitToCelsius(77));
            #endregion


            #region Problem 9 - Enum TryParse
            //if (Enum.TryParse("A", out Grades g))
            //    Console.WriteLine("Parsed: " + g);
            #endregion


            #region Problem 10 - Employee Equals Search
            //Employee[] employees =
            //{
            //    new Employee{Id=1, Name="Omar"},
            //    new Employee{Id=2, Name="Lina"}
            //};
            //Console.WriteLine(Helper2<Employee>.SearchArray(employees,
            //    new Employee { Id = 2, Name = "Lina" }));
            #endregion


            #region Problem 11 - Generic Max Method
            //Console.WriteLine(Helper.Max(10, 20));
            //Console.WriteLine(Helper.Max(5.5, 3.3));
            //Console.WriteLine(Helper.Max("Ali", "Ziad"));
            #endregion


            #region Problem 12 - ReplaceArray
            //int[] arr = { 1, 2, 2, 3 };
            //Helper2<int>.ReplaceArray(arr, 2, 9);
            //Console.WriteLine(string.Join(",", arr));
            #endregion


            #region Problem 13 - Non Generic Swap Rectangle
            //Rectangle r1 = new Rectangle { Length = 10, Width = 5 };
            //Rectangle r2 = new Rectangle { Length = 7, Width = 3 };
            //SwapRectangles(ref r1, ref r2);
            //Console.WriteLine($"R1: {r1.Length},{r1.Width}");
            #endregion


            #region Problem 14 - Department Search
            //Department d1 = new Department { Id = 1, Name = "IT" };
            //Employee[] emp =
            //{
            //    new Employee{Id=1, Name="Ali", Dept=d1}
            //};
            //Console.WriteLine(Helper2<Employee>.SearchArray(emp,
            //    new Employee { Id = 1, Name = "Ali" }));
            #endregion


            #region Problem 15 - Struct vs Class Circle
            //CircleStruct cs1 = new CircleStruct(5, "Red");
            //CircleStruct cs2 = new CircleStruct(5, "Red");
            //Console.WriteLine(cs1.Equals(cs2));

            //CircleClass cc1 = new CircleClass(5, "Red");
            //CircleClass cc2 = new CircleClass(5, "Red");
            //Console.WriteLine(cc1.Equals(cc2));
            #endregion


            #region Problem 16 - Generic Reverse Array (Image 1)
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //var reversed = GenericHelper.ReverseArray(numbers);
            //Console.WriteLine(string.Join(",", reversed));
            #endregion


            #region Problem 17 - Generic Stack (Image 2)
            //GenericStack<int> stack = new GenericStack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            #endregion


            #region Problem 18 - Generic Swap (Image 3)
            //int[] swapArr = { 10, 20, 30 };
            //GenericHelper.Swap(swapArr, 0, 2);
            //Console.WriteLine(string.Join(",", swapArr));
            #endregion


            #region Problem 19 - Generic Max in Array (Image 4)
            //int[] maxArr = { 5, 9, 3, 12, 1 };
            //Console.WriteLine(GenericHelper.FindMax(maxArr));
            #endregion

        }

        //static void SwapRectangles(ref Rectangle r1, ref Rectangle r2)
        //{
        //    Rectangle temp = r1;
        //    r1 = r2;
        //    r2 = temp;
        //}
    }


    //#region Enums
    ////enum Weekdays { Monday = 1, Tuesday, Wednesday, Thursday, Friday }
    ////enum Grades : short { F = 1, D, C, B, A }
    ////enum Gender : byte { Male = 1, Female = 2 }
    //#endregion


    //#region Classes
    //class Person
    //{
    //    public string Name { get; set; }
    //    public string Department { get; set; }
    //    public override string ToString() => $"{Name} - {Department}";
    //}

    //class Parent
    //{
    //    public virtual decimal Salary => 1000;
    //}

    //class Child : Parent
    //{
    //    public sealed override decimal Salary => 2000;
    //    public void DisplaySalary() => Console.WriteLine(Salary);
    //}

    //static class Utility
    //{
    //    public static double CalculatePerimeter(double l, double w)
    //        => 2 * (l + w);

    //    public static double CelsiusToFahrenheit(double c)
    //        => (c * 9 / 5) + 32;

    //    public static double FahrenheitToCelsius(double f)
    //        => (f - 32) * 5 / 9;
    //}

    //class ComplexNumber
    //{
    //    public double Real { get; }
    //    public double Imaginary { get; }

    //    public ComplexNumber(double r, double i)
    //    {
    //        Real = r;
    //        Imaginary = i;
    //    }

    //    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    //    {
    //        return new ComplexNumber(
    //            a.Real * b.Real - a.Imaginary * b.Imaginary,
    //            a.Real * b.Imaginary + a.Imaginary * b.Real);
    //    }

    //    public override string ToString() => $"{Real} + {Imaginary}i";
    //}

    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Department Dept { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is Employee other)
    //            return Id == other.Id && Name == other.Name;
    //        return false;
    //    }

    //    public override int GetHashCode() => Id.GetHashCode();
    //}

    //class Department
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is Department other)
    //            return Id == other.Id;
    //        return false;
    //    }

    //    public override int GetHashCode() => Id.GetHashCode();
    //}
    //#endregion


    //#region Generic Helpers (Image Problems)
    //static class GenericHelper
    //{
    //    public static T[] ReverseArray<T>(T[] array)
    //    {
    //        T[] result = new T[array.Length];
    //        for (int i = 0; i < array.Length; i++)
    //            result[i] = array[array.Length - 1 - i];
    //        return result;
    //    }

    //    public static void Swap<T>(T[] array, int i, int j)
    //    {
    //        T temp = array[i];
    //        array[i] = array[j];
    //        array[j] = temp;
    //    }

    //    public static T FindMax<T>(T[] array) where T : IComparable<T>
    //    {
    //        T max = array[0];
    //        foreach (var item in array)
    //            if (item.CompareTo(max) > 0)
    //                max = item;
    //        return max;
    //    }
    //}

    //class GenericStack<T>
    //{
    //    private T[] items = new T[10];
    //    private int top = -1;

    //    public void Push(T item)
    //    {
    //        items[++top] = item;
    //    }

    //    public T Pop()
    //    {
    //        return items[top--];
    //    }

    //    public T Peek()
    //    {
    //        return items[top];
    //    }
    //}
    //#endregion


    //#region Structs
    //struct Rectangle
    //{
    //    public double Length { get; set; }
    //    public double Width { get; set; }
    //}

    //struct CircleStruct
    //{
    //    public double Radius { get; }
    //    public string Color { get; }

    //    public CircleStruct(double r, string c)
    //    {
    //        Radius = r;
    //        Color = c;
    //    }
    //}

    //class CircleClass
    //{
    //    public double Radius { get; }
    //    public string Color { get; }

    //    public CircleClass(double r, string c)
    //    {
    //        Radius = r;
    //        Color = c;
    //    }
    //}
    //#endregion


    //static class Helper
    //{
    //    public static T Max<T>(T a, T b) where T : IComparable<T>
    //        => a.CompareTo(b) > 0 ? a : b;
    //}

    //class Helper2<T>
    //{
    //    public static int SearchArray(T[] array, T value)
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //            if (array[i].Equals(value))
    //                return i;
    //        return -1;
    //    }

    //    public static void ReplaceArray(T[] array, T oldValue, T newValue)
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //            if (array[i].Equals(oldValue))
    //                array[i] = newValue;
    //    }
    //}
}