using FluentAssertions;
using Model;
using Model.DB.Tables;
using System.Linq;
using UnitTest.Infrastructures;
using Xbehave;
using Xunit.Abstractions;

namespace UnitTest.DataServices
{
    public class IssueStatusTest : TestBase
    {
        public IssueStatusTest(ITestOutputHelper output) : base(output)
        {
        }

        [Scenario]
        public void GetAuthoritiesDatasAsyncTest()
        {
            "シード値として設定している値が正常に取得できる"
                .x(async () =>
                {
                    var registerdDatas = await DataService.GetIssueStatusDatasAsync();
                    registerdDatas.Single(x => x.ID == IssueStatuses.Unsolved).Should().Be(new IssueStatus { ID = IssueStatuses.Unsolved, Status = "未解決" });
                    registerdDatas.Single(x => x.ID == IssueStatuses.Solved).Should().Be(new IssueStatus { ID = IssueStatuses.Solved, Status = "解決" });
                    registerdDatas.Single(x => x.ID == IssueStatuses.Hold).Should().Be(new IssueStatus { ID = IssueStatuses.Hold, Status = "保留" });
                    registerdDatas.Single(x => x.ID == IssueStatuses.Cancel).Should().Be(new IssueStatus { ID = IssueStatuses.Cancel, Status = "取下" });
                });
        }
    }
}