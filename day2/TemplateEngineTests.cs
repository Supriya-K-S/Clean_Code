namespace TemplateEngine.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("Sunil")]
    [TestCase("Sahil")]
    public void ShouldParseOneVariable(string name)
    {
        //Arrange
        TemplateEngine templateEngine = new TemplateEngine();
        templateEngine.SetTemplate("Hello {name}");
        templateEngine.AddKeyValuePair("name",name);

        //Act
        string result = templateEngine.Evaluate();

        //Assert
        Assert.That(result, Is.EqualTo("Hello "+ name));
    }

    [TestCase("John", "25")]
    [TestCase("Jack", "30")]
    public void ShouldParseTwoVariables(string name, string age)
    {
        //Arrange
        TemplateEngine templateEngine = new TemplateEngine();
        templateEngine.SetTemplate("Hello {name} {age}");
        templateEngine.AddKeyValuePair("name", name);
        templateEngine.AddKeyValuePair("age", age);

        //Act
        string result = templateEngine.Evaluate();

        //Assert
        Assert.That(result, Is.EqualTo("Hello " + name + " "+ age));
    }
}
