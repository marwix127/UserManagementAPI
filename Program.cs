using UserManagementApi.Middleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:5112") // URL del Blazor
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});


// --- JWT Authentication configuration ---
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,  // puedes activar luego si quieres
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("esta_es_una_clave_super_segura_que_tiene_mas_de_32_chars")) // clave secreta
        };
    });

// --- Autorización (roles, claims, etc.) ---
builder.Services.AddAuthorization();


var app = builder.Build();

// Orden correcto:
app.UseErrorHandlingMiddleware();
//app.UseAuthenticationMiddleware(); -->> Reemplazado por el middleware de autenticación JWT
app.UseLoggingMiddleware();

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
