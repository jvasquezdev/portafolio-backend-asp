/// <summary>
/// Punto de arranque de la aplicación (Bootstrapping).
/// Configura el contenedor de Inyección de Dependencias (DI), las políticas de seguridad (CORS) 
/// y el pipeline de peticiones HTTP.
/// </summary>

var builder = WebApplication.CreateBuilder(args);

// 1. DI Container: Registramos la arquitectura de controladores
builder.Services.AddControllers();

// 2. Seguridad: Configuración estricta de CORS
// Le decimos al servidor que acepte peticiones provenientes de nuestro frontend en Angular
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularFrontend",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// 3. Pipeline HTTP (Middlewares)
app.UseCors("AllowAngularFrontend"); // Activamos el guardia de CORS creado arriba
app.UseAuthorization();
app.MapControllers(); // Le indica al enrutador interno dónde están los endpoints (ej. /api/profile)

app.Run();