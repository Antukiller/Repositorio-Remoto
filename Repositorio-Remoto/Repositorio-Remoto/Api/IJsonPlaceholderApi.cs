using Refit;
using Repositorio_Remoto.Models;

namespace Repositorio_Remoto.Api;
[Headers("Content-Type: application/json")]
public interface IJsonPlaceholderApi {
    [Get("users")]
    Task<List<Usuario>> GetUsuarioAsync();

    [Get("/users/{id}")]
    Task<Usuario?> GetUsuarioByIdAsync(int id);

    [Post("/users")]
    Task<Usuario> CreateUsuarioAsync([Body] CreateUserResquest resquest);

    [Put("/user/{id}")]
    Task<Usuario> UpdatedUsuarioAsync(int id, [Body] UpdatedUserResquest resquest);

    [Delete("/users/{id}")]
    Task DeleteUsuarioAsync(int id);
}