using System;
namespace BuberDinner.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
	string GenerateToken(Guid UserId, string FirstName, string LastName);
}

