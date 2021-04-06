using AutoFixture;
using Model.DB.Tables;
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
                .With(x => x.ProjectID, () => projectIDs[fixture.CreateRandomIntWithRange(0, projectIDs.Length - 1)])
                .CreateMany(count).ToArray();
        }

        private static int CreateRandomIntWithRange(this Fixture fixture, int min, int max) =>
            fixture.Create<int>() % (max - min + 1) + min;
    }
}