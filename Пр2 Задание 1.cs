using System;

class QuadraticEquationSolver
{
    private double a, b, c;
    private double D;
    private double root1, root2;

    public QuadraticEquationSolver(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private void CalculateDiscriminant()
    {
        D = b * b - 4 * a * c;
    }

    public void CalculateRoots()
    {
        CalculateDiscriminant();
        if (D > 0)
        {
            root1 = (-b + Math.Sqrt(D)) / (2 * a);
            root2 = (-b - Math.Sqrt(D)) / (2 * a);
        }
        else if (D == 0)
        {
            root1 = root2 = -b / (2 * a);
        }
        else
        {
            root1 = root2 = double.NaN; // No real roots
        }
    }

    public double GetRoot1()
    {
        return root1;
    }

    public double GetRoot2()
    {
        return root2;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите коэффициенты уравнения (a, b и c):");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        QuadraticEquationSolver solver = new QuadraticEquationSolver(a, b, c);
        solver.CalculateRoots();

        double root1 = solver.GetRoot1();
        double root2 = solver.GetRoot2();

        if (!double.IsNaN(root1) && !double.IsNaN(root2))
        {
            Console.WriteLine("Корни уравнения: x1 = " + root1 + ", x2 = " + root2);
        }
        else if (!double.IsNaN(root1))
        {
            Console.WriteLine("Уравнение имеет единственный корень: x = " + root1);
        }
        else
        {
            Console.WriteLine("Нет корней.");
        }
    }
}
