using RealEstate_Dapper_Api.Dtos.EmplooyeDtos;

namespace RealEstate_Dapper_Api.Repostories.EmpoyeeRepository
{
    public interface IEmpoyeeRepository
    {
        Task<List<ResultEmplooyeDto>> GetAllEmplooyeAsync(); 

        void CreateEmpolyee(CreateEmplooyeDto createEmplooyeDto);  

        void DeleteEmplooye(int id);

        void UpdateEmplooye(UpdateEmplooyeDto updateEmplooyeDto);

        Task<GetByIDEmplooyeDto> GetEmplooye(int id);
    }
}
