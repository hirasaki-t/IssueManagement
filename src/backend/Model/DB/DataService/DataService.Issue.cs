using Microsoft.EntityFrameworkCore;
using Model.DB.Tables;
using System;
using System.Threading.Tasks;

namespace Model.DB.DataService
{
    /// <inheritdoc/>
    public partial class DataService
    {
        /// <inheritdoc/>
        public async Task<Issue[]> GetIssueDatasAsync() =>
            await dataContext.Issues.AsNoTracking().ToArrayAsync();

        /// <inheritdoc/>
        public async Task AddIssueDataAsync(int projectID, IssueStatuses issueStatuses, string name)
        {
            if (!await dataContext.Projects.AnyAsync(x => x.ID == projectID))
                throw new Exception();

            if (!await dataContext.IssueStatuses.AnyAsync(x => x.ID == issueStatuses))
                throw new Exception();

            var addIssueData = new Issue
            {
                ProjectID = projectID,
                IssueStatusID = issueStatuses,
                Name = name
            };
            await dataContext.Issues.AddAsync(addIssueData);
            await SaveChangesAsync();
            DetachEntity(addIssueData);
        }

        /// <inheritdoc/>
        public async Task UpdateIssueDataAsync(int id, IssueStatuses issueStatuses, string name)
        {
            if (!await dataContext.Issues.AnyAsync(x => x.ID == id))
                throw new Exception();

            if (!await dataContext.IssueStatuses.AnyAsync(x => x.ID == issueStatuses))
                throw new Exception();

            var updateIssueData = await dataContext.Issues.SingleAsync(x => x.ID == id);
            updateIssueData.IssueStatusID = issueStatuses;
            updateIssueData.Name = name;
            dataContext.Issues.Update(updateIssueData);
            await SaveChangesAsync();
            DetachEntity(updateIssueData);
        }

        /// <inheritdoc/>
        public async Task DeleteIssueDataAsync(int id)
        {
            if (!await dataContext.Issues.AnyAsync(x => x.ID == id))
                throw new Exception();

            var deleteIssueData = await dataContext.Issues.SingleAsync(x => x.ID == id);
            dataContext.Issues.Remove(deleteIssueData);
            await SaveChangesAsync();
        }
    }
}