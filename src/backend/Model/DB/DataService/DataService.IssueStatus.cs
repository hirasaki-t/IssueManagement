using Microsoft.EntityFrameworkCore;
using Model.DB.Tables;
using System.Threading.Tasks;

namespace Model.DB.DataService
{
    /// <inheritdoc/>
    public partial class DataService
    {
        /// <inheritdoc/>
        public Task<IssueStatus[]> GetIssueStatusDatasAsync() =>
            dataContext.IssueStatuses.AsNoTracking().ToArrayAsync();
    }
}