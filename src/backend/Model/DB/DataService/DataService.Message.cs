using Microsoft.EntityFrameworkCore;
using Model.DB.Tables;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Model.DB.DataService
{
    /// <inheritdoc/>
    public partial class DataService
    {
        /// <inheritdoc/>
        public Task<Message[]> GetMessagesDataAsync(int issueID) =>
            dataContext.Messages.Where(x => x.IssueID == issueID).OrderBy(x => x.CreateDate).AsNoTracking().ToArrayAsync();

        /// <inheritdoc/>
        public async Task AddMessageDataAsync(int issueID, int userID, string postMessage)
        {
            if (!await dataContext.Issues.AnyAsync(x => x.ID == issueID))
                throw new Exception();

            if (!await dataContext.Users.AnyAsync(x => x.ID == userID))
                throw new Exception();

            var addMessageData = new Message
            {
                IssueID = issueID,
                UserID = userID,
                CreateDate = DateTime.Now,
                PostMessage = postMessage
            };
            await dataContext.Messages.AddAsync(addMessageData);
            await SaveChangesAsync();
            DetachEntity(addMessageData);
        }

        /// <inheritdoc/>
        public async Task UpdateMessageDataAsync(int id, int userID, string postMessage)
        {
            if (!await dataContext.Messages.AnyAsync(x => x.ID == id))
                throw new Exception();

            if (!await dataContext.Users.AnyAsync(x => x.ID == userID))
                throw new Exception();

            var updateMessageData = await dataContext.Messages.SingleAsync(x => x.ID == id);
            updateMessageData.PostMessage = postMessage;
            updateMessageData.UpdateDate = DateTime.Now;
            dataContext.Messages.Update(updateMessageData);
            await SaveChangesAsync();
            DetachEntity(updateMessageData);
        }

        /// <inheritdoc/>
        public async Task DeleteMessageDataAsync(int id)
        {
            if (!await dataContext.Messages.AnyAsync(x => x.ID == id))
                throw new Exception();

            var deleteMessageData = await dataContext.Messages.SingleAsync(x => x.ID == id);
            dataContext.Messages.Remove(deleteMessageData);
            await SaveChangesAsync();
        }
    }
}