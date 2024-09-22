using Template.Domain.Entities;

namespace Template.Application.Services.Authentication
{
    public record AuthenticationResult
    (
        User User,
        string Token
    );
}
