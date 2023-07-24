using ECommerceProject.DAL.Data;
using ECommerceProject.DAL.Interfaces;
using ECommerceProject.DAL.Repositorys;
using ECommerceProject.Service.Helper;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using ECommerceProject.Service.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//--------------------------------------------------------------------------------------------------------------------------------------------------
//Dependeny Injection:   conn string = ECommerceAppString on appsettings.json
builder.Services.AddDbContext<ECommerceDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceAppString")));

//  Entity Per Service + Feture Related Service build, Add dependency injection per entity and features


builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<ICartItemRepository, CartItemRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IWishlistRepository, WishlistRepository>();
builder.Services.AddScoped<IWishlistItemRepository, WishlistItemRepository>();

builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CategoryService>();


//-------------------------------------------------------------------------------------------------------------------------------------------------


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
