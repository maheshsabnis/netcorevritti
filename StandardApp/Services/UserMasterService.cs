using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
                entity.UserMasterId = Guid.NewGuid().ToString();
                var res = await ctx.UserMaster.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return res.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            bool res = false;
            try
            {
                // 1. Serach record based in GUID
                var user = await ctx.UserMaster.FindAsync(id);
                if (user != null)
                {
                    ctx.UserMaster.Remove(user);
                    await ctx.SaveChangesAsync();
                    res =  true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

        public async Task<IEnumerable<UserMaster>> GetAsync()
        {
            var users = await ctx.UserMaster.ToListAsync();
            return users;
        }

        public async Task<UserMaster> GetAsync(Guid id)
        {
            try
            {
                var user = await ctx.UserMaster.FindAsync(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new Exception($"User with id {id} not found or removed");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }    
        }

        public async Task<bool> UpdateAsync(Guid id, UserMaster entity)
        {
            bool res = false;
            try
            {
                var user = await ctx.UserMaster.FindAsync(id);
                if (user != null)
                {
                    // logc for updating the Entity
                     res = true;
                }
                else
                {
                    throw new Exception($"User with id {id} not found or removed");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }
    }
}
