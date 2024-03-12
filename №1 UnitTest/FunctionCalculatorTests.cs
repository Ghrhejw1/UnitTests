using Test;
namespace UnitTestProg;
[TestClass]
public class FunctionCalculatorTests
{
    [TestMethod]
    public void TestDivisionByZero()
    {
        
        FunctionCalculator calculator = new FunctionCalculator();

        
        Assert.ThrowsException<ArgumentException>(() => calculator.CalculateFunctionValue(0, 0),
            "Ожидаемое исключение при делении на ноль");
    }

    [TestMethod]
    public void TestOutOfRange()
    {
        
        FunctionCalculator calculator = new FunctionCalculator();

        
        Assert.ThrowsException<ArgumentException>(() => calculator.CalculateFunctionValue(5, 5),
            "Ожидаемое исключение при выходе за пределы диапазона");
    }

    [TestMethod]
    public void TestPositiveCase1()
    {
        
        FunctionCalculator calculator = new FunctionCalculator();

        
        double result = calculator.CalculateFunctionValue(2, 1);

        
        Assert.AreEqual(-0.5, result, 0.001, "Неожиданный результат для положительного случая 1");
    }

    [TestMethod]
    public void TestPositiveCase2()
    {
        
        FunctionCalculator calculator = new FunctionCalculator();

        
        double result = calculator.CalculateFunctionValue(3, 1);

        
        Assert.AreEqual(-0.333, result, 0.001, "Неожиданный результат для положительного случая 2");
    }
}
