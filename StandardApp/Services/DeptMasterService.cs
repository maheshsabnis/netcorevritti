using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StandardApp.Models;
namespace StandardApp.Services
{
    public class DeptMasterService  : IEkatmService<DeptMaster, string>
    {
        private readonly EkatmERPContext ctx;
        public DeptMasterService(EkatmERPContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<DeptMaster> CreateAsync(DeptMaster entity)
        {
            try
            {
                entity.PkdeptMasterid = Guid.NewGuid().ToString();
                var res = await ctx.DeptMaster.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return res.Entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DeptMaster>> GetAsync()
        {
            return await ctx.DeptMaster.ToListAsync();
        }

        public   Task<DeptMaster> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(string id, DeptMaster entity)
        {
            throw new NotImplementedException();
        }
    }
}
