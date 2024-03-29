using Dapper;
using RealEstate_Dapper_Api.Dtos.EmplooyeDtos;
using RealEstate_Dapper_Api.Models.DapperContext;
using RealEstate_Dapper_Api.Repostories.EmpoyeeRepository;

namespace RealEstate_Dapper_Api.Repostories.EmpoyeeRepositories
{
    public class EmpoyeeRepository : IEmpoyeeRepository
    {
        private readonly Context _context;

        public EmpoyeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmpolyee(CreateEmplooyeDto createEmplooyeDto)
        {
            string query = "insert into Emplooye (Name, Title, Mail, PhoneNumber, ImageUrl, Status) values" +
                " (@name,@title,@mail,@phoneNumber,@imageUrl,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", createEmplooyeDto.Name);
            parameters.Add("@title", createEmplooyeDto.Title);
            parameters.Add("@mail", createEmplooyeDto.Mail);
            parameters.Add("@phoneNumber", createEmplooyeDto.PhoneNumber);
            parameters.Add("@imageUrl", createEmplooyeDto.ImageUrl);
            parameters.Add("@status", true);
            
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmplooye(int id)
        {
            string query = "Delete From Emplooye Where EmplooyeID=@emplooyeID";
            var parameters = new DynamicParameters();
            parameters.Add("@emplooyeID", id);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmplooyeDto>> GetAllEmplooyeAsync()
        {
            string query = "Select * From Emplooye";
            using (var connetion = _context.CreateConnection())
            {
                var values = await connetion.QueryAsync<ResultEmplooyeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDEmplooyeDto> GetEmplooye(int id)
        {
            string query = "Select * From Emplooye Where EmplooyeID=@EmplooyeID";
            var parameters = new DynamicParameters();
            parameters.Add("@EmplooyeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDEmplooyeDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmplooye(UpdateEmplooyeDto updateEmplooyeDto)
        {
            string query = "insert into Emplooye (Name=@name, Title=@title, Mail=@mail, PhoneNumber=@phoneNumber, ImageUrl=@imageUrl, Status=@status) where EmplooyeID=@emplooyeId";
              
            var parameters = new DynamicParameters();
            parameters.Add("@name", updateEmplooyeDto.Name);
            parameters.Add("@title", updateEmplooyeDto.Title);
            parameters.Add("@mail", updateEmplooyeDto.Mail);
            parameters.Add("@phoneNumber", updateEmplooyeDto.PhoneNumber);
            parameters.Add("@imageUrl", updateEmplooyeDto.ImageUrl);
            parameters.Add("@status", updateEmplooyeDto.Status);
            parameters.Add("@emplooyeId", updateEmplooyeDto.EmplooyeID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
