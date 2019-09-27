using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StandardApp.Models;
namespace StandardApp.Services
{
    public class StateMasterService : IEkatmService<StateMaster, string>
    {
        private readonly EkatmERPContext ctx;
        public StateMasterService(EkatmERPContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<StateMaster> CreateAsync(StateMaster entity)
        {
            try
            {
                var res  = await ctx.StateMaster.AddAsync(entity);
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

        public  async Task<IEnumerable<StateMaster>> GetAsync()
        {
            return await ctx.StateMaster.ToListAsync();
        }

        public Task<StateMaster> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(string id, StateMaster entity)
        {
            var state = await ctx.StateMaster.FindAsync(id);
            if (state == null) return false;
            ctx.Entry(state).State = EntityState.Detached;
          
            ctx.StateMaster.Update(entity).State = EntityState.Modified;
            await ctx.SaveChangesAsync();
            return true;
        }
    }
}
