using Model.DB.DataContext;
using Model.DB.DataService;
using System;
using System.IO;
using System.Text;
using Xbehave;
using Xunit.Abstractions;

namespace UnitTest.Infrastructures
{
    public abstract class TestBase : IDisposable
    {
        protected TestBase(ITestOutputHelper output)
        {
            Output = output;
        }

        protected ITestOutputHelper Output { get; }

        protected DataContextBase DataContext { get; private set; } = null!;

        protected IDataService DataService { get; private set; } = null!;

        [Background]
        public void Background()
        {
            var dataContext = new SQLiteDataContext();
            dataContext.Database.EnsureCreatedAsync();
            DataContext = dataContext;
            DataService = new DataService(dataContext);

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            DataService.Dispose();
        }

        protected static string GetRandomString() => Guid.NewGuid().ToString("N");

        protected void AddRangeWithIdentityInsert<T>(string _, T[] addDatas) where T : class
        {
            // SQLiteでは常にIdentityInsertが出来るらしい
            DataContext.Set<T>().AddRange(addDatas);
        }

        protected static Stream GetStream(string[] contents, Encoding encoding)
        {
            var stream = new MemoryStream();
            using var writer = new StreamWriter(stream, encoding, leaveOpen: true);
            foreach (var content in contents)
                writer.WriteLine(content);
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }
    }
}