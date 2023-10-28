using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace UsuariosAPI.Authorization;

public class IdadeAuthorization : AuthorizationHandler<IdadeMinima>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinima requirement)
    {
       var dataNascimentoClain = context.User.FindFirst(clain => clain.Type == ClaimTypes.DateOfBirth);
        if (dataNascimentoClain is null)
            return Task.CompletedTask;
        var dataNascimento = Convert.ToDateTime(dataNascimentoClain.Value);
        var idadeUsuario = DateTime.Today.Year - dataNascimento.Year;
        if (dataNascimento > DateTime.Today.AddYears(-idadeUsuario)) idadeUsuario--;
        if(idadeUsuario >= requirement.Idade) context.Succeed(requirement);
        return Task.CompletedTask;
    }
}
