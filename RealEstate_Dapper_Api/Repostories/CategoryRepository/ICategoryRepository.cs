using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repostories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync(); // kategori listeleme için

        void CreateCategory(CreateCategoryDto categoryDto);  // kategori eklemek için

        void DeleteCategory(int id);

        void UpdateCategory(UpdateCategoryDto categoryDto);

        Task<GetByIDCategoryDto> GetCategory(int id);
    }
}
