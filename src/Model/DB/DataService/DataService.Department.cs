using Microsoft.EntityFrameworkCore;
using Model.DB.Tables;
using System.Threading.Tasks;

namespace Model.DB.DataService
{
    /// <inheritdoc/>
    public partial class DataService
    {
        /// <inheritdoc/>
        public Task<Department[]> GetDepartmentDatasAsync() =>
            dataContext.Departments.AsNoTracking().ToArrayAsync();
    }
}