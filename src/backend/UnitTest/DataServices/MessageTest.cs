using FluentAssertions;
using Model.DB.Tables;
using System;
using System.Linq;
using System.Threading.Tasks;
using UnitTest.Infrastructures;
using Xbehave;
using Xunit.Abstractions;

namespace UnitTest.DataServices
{
    public class MessageTest : TestBase
    {
        public MessageTest(ITestOutputHelper output) : base(output)
        {
        }

        [Scenario]
        public void GetMessagesDataAsyncTest()
        {
            var testUserDatas = TestDataGenerator.GetUserTestDatas(10);
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);
            var testIssueDatas = TestDataGenerator.GetIssueTestDatas(10, Enumerable.Range(1, 10).ToArray());
            var testMessageDatas = TestDataGenerator.GetMessageTestDatas(10, Enumerable.Range(1, 10).ToArray());

            "DB準備"
                .x(async () =>
                 {
                     await DataContext.Users.AddRangeAsync(testUserDatas);
                     await DataContext.SaveChangesAsync();
                     await DataContext.Projects.AddRangeAsync(testProjectDatas);
                     await DataContext.SaveChangesAsync();
                     await DataContext.Issues.AddRangeAsync(testIssueDatas);
                     await DataContext.SaveChangesAsync();
                     await DataContext.Messages.AddRangeAsync(testMessageDatas);
                     await DataContext.SaveChangesAsync();
                 });

            "正常に取得される"
                .x(async () =>
                {
                    var registerdDatas = await DataService.GetMessagesDataAsync(testIssueDatas[0].ID);
                    testMessageDatas.OrderBy(x => x.ID).Where(x => x.IssueID == testIssueDatas[0].ID).Select(x => new Message
                    {
                        ID = x.ID,
                        IssueID = x.IssueID,
                        UserID = x.UserID,
                        PostMessage = x.PostMessage,
                        CreateDate = x.CreateDate,
                        UpdateDate = x.UpdateDate
                    }).Should().BeEquivalentTo(registerdDatas);
                });
        }

        [Scenario]
        public void AddMessageDataAsyncTest()
        {
            var testUserDatas = TestDataGenerator.GetUserTestDatas(10);
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);
            var testIssueDatas = TestDataGenerator.GetIssueTestDatas(10, Enumerable.Range(1, 10).ToArray());
            var testMessageDatas = TestDataGenerator.GetMessageTestDatas(10, Enumerable.Range(1, 10).ToArray());

            "DB準備"
                .x(async () =>
                {
                    await DataContext.Users.AddRangeAsync(testUserDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Projects.AddRangeAsync(testProjectDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Issues.AddRangeAsync(testIssueDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Messages.AddRangeAsync(testMessageDatas);
                    await DataContext.SaveChangesAsync();
                });

            "課題IDが未登録の値の場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.AddMessageDataAsync(100, testUserDatas[1].ID, "メッセージ");
                    await action.Should().ThrowAsync<Exception>();
                });

            "ユーザーIDが未登録の値の場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.AddMessageDataAsync(testIssueDatas[2].ID, 100, "メッセージ");
                    await action.Should().ThrowAsync<Exception>();
                });

            "正常に登録される"
                .x(async () =>
                {
                    await DataService.AddMessageDataAsync(testIssueDatas[3].ID, testUserDatas[1].ID, "追加");

                    var registerdDatas = (await DataService.GetMessagesDataAsync(testIssueDatas[3].ID)).Where(x => x.UserID == testUserDatas[1].ID).ToArray();
                    registerdDatas.Any(x => x.PostMessage == "追加").Should().BeTrue();
                });
        }

        [Scenario]
        public void UpdateMessageDataAsyncTest()
        {
            var testUserDatas = TestDataGenerator.GetUserTestDatas(10);
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);
            var testIssueDatas = TestDataGenerator.GetIssueTestDatas(10, Enumerable.Range(1, 10).ToArray());
            var testMessageDatas = TestDataGenerator.GetMessageTestDatas(10, Enumerable.Range(1, 10).ToArray());

            "DB準備"
                .x(async () =>
                {
                    await DataContext.Users.AddRangeAsync(testUserDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Projects.AddRangeAsync(testProjectDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Issues.AddRangeAsync(testIssueDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Messages.AddRangeAsync(testMessageDatas);
                    await DataContext.SaveChangesAsync();
                });

            "メッセージIDが未登録の値の場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.UpdateMessageDataAsync(100, testUserDatas[1].ID, "メッセージ");
                    await action.Should().ThrowAsync<Exception>();
                });

            "ユーザーIDが未登録の値の場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.UpdateMessageDataAsync(testIssueDatas[2].ID, 100, "メッセージ");
                    await action.Should().ThrowAsync<Exception>();
                });

            //"正常に更新される"
            //    .x(async () =>
            //    {
            //        var registerdDatas = await DataService.GetMessagesDataAsync(testIssueDatas[1].ID);
            //        await DataService.UpdateMessageDataAsync(registerdDatas[0].ID, registerdDatas[0].UserID, "更新");

            //        var afterRegisterdDatas = (await DataService.GetMessagesDataAsync(testIssueDatas[1].ID)).Where(x => x.UserID == registerdDatas[0].UserID).ToArray();
            //        afterRegisterdDatas.Any(x => x.PostMessage == "更新").Should().BeTrue();
            //    });
        }

        [Scenario]
        public void DeleteMessageDataAsyncTest()
        {
            var testUserDatas = TestDataGenerator.GetUserTestDatas(10);
            var testProjectDatas = TestDataGenerator.GetProjectTestDatas(10);
            var testIssueDatas = TestDataGenerator.GetIssueTestDatas(10, Enumerable.Range(1, 10).ToArray());
            var testMessageDatas = TestDataGenerator.GetMessageTestDatas(10, Enumerable.Range(1, 10).ToArray());

            "DB準備"
                .x(async () =>
                {
                    await DataContext.Users.AddRangeAsync(testUserDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Projects.AddRangeAsync(testProjectDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Issues.AddRangeAsync(testIssueDatas);
                    await DataContext.SaveChangesAsync();
                    await DataContext.Messages.AddRangeAsync(testMessageDatas);
                    await DataContext.SaveChangesAsync();
                });

            "メッセージIDが未登録の値の場合エラー"
                .x(async () =>
                {
                    Func<Task> action = () => DataService.DeleteMessageDataAsync(100);
                    await action.Should().ThrowAsync<Exception>();
                });

            //"正常に削除される"
            //    .x(async () =>
            //    {
            //        var registerdDatas = await DataService.GetMessagesDataAsync(testIssueDatas[0].ID);

            //        await DataService.DeleteMessageDataAsync(registerdDatas[0].ID);

            //        var afterRegisterdDatas = await DataService.GetMessagesDataAsync(testIssueDatas[0].ID);
            //        afterRegisterdDatas.Should().BeEmpty();
            //    });
        }
    }
}