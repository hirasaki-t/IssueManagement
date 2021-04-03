using FluentAssertions;
using Model;
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
                    registerdDatas.Single(x => x.ID == Departments.Development).Should().Be(new Department { ID = Departments.Development, Name = "開発" });
                    registerdDatas.Single(x => x.ID == Departments.Sales).Should().Be(new Department { ID = Departments.Sales, Name = "営業" });
                });
        }
    }
}