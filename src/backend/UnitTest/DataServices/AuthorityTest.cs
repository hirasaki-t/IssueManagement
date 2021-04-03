using FluentAssertions;
using Model;
using Model.DB.Tables;
using System.Linq;
using UnitTest.Infrastructures;
using Xbehave;
using Xunit.Abstractions;

namespace UnitTest.DataServices
{
    public class AuthorityTest : TestBase
    {
        public AuthorityTest(ITestOutputHelper output) : base(output)
        {
        }

        [Scenario]
        public void GetAuthoritiesDatasAsyncTest()
        {
            "シード値として設定している値が正常に取得できる"
                .x(async () =>
                {
                    var registerdDatas = await DataService.GetAuthoritiesDatasAsync();
                    registerdDatas.Single(x => x.ID == Authorities.Administrator).Should().Be(new Authority { ID = Authorities.Administrator, Name = "管理者" });
                    registerdDatas.Single(x => x.ID == Authorities.General).Should().Be(new Authority { ID = Authorities.General, Name = "一般ユーザー" });
                });
        }
    }
}