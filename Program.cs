using Microsoft.EntityFrameworkCore;
using UpWork.Data;
using UpWork.Repositories.Abstracts;
using UpWork.Repositories.Concretes;
using UpWork.Services.Abstracts;
using UpWork.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAdvertiserRepository, AdvertiserRepository>();
builder.Services.AddScoped<IApplicantRepository, ApplicantRepository>();
builder.Services.AddScoped<IJobRepository, JobRepository>();
builder.Services.AddScoped<IJobApplicationRepository, JobApplicationRepository>();
builder.Services.AddScoped<IAdvertiserService, AdvertiserService>();
builder.Services.AddScoped<IApplicantService, ApplicantService>();
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<IJobApplicationService, JobApplicationService>();

var conn = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<UpWorkDb>(opt =>
{
    opt.UseSqlServer(conn);
});

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
