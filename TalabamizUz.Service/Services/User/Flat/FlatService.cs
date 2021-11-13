using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Core.Interfaces.User.Flat;
using TalabamizUz.Data.Contexts;
using TalabamizUz.Domain.Models.Flat;

namespace TalabamizUz.Core.Services.User.Flat
{
    public class FlatService : IFlatService
    {
        private readonly TalabamizDbContext _dbContext;
        public FlatService(TalabamizDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FlatModel> CreateFlat(FlatModel model)
        {
            var entry = await _dbContext.Flats.AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return entry.Entity;
        }

        public async Task DeleteFlat(int flatId)
        {
            var flat = await _dbContext.Flats.FirstOrDefaultAsync(p => p.Id == flatId);
            if (flat != null)
            {
                _dbContext.Flats.Remove(flat);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<FlatModel> GetFlat(int flatId)
        {
            var flat = await _dbContext.Flats.FirstOrDefaultAsync(p => p.Id == flatId);
            return flat;
        }

        public async Task<byte[]> GetFlatImage(string directoryPath, int flatId)
        {
            var flat = await _dbContext.Flats.FirstOrDefaultAsync(p => p.Id == flatId);
            if(flat is not null)
            {
                string path = Path.Combine(directoryPath, flat.FlatImage);
                byte[] file = await File.ReadAllBytesAsync(path);
                return file;
            }

            return null;
        }

        public async Task<IEnumerable<FlatModel>> GetFlatModels()
        {
            var flats = await _dbContext.Flats.ToListAsync();
            return flats;
        }

        public async Task SetFlatImage(string directoryPath, int flatId, byte[] flatImage)
        {
            var flat = await _dbContext.Flats.FirstOrDefaultAsync(p => p.Id == flatId);
            if(flat is not null)
            {
                string fileName = Guid.NewGuid().ToString() + ".png";
                string path = Path.Combine(directoryPath, fileName);

                await File.WriteAllBytesAsync(path, flatImage);
                flat.FlatImage = fileName;
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<FlatModel> UpdateFlat(int flatId, FlatModel model)
        {
            var flat = await _dbContext.Flats.FirstOrDefaultAsync(p => p.Id == flatId);
            return flat;
        }
    }
}
