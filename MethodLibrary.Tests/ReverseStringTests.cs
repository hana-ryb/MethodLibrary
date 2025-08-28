using NUnit.Framework;
namespace MethodLibrary.Tests;

[TestFixture]
public class ReverseStringTests
{
    [Test]
    [TestCase("Hana", "anaH", TestName = "Reverse string 'Hana' to 'anaH'")]
    public void ReverseStringFor_NormalStringForLoop(string input, string expected)
    {
        var result = ReverseStringMethods.ReverseStringFor(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}
