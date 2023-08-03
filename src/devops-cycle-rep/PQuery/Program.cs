using Data.DataAccess.Contract;
using Data.DataAccess;
using PQuery.Info;

var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(new MediatRServiceConfiguration
{
    Lifetime = ServiceLifetime.Transient
});
builder.Services.AddElasticSearch(builder.Configuration);
builder.Services.AddTransient<IElasticsearchDataAccess, ElasticsearchDataAccess>();

#endregion


var app = builder.Build();


#region Middleware

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

#endregion

app.Run();