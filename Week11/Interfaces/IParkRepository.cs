using Week11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Week11.Interfaces
{
    public interface IParkRepository
    {
        public abstract Task<IEnumerable<Park>> GetAllAsync();
        public abstract Task<Park> GetByIdAsync(int id);
        public abstract Task<Park> AddAsync(Park park);
        public abstract Task<Park> UpdateAsync(Park park);
        public abstract Task<bool> DeleteAsync(int id);
        public abstract Task<bool> AddVisitorsAsync(int parkId, int count);
        public abstract Task RemoveVisitorsAsync(int parkId, int count);
        public abstract Task<decimal> CalculateFeeAsync(int parkId, int visitors);
    }
}
