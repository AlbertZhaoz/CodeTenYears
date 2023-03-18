using Abp.Albert.WebApi;
using Autofac.Extensions.DependencyInjection;
using Volo.Abp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplication<AlbertModule>(opt =>
{
    // �滻Ĭ������
    opt.Services.ReplaceConfiguration(builder.Configuration);
    // ʹ�� Autofac
    opt.UseAutofac();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
// �м����ʼ��ʹ��
app.InitializeApplication();
app.Run();