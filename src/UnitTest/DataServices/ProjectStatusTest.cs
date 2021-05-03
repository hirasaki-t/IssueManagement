using FluentAssertions;
using Model;
using Model.DB.Tables;
using System.Linq;
using UnitTest.Infrastructures;
using Xbehave;
using Xunit.Abstractions;

namespace UnitTest.DataServices
{
    public class ProjectStatusTest : TestBase
    {
        public ProjectStatusTest(ITestOutputHelper output) : base(output)
        {
        }

        [Scenario]
        public void GetAuthoritiesDatasAsyncTest()
        {
            "シード値として設定している値が正常に取得できる"
                .x(async () =>
                {
                    var registerdDatas = await DataService.GetProjectStatusDatasAsync();
                    registerdDatas.Single(x => x.ID == ProjectStatuses.NotStarted).Should().Be(new ProjectStatus { ID = ProjectStatuses.NotStarted, Status = "未着手" });
                    registerdDatas.Single(x => x.ID == ProjectStatuses.RequestAnalysis).Should().Be(new ProjectStatus { ID = ProjectStatuses.RequestAnalysis, Status = "要求分析" });
                    registerdDatas.Single(x => x.ID == ProjectStatuses.RequestDefinition).Should().Be(new ProjectStatus { ID = ProjectStatuses.RequestDefinition, Status = "要件定義" });
                    registerdDatas.Single(x => x.ID == ProjectStatuses.BasicDesign).Should().Be(new ProjectStatus { ID = ProjectStatuses.BasicDesign, Status = "基本設計" });
                    registerdDatas.Single(x => x.ID == ProjectStatuses.DetailDesign).Should().Be(new ProjectStatus { ID = ProjectStatuses.DetailDesign, Status = "詳細設計" });
                    registerdDatas.Single(x => x.ID == ProjectStatuses.Development).Should().Be(new ProjectStatus { ID = ProjectStatuses.Development, Status = "開発" });
                    registerdDatas.Single(x => x.ID == ProjectStatuses.InnerTest).Should().Be(new ProjectStatus { ID = ProjectStatuses.InnerTest, Status = "内部テスト" });
                    registerdDatas.Single(x => x.ID == ProjectStatuses.UserTest).Should().Be(new ProjectStatus { ID = ProjectStatuses.UserTest, Status = "ユーザーテスト" });
                    registerdDatas.Single(x => x.ID == ProjectStatuses.ReleasePreparation).Should().Be(new ProjectStatus { ID = ProjectStatuses.ReleasePreparation, Status = "リリース準備" });
                    registerdDatas.Single(x => x.ID == ProjectStatuses.Release).Should().Be(new ProjectStatus { ID = ProjectStatuses.Release, Status = "リリース" });
                });
        }
    }
}