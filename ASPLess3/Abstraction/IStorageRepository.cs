using System.Collections.Generic;
using ASPLess3.Dto;

namespace ASPLess3.Abstraction
{
    public interface IStorageRepository
    {
        IEnumerable<StorageDto> GetAllStorages();
        int AddStorage(StorageDto storageDto);
        void UpdateStorageCount(int storageId, int count);
        void DeleteStorage(int id);
    }
}
