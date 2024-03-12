namespace Test;

public class FunctionCalculator
{
    public double CalculateFunctionValue(double x, double N)
    {
        try
        {
            if (Math.Abs(x - N) < double.Epsilon)
            {
                throw new ArgumentException("Делить на ноль нельзя!");

            }

            return 1 / (x - N);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Непредвиденное исключение: {ex.Message}");
            throw;
        }
        finally
        {
            Console.WriteLine("Блок finally выполнен!");
        }
    }
}
