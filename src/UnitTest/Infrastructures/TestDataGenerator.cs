using AutoFixture;
using Model.DB.Tables;
using Model.Tables;
using System.Linq;

namespace UnitTest.Infrastructures
{
    /// <summary>テストデータ自動生成クラス</summary>
    public static class TestDataGenerator
    {
        public static Project[] GetProjectTestDatas(int count)
        {
            var fixture = new Fixture();
            return fixture
                .Build<Project>()
                .Without(x => x.ID)
                .Without(x => x.Department)
                .Without(x => x.ProjectStatus)
                .Without(x => x.Issue)
                .CreateMany(count).ToArray();
        }

        public static Issue[] GetIssueTestDatas(int count, int[] projectIDs)
        {
            var fixture = new Fixture();
            return fixture
                .Build<Issue>()
                .Without(x => x.ID)
                .Without(x => x.Messages)
                .Without(x => x.IssueStatus)
                .Without(x => x.Project)
                .Without(x => x.User)
                .With(x => x.ProjectID, () => projectIDs[fixture.CreateRandomIntWithRange(1, projectIDs.Length - 1)])
                .With(x => x.UserID, () => projectIDs[fixture.CreateRandomIntWithRange(1, projectIDs.Length - 1)])
                .CreateMany(count).ToArray();
        }

        public static Message[] GetMessageTestDatas(int count, int[] issueIDs)
        {
            var fixture = new Fixture();
            return fixture
                .Build<Message>()
                .Without(x => x.ID)
                .Without(x => x.User)
                .Without(x => x.Issue)
                .With(x => x.IssueID, () => issueIDs[fixture.CreateRandomIntWithRange(1, issueIDs.Length - 1)])
                .With(x => x.UserID, () => issueIDs[fixture.CreateRandomIntWithRange(1, issueIDs.Length - 1)])
                .CreateMany(count).ToArray();
        }

        public static User[] GetUserTestDatas(int count)
        {
            var fixture = new Fixture();
            return fixture
                .Build<User>()
                .Without(x => x.ID)
                .Without(x => x.Department)
                .Without(x => x.Authority)
                .Without(x => x.Issues)
                .Without(x => x.Messages)
                .With(x => x.DepartmentID, () => fixture.CreateRandomIntWithRange(1, 2))
                .With(x => x.SignIn, () => fixture.Build<SignIn>().Without(x => x.User).Without(x => x.ID).Create())
                .CreateMany(count).ToArray();
        }

        private static int CreateRandomIntWithRange(this Fixture fixture, int min, int max) =>
            fixture.Create<int>() % (max - min + 1) + min;
    }
}