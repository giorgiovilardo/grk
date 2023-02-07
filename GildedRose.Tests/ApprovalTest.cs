using System.Text;

namespace GildedRose.Tests;

[UsesVerify]
public class ApprovalTest
{
    [Fact]
    public Task ThirtyDays()
    {
        var fakeoutput = new StringBuilder();
        Console.SetOut(new StringWriter(fakeoutput));

        Program.Main(Array.Empty<string>());

        var output = fakeoutput.ToString();

        return Verify(output);
    }
}
