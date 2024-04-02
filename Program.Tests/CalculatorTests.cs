using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Additional_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Additional(300, 300) == 600);
    }
    [Test]
    public void Subtraction_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Subtraction(300, 10) == 290);
    }
    [Test]
    public void Miltiplication_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Miltiplication(300, 10) == 3000);
    }
    [Test]
    public void Division_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Division(300, 10) == 30);
    }
}