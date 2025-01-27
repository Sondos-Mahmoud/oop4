namespace oop4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Calculator
            Calculator calculator = new Calculator();
            Console.WriteLine("Add two integers: " + calculator.Add(10, 20));         // Output: 30
            Console.WriteLine("Add three integers: " + calculator.Add(10, 20, 30));  // Output: 60
            Console.WriteLine("Add two doubles: " + calculator.Add(10.5, 20.3));     // Output: 30.8
            #endregion
            #region  rectangle                                                                  
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle(10, 20);
            Rectangle rect3 = new Rectangle(15);
            #endregion
            #region ComplexNumber
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(1, 2);

            ComplexNumber sum = c1 + c2;
            ComplexNumber difference = c1 - c2;

            Console.WriteLine($"Complex Number 1: {c1}");
            Console.WriteLine($"Complex Number 2: {c2}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            #endregion

            #region employee
            Employee employee = new Employee();
            employee.Work();
            Manger manager = new Manger();
            manager.Work();
            #endregion

            #region class
            BaseClass baseObj = new BaseClass();
            baseObj.DisplayMessage();

            BaseClass derived1Obj = new DerivedClass1();
            derived1Obj.DisplayMessage(); 

            BaseClass derived2Obj = new DerivedClass2();
            derived2Obj.DisplayMessage();
            #endregion
            #region duration
            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(7800);
            Duration D3 = D1 + D2;
            Console.WriteLine(D3);
            D3 = D1 + 7800;
            Console.WriteLine(D3);
            D3 = 666 + D3;
            Console.WriteLine(D3);
            D3 = ++D1;
            Console.WriteLine(D3);
            D3 = --D2;
            Console.WriteLine(D3);
            D1 = D1 - D2;
            Console.WriteLine(D1);
            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");
            else
                Console.WriteLine("D1 is not greater than D2");
            if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal to D2");

            #endregion
        }
    }
}