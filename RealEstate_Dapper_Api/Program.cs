using RealEstate_Dapper_Api.Models.DapperContext;
using RealEstate_Dapper_Api.Repostories.BottomGridRepositories;
using RealEstate_Dapper_Api.Repostories.BottomGridRepository;
using RealEstate_Dapper_Api.Repostories.CategoryRepository;
using RealEstate_Dapper_Api.Repostories.PopularLocationRepositories;
using RealEstate_Dapper_Api.Repostories.ProductRepository;
using RealEstate_Dapper_Api.Repostories.ServiceRepository;
using RealEstate_Dapper_Api.Repostories.TestimonialRespositories;
using RealEstate_Dapper_Api.Repostories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
