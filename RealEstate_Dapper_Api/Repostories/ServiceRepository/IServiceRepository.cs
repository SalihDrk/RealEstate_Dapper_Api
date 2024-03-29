using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repostories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync(); // kategori listeleme için

        void CreateService(CreateServiceDto createServiceDto);  // kategori eklemek için

        void DeleteService(int id);

        void UpdateService(UpdateServiceDto updateServiceDto);

        Task<GetByIDServiceDto> GetService(int id);
    }
}
