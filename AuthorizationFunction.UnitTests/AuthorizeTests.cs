using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Moq;

namespace AuthorizationFunction.UnitTests;

public class AuthorizeTests
{
    private readonly ILogger<Authorize> logger = Mock.Of<ILogger<Authorize>>();

    [Fact]
    public void TestFunctionCanBeRun()
    {
        // Arrange
        var function = new Authorize(logger);
        var request = new DefaultHttpContext().Request;

        // Act
        var response = function.Run(request);

        // Assert
        Assert.NotNull(response);
    }
}