using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repostories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        //Context sınıfı veritabanı bağlantılarını yönetmek için gereklidir.
        private readonly Context _context;

        public ServiceRepository(Context context)
        {
            _context = context;
        }


        void IServiceRepository.CreateService(CreateServiceDto createServiceDto)
        {
            throw new NotImplementedException();
        }

        void IServiceRepository.DeleteService(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * From Service";
            using (var connetion = _context.CreateConnection())
            {
                var values = await connetion.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDServiceDto> GetService(int id)
        {
            throw new NotImplementedException();
        }

        void IServiceRepository.UpdateService(UpdateServiceDto updateServiceDto)
        {
            throw new NotImplementedException();
        }
    }
}
