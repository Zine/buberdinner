using System;
using BuberDinner.Application;

namespace BuberDinner.Infrastructure;

public class DateTimeProvider : IDateTimeProvider
{
	public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
}

