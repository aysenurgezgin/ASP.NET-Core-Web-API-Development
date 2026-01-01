using Microsoft.AspNetCore.Components.Web;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args); //1.Aşama

builder.Services.AddControllers();//Controllerlerı kattıık ama gidip kendimiz de controller oluşturduk.
builder.Services.AddEndpointsApiExplorer(); //uyg.tüm controlerları bizim için gezecek keşif için(methot tiplerine bakacak,hangi urlden istek yapılması halinde çalışacak tespit ve sonrasında bilgileri kayıtlı tutar ve sonra )
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1",new OpenApiInfo
    {
        Title="Sample WebAPI Project",
        Version="v1",
        Description="WebAPI yapısı için oluşturuldu.",
        Contact=new OpenApiContact
        {
            Name="Aylin Sezer",
            Email="info@aylinszr.com"
        }
    });
}

);

var app = builder.Build(); //2.Aşama

app.UseSwagger(); //endpoint vs tespit işlemeleri

app.UseSwaggerUI();//o web sayfasını üret

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers(); 

app.Run(); //3.Aşama

//AddSwaggerGen=Diyerekte o topladığı bilgilerle endpointlerle bu uygulamayı test edebileceğim dökümente edebileceğim bir web sayfası üret,uygulama çalışınca ben o sayfayı görebileyim.
