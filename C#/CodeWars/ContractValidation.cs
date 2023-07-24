#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Codewars;

public static class ContractValidationExtensions
{
	public static string NotNullOrWhiteSpace([NotNull] this string? value,
		[CallerArgumentExpression("value")] string name = "") =>
		string.IsNullOrWhiteSpace(value)
			? throw new ArgumentException(
				string.Format(CultureInfo.CurrentCulture, "StringCannotBeEmpty"), name)
			: value;

	public static bool NotLessThan500(this int value,
		[CallerArgumentExpression("value")] string name = "") =>
		value < 500
			? throw new ArgumentOutOfRangeException(name, value,
				string.Format(CultureInfo.CurrentCulture, "ArgumentCannotBeLessThan500USD"))
			: true;

	public static int NotLessThan10(this int value,
		[CallerArgumentExpression("value")] string name = "") =>
		value < 10
			? throw new ArgumentOutOfRangeException(name, value,
				string.Format(CultureInfo.CurrentCulture, "customer can not be less than 10"))
			: value;

	public static int NotNegative(this int value,
		[CallerArgumentExpression("value")] string name = "") =>
		value < 0
			? throw new ArgumentOutOfRangeException(name, value,
				string.Format(CultureInfo.CurrentCulture, "ArgumentCannotBeNegative"))
			: value;
}