namespace RealEstate_Dapper_Api.Dtos.EmplooyeDtos
{
    public class CreateEmplooyeDto
    {
        
        public string Name { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
