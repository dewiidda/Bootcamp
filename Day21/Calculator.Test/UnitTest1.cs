namespace Calculator.Test;
using CalculatorLib;
public class Tests
{
    private PersonService _person;
    [SetUp]
    public void Setup()
    {
        _person = new PersonService();
    }

    // [Test]
    // public void Add_ReturnCorrectValue()
    // {
    //     //Arrange
    //     int a = 2;
    //     int b = 4;
    //     int expected = 6;

    //     //Action
    //     int result = calculator.Add(a,b);

    //     //Assert
    //     Assert.AreEqual(expected, result);
    // }

    // [TestCase(1,3,4)]
    // [TestCase(7,8,15)]
    // [TestCase(45,25,70)]
    // public void Add_ReturnCorrectValue_UsingTestCase(int a, int b, int expected)
    // {
    //     int result = calculator.Add(a,b);

    //     Assert.AreEqual(expected, result);
    // }

    [Test]
    public void GetFullName_WhenCalledWithValidPerson_ReturnFullName()
    {
        //Arrange
        var juned = new Person(){FirstName="Junaidi",LastName="Rico"};
        //Act
        var result = _person.GetFullName(juned);
        //Assert
        Assert.AreEqual("JunaidiRico",result);
    }

    [Test]
    public void GetFullName_WhenCalledWithNull_ReturnNull()
    {
        //Act
        var result = _person.GetFullName(null);
        //Assert
        Assert.IsNull(result);
    }
}