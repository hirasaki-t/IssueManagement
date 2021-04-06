using FluentAssertions;
using Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using UnitTest.Infrastructures;
using Xbehave;
using Xunit.Abstractions;

namespace UnitTest.DataServices
{
    public class ProjectTest : TestBase
    {
        public ProjectTest(ITestOutputHelper output) : base(output)
        {
        }

        [Scenario]
        public void GetProjectDatasAsyncTest()
        {
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);

            "DB準備"
            .x(async () =>
            {
                await DataContext.Projects.AddRangeAsync(testProjectDatas);
                await DataContext.SaveChangesAsync();
            });

            "正常に取得される"
            .x(async () =>
            {
                var registerdDatas = await DataService.GetProjectDatasAsync();
                registerdDatas.Should().BeEquivalentTo(testProjectDatas);
            });
        }

        [Scenario]
        public void AddProjectDataAsyncTest()
        {
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);

            "DB準備"
            .x(async () =>
            {
                await DataContext.Projects.AddRangeAsync(testProjectDatas);
                await DataContext.SaveChangesAsync();
            });

            "プロジェクトステータスIDが未登録の値の場合エラー"
            .x(async () =>
            {
                Func<Task> action = () => DataService.AddProjectDataAsync(new[] { 1 }, (ProjectStatuses)100, "test");
                await action.Should().ThrowAsync<Exception>();
            });

            "部門IDに未登録の値が含まれていた場合エラー"
            .x(async () =>
            {
                Func<Task> action = () => DataService.AddProjectDataAsync(new[] { 100 }, ProjectStatuses.NotStarted, "test");
                await action.Should().ThrowAsync<Exception>();
            });

            "正常に登録される"
            .x(async () =>
            {
                await DataService.AddProjectDataAsync(new[] { 2 }, ProjectStatuses.RequestAnalysis, "test");

                var registerdDatas = await DataService.GetProjectDatasAsync();
                registerdDatas[10].ProjectStatusID.Should().Be(ProjectStatuses.RequestAnalysis);
                registerdDatas[10].Name.Should().Be("test");
            });
        }

        [Scenario]
        public void UpdateProjectDataAsyncTest()
        {
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);

            "DB準備"
            .x(async () =>
            {
                await DataContext.Projects.AddRangeAsync(testProjectDatas);
                await DataContext.SaveChangesAsync();
            });

            "未登録のIDを指定された場合エラー"
            .x(async () =>
            {
                Func<Task> action = () => DataService.UpdateProjectDataAsync(11, new[] { 1 }, ProjectStatuses.DetailDesign, "test");
                await action.Should().ThrowAsync<Exception>();
            });

            "プロジェクトステータスIDが未登録の値の場合エラー"
            .x(async () =>
            {
                Func<Task> action = () => DataService.UpdateProjectDataAsync(5, new[] { 2 }, (ProjectStatuses)100, "test");
                await action.Should().ThrowAsync<Exception>();
            });

            "部門IDに未登録の値が含まれていた場合エラー"
            .x(async () =>
            {
                Func<Task> action = () => DataService.UpdateProjectDataAsync(5, new[] { 100 }, ProjectStatuses.DetailDesign, "test");
                await action.Should().ThrowAsync<Exception>();
            });

            "正常に更新される"
            .x(async () =>
            {
                await DataService.UpdateProjectDataAsync(5, new[] { 1 }, ProjectStatuses.UserTest, "テスト！");

                var registerdDatas = await DataService.GetProjectDatasAsync();
                registerdDatas.Single(x => x.ID == 5).ProjectStatusID.Should().Be(ProjectStatuses.UserTest);
                registerdDatas.Single(x => x.ID == 5).Name.Should().Be("テスト！");
            });
        }

        [Scenario]
        public void DeleteProjectDataAsyncTest()
        {
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);

            "DB準備"
            .x(async () =>
            {
                await DataContext.Projects.AddRangeAsync(testProjectDatas);
                await DataContext.SaveChangesAsync();
            });

            "未登録のIDを指定された場合エラー"
            .x(async () =>
            {
                Func<Task> action = () => DataService.DeleteProjectDataAsync(11);
                await action.Should().ThrowAsync<Exception>();
            });

            "正常に削除される"
            .x(async () =>
            {
                await DataService.DeleteProjectDataAsync(3);

                var registerdDatas = await DataService.GetProjectDatasAsync();
                registerdDatas.Where(x => x.ID == 3).Should().BeEmpty();
            });
        }

        [Scenario]
        public void UpdateProjectDetailAsyncTest()
        {
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);

            "DB準備"
            .x(async () =>
            {
                await DataContext.Projects.AddRangeAsync(testProjectDatas);
                await DataContext.SaveChangesAsync();
            });

            "未登録のIDを指定された場合エラー"
            .x(async () =>
            {
                Func<Task> action = () => DataService.UpdateProjectDetailAsync(11, "新しいコメント");
                await action.Should().ThrowAsync<Exception>();
            });

            "正常に更新される"
            .x(async () =>
            {
                await DataService.UpdateProjectDetailAsync(3, "新しいコメントです");

                var registerdDatas = await DataService.GetProjectDatasAsync();
                registerdDatas.Single(x => x.ID == 3).Detail.Should().Be("新しいコメントです");
            });
        }
    }
}