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
        public Task<Project[]> GetProjectDatasAsync() =>
            dataContext.Projects.AsNoTracking().ToArrayAsync();

        /// <inheritdoc/>
        public async Task AddProjectDataAsync(int[] departmentsIDs, ProjectStatuses projectStatusID, string name)
        {
            if (!await dataContext.ProjectStatuses.AnyAsync(x => x.ID == projectStatusID))
                throw new Exception();

            var registerdDepartmentDatas = await GetDepartmentDatasAsync();
            foreach (var departmentID in departmentsIDs)
            {
                if (!registerdDepartmentDatas.Any(x => x.ID == departmentID))
                    throw new Exception();
            }

            var addProjectData = new Project
            {
                Department = await dataContext.Departments.Where(x => departmentsIDs.Contains(x.ID)).ToListAsync(),
                ProjectStatusID = projectStatusID,
                Name = name,
                CreateDate = DateTime.Now
            };
            await dataContext.Projects.AddAsync(addProjectData);
            await SaveChangesAsync();
            DetachEntity(addProjectData);
        }

        /// <inheritdoc/>
        public async Task UpdateProjectDataAsync(int id, int[] departmentsIDs, ProjectStatuses projectStatusID, string name)
        {
            if (!await dataContext.Projects.Where(x => x.ID == id).AnyAsync())
                throw new Exception();

            if (!await dataContext.ProjectStatuses.AnyAsync(x => x.ID == projectStatusID))
                throw new Exception();

            var registerdDepartmentDatas = await GetDepartmentDatasAsync();
            foreach (var departmentID in departmentsIDs)
            {
                if (!registerdDepartmentDatas.Any(x => x.ID == departmentID))
                    throw new Exception();
            }

            var updateProjectData = await dataContext.Projects.SingleAsync(x => x.ID == id);
            updateProjectData.Department = await dataContext.Departments.Where(x => departmentsIDs.Contains(x.ID)).ToListAsync();
            updateProjectData.ProjectStatusID = projectStatusID;
            updateProjectData.Name = name;
            dataContext.Projects.Update(updateProjectData);
            await SaveChangesAsync();
            DetachEntity(updateProjectData);
        }

        /// <inheritdoc/>
        public async Task DeleteProjectDataAsync(int id)
        {
            if (!await dataContext.Projects.AnyAsync(x => x.ID == id))
                throw new Exception();

            var deleteProjectData = await dataContext.Projects.SingleAsync(x => x.ID == id);
            dataContext.Projects.Remove(deleteProjectData);
            await SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task UpdateProjectDetailAsync(int id, string detail)
        {
            if (!await dataContext.Projects.AnyAsync(x => x.ID == id))
                throw new Exception();

            var updateProjectData = await dataContext.Projects.SingleAsync(x => x.ID == id);
            updateProjectData.Detail = detail;
            dataContext.Projects.Update(updateProjectData);
            await SaveChangesAsync();
            DetachEntity(updateProjectData);
        }
    }
}