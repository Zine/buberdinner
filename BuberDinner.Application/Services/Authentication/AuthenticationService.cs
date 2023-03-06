using System;
using BuberDinner.Application.Common.Interfaces.Authentication;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
	private readonly IJwtTokenGenerator _jwtGenerator;

	public AuthenticationService(IJwtTokenGenerator jwtGenerator)
	{
		_jwtGenerator = jwtGenerator;
	}

	public AuthenticationResult Login(string Email, string Password)
	{
		return new AuthenticationResult(
			Guid.NewGuid(),
			"firstName",
			"lastName",
			Email,
			"token");
	}

	public AuthenticationResult Register(string FirstName, string LastName, string Email, string Token)
	{
		// Check if user already exists

		// Create user (generate unique ID)

		// Create JWT token
		Guid UserId = Guid.NewGuid();

		var token = _jwtGenerator.GenerateToken(UserId, FirstName, LastName);

		return new AuthenticationResult(
			UserId,
			FirstName,
			LastName,
			Email,
			token);
	}
}

