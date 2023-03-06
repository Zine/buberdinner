using System;
namespace BuberDinner.Application;

public interface IDateTimeProvider
{
	DateTimeOffset UtcNow { get; }
}

