using Data.DataAccess;
using Data.DataAccess.Contract;
using PCommand.Info;
using PCommand_App;

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
builder.Services.AddAutoMapper(typeof(PCommandApplication));

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