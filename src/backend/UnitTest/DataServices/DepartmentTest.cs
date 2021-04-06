using FluentAssertions;
using Model.DB.Tables;
using System.Linq;
using UnitTest.Infrastructures;
using Xbehave;
using Xunit.Abstractions;

namespace UnitTest.DataServices
{
    public class DepartmentTest : TestBase
    {
        public DepartmentTest(ITestOutputHelper output) : base(output)
        {
        }

        [Scenario]
        public void GetDepartmentDatasAsyncTest()
        {
            "シード値として設定している値が正常に取得できる"
                .x(async () =>
                {
                    var registerdDatas = await DataService.GetDepartmentDatasAsync();
                    registerdDatas.Single(x => x.ID == 1).Should().Be(new Department { ID = 1, Name = "開発" });
                    registerdDatas.Single(x => x.ID == 2).Should().Be(new Department { ID = 2, Name = "営業" });
                });
        }
    }
}