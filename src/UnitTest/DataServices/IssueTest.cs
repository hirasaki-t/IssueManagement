using FluentAssertions;
using Model;
using Model.DB.Tables;
using System;
using System.Linq;
using System.Threading.Tasks;
using UnitTest.Infrastructures;
using Xbehave;
using Xunit.Abstractions;

namespace UnitTest.DataServices
{
    public class IssueTest : TestBase
    {
        public IssueTest(ITestOutputHelper output) : base(output)
        {
        }

        [Scenario]
        public void GetIssueDatasAsyncTest()
        {
            var testUserDatas = TestDataGenerator.GetUserTestDatas(10);
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);
            var testIssueDatas = TestDataGenerator.GetIssueTestDatas(10, Enumerable.Range(1, 10).ToArray());

            "DB準備"
                .x(async () =>
                {
                    await DataContext.Users.AddRangeAsync(testUserDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Projects.AddRangeAsync(testProjectDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Issues.AddRangeAsync(testIssueDatas);
                    await DataContext.SaveChangesAsync();
                });

            "正常に取得される"
                .x(async () =>
                {
                    var registerdDatas = await DataService.GetIssueDatasAsync();
                    testIssueDatas.OrderBy(x => x.ID).Select(x => new Issue
                    {
                        ID = x.ID,
                        ProjectID = x.ProjectID,
                        UserID = x.UserID,
                        IssueStatusID = x.IssueStatusID,
                        Name = x.Name
                    }).Should().BeEquivalentTo(registerdDatas);
                });
        }

        [Scenario]
        public void AddIssueDataAsyncTest()
        {
            var testUserDatas = TestDataGenerator.GetUserTestDatas(10);
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);
            var testIssueDatas = TestDataGenerator.GetIssueTestDatas(10, Enumerable.Range(1, 10).ToArray());

            "DB準備"
                .x(async () =>
                {
                    await DataContext.Users.AddRangeAsync(testUserDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Projects.AddRangeAsync(testProjectDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Issues.AddRangeAsync(testIssueDatas);
                    await DataContext.SaveChangesAsync();
                });

            "案件IDが未登録の値の場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.AddIssueDataAsync(100, 4, IssueStatuses.Unsolved, "test");
                    await action.Should().ThrowAsync<Exception>();
                });

            "ユーザーIDが未登録の値の場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.AddIssueDataAsync(1, 50, IssueStatuses.Unsolved, "test");
                    await action.Should().ThrowAsync<Exception>();
                });

            "課題ステータスIDが未登録の値の場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.AddIssueDataAsync(1, 2, (IssueStatuses)50, "test");
                    await action.Should().ThrowAsync<Exception>();
                });

            "正常に登録される"
                .x(async () =>
                {
                    await DataService.AddIssueDataAsync(1, 5, IssueStatuses.Unsolved, "test");

                    var registerdDatas = await DataService.GetIssueDatasAsync();
                    registerdDatas[10].IssueStatusID.Should().Be(IssueStatuses.Unsolved);
                    registerdDatas[10].Name.Should().Be("test");
                });
        }

        [Scenario]
        public void UpdateIssueDataAsyncTest()
        {
            var testUserDatas = TestDataGenerator.GetUserTestDatas(10);
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);
            var testIssueDatas = TestDataGenerator.GetIssueTestDatas(10, Enumerable.Range(1, 10).ToArray());

            "DB準備"
                .x(async () =>
                {
                    await DataContext.Users.AddRangeAsync(testUserDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Projects.AddRangeAsync(testProjectDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Issues.AddRangeAsync(testIssueDatas);
                    await DataContext.SaveChangesAsync();
                });

            "未登録のIDを指定された場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.UpdateIssueDataAsync(11, IssueStatuses.Hold, "test");
                    await action.Should().ThrowAsync<Exception>();
                });

            "課題ステータスIDが未登録の値の場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.UpdateIssueDataAsync(5, (IssueStatuses)50, "test");
                    await action.Should().ThrowAsync<Exception>();
                });

            "正常に更新される"
                .x(async () =>
                {
                    await DataService.UpdateIssueDataAsync(9, IssueStatuses.Solved, "終わり");

                    var registerdDatas = await DataService.GetIssueDatasAsync();
                    registerdDatas.Single(x => x.ID == 9).IssueStatusID.Should().Be(IssueStatuses.Solved);
                    registerdDatas.Single(x => x.ID == 9).Name.Should().Be("終わり");
                });
        }

        [Scenario]
        public void DeleteIssueDataAsyncTest()
        {
            var testUserDatas = TestDataGenerator.GetUserTestDatas(10);
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);
            var testIssueDatas = TestDataGenerator.GetIssueTestDatas(10, Enumerable.Range(1, 10).ToArray());

            "DB準備"
                .x(async () =>
                {
                    await DataContext.Users.AddRangeAsync(testUserDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Projects.AddRangeAsync(testProjectDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Issues.AddRangeAsync(testIssueDatas);
                    await DataContext.SaveChangesAsync();
                });

            "未登録のIDを指定された場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.DeleteIssueDataAsync(11);
                    await action.Should().ThrowAsync<Exception>();
                });

            "正常に削除される"
                .x(async () =>
                {
                    await DataService.DeleteIssueDataAsync(4);

                    var registerdDatas = await DataService.GetIssueDatasAsync();
                    registerdDatas.Where(x => x.ID == 4).Should().BeEmpty();
                });
        }
    }
}