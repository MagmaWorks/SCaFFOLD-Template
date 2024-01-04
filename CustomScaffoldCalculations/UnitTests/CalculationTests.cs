using CustomScaffoldCalculations.Calculations;
using FluentAssertions;

namespace UnitTests;

public class CalculationTests
{
    // The format of the unit test below is:
    // AAA (Arrange, Act, Assert) - a unit testing term describing the structure of the test.
    // I've noted each step below - you can set up unit tests for all of your calculations if you wish, or just edit this method.
    // Note that [Fact] is a required element to run the test.
    [Fact]
    public void Run_Calc()
    {
        // (ARRANGE) Instantiate your calculation (calls its constructor)
        var calc = new RectangleAreaCalc();
        
        // (ACT) Runs the UpdateCalc method
        // Note: if you set break points inside your calc and run this unit test, you'll be able to debug it quickly.
        calc.UpdateCalc();
        
        // (ASSERT)
        calc.Inputs.Count.Should().Be(2);
        
        var outputs = calc.GetOutputs();
        outputs[0].Name.Should().Be("Area");
        outputs[0].ValueAsString.Should().Be("20000");
    }
}