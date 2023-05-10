using DSA_CCI.Strings;
using Xunit;

namespace UnitTests.StringsTests;

public class UniqueCharactersTests
{
    [Fact]
    public void ShouldRetrunTrueWhenUnique()
    {
        var input = "abc";
        var result = UniqueCharacters.isUniqueChars(input);

        Assert.True(result);
    }

}
