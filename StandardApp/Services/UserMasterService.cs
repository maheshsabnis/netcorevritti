using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StandardApp.Models;
namespace StandardApp.Services
{
    public class UserMasterService : IEkatmService<UserMaster, Guid>
    {
        private readonly EkatmERPContext ctx;

        /// <summary>
        /// Inject the DbContext in the Service
        /// The Instance of EkatmERPContext will be injected from DI Container
        /// from COnfigureServices() method of Startu.cs
        /// </summary>
        public UserMasterService(EkatmERPContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<UserMaster> CreateAsync(UserMaster entity)
        {
            try
            {
                var res = await ctx.UserMaster.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return res.Entity;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserMaster>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserMaster> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Guid id, UserMaster entity)
        {
            throw new NotImplementedException();
        }
    }
}
