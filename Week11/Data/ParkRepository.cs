using Week11.Interfaces;
using Week11.Models;
using Microsoft.EntityFrameworkCore;

namespace Week11.Data
{
    public class ParkRepository : IParkRepository
    {
        private readonly AppDbContext _context;

        // Dependecy Injection
        public ParkRepository(AppDbContext context)
        {
            _context = context;
        }

        // READ
        public async Task<IEnumerable<Park>> GetAllAsync()
            => await _context.Parks.ToListAsync();

        public async Task<Park> GetByIdAsync(int id)
            => await _context.Parks.FindAsync(id);

        // CREATE
        public async Task<Park> AddAsync(Park park)
        {
            _context.Parks.Add(park);
            await _context.SaveChangesAsync();
            return park;
        }

        // UPDATE
        public async Task<Park> UpdateAsync(Park park)
        {
            _context.Parks.Update(park);
            await _context.SaveChangesAsync();
            return park;
        }

        // DELETE
        public async Task<bool> DeleteAsync(int id)
        {
            var park = await GetByIdAsync(id);
            if (park == null) return false;

            _context.Parks.Remove(park);
            await _context.SaveChangesAsync();
            return true;
        }

        // Business Operations
        public async Task<bool> AddVisitorsAsync(int parkId, int count)
        {
            var park = await GetByIdAsync(parkId);
            if (park == null) return false;

            bool success = park.AddVisitors(count);
            if (success) await _context.SaveChangesAsync();
            return success;
        }

        public async Task RemoveVisitorsAsync(int parkId, int count)
        {
            var park = await GetByIdAsync(parkId);
            if (park != null)
            {
                park.RemoveVisitors(count);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<decimal> CalculateFeeAsync(int parkId, int visitors)
        {
            var park = await GetByIdAsync(parkId);
            return park?.CalculateEntryFee(visitors) ?? 0;
        }
    }
}
