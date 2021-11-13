using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Domain.Models.Flat;

namespace TalabamizUz.Core.Interfaces.User.Flat
{
    public interface IFlatService
    {
        Task<FlatModel> CreateFlat(FlatModel model);
        Task<IEnumerable<FlatModel>> GetFlatModels();
        Task<FlatModel> GetFlat(int flatId);
        Task<FlatModel> UpdateFlat(int flatId, FlatModel model);
        Task DeleteFlat(int flatId);
        Task SetFlatImage(string directoryPath, int flatId, byte[] flatImage);
        Task<byte[]> GetFlatImage(string directoryPath, int flatId);
    }
}
