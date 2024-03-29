using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.EmplooyeDtos;
using RealEstate_Dapper_Api.Repostories.CategoryRepository;
using RealEstate_Dapper_Api.Repostories.EmpoyeeRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplooyeesController : ControllerBase
    {
        private readonly IEmpoyeeRepository _empoyeeRepository;

        public EmplooyeesController(IEmpoyeeRepository empoyeeRepository)
        {
            _empoyeeRepository = empoyeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> EmplooyeList()
        {
            var values = await _empoyeeRepository.GetAllEmplooyeAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmplooyee(CreateEmplooyeDto createEmplooyeeDto)
        {
            _empoyeeRepository.CreateEmpolyee(createEmplooyeeDto);
            return Ok("Personel Başarılı Şekilde Eklendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteEmplooyee(int id)
        {
            _empoyeeRepository.DeleteEmplooye(id);
            return Ok("Personel Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmplooyee(UpdateEmplooyeDto updateEmplooyeDto)
        {
            _empoyeeRepository.UpdateEmplooye(updateEmplooyeDto);
            return Ok("Personel Başarılı Şekilde Güncellendi");
        }


        //HttpGet i yukarıda 1 kere kullandımız için burada parametreli olark kullanmak zorundayız.
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmplooyee(int id)
        {
            var value = await _empoyeeRepository.GetEmplooye(id);
            return Ok(value);
        }
    }
}
