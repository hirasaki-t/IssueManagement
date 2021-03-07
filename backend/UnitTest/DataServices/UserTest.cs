using FluentAssertions;
using UnitTest.Infrastructures;
using Xbehave;
using Xunit.Abstractions;

namespace UnitTest.DataServices
{
    public class Usersest : TestBase
    {
        public Usersest(ITestOutputHelper output) : base(output)
        {
        }

        [Scenario]
        public void GetUsersAsyncTest()
        {
            "DBが空の場合は結果も空になること"
                .x(async () =>
                {
                    (await DataService.GetUserAsync()).Should().BeEmpty();
                });
        }
    }
}