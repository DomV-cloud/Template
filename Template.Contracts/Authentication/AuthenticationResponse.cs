using Template.Domain.Entities;

namespace Template.Contracts.Authentication
{
    public record AuthenticationResponse
    (
        string FirstName,
        string LastName,
        string Email,
        string Token
     );
}
