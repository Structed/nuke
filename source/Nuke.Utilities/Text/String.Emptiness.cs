// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using JetBrains.Annotations;

namespace Nuke.Common.Utilities;

public static partial class StringExtensions
{
    /// <summary>
    /// Indicates whether a specified string is null or empty.
    /// </summary>
    [Pure]
    [ContractAnnotation("null => halt")]
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }

    /// <summary>
    /// Indicates whether a specified string is null, empty, or consists only of whitespace characters.
    /// </summary>
    [Pure]
    [ContractAnnotation("null => halt")]
    public static bool IsNullOrWhiteSpace(this string str)
    {
        return string.IsNullOrWhiteSpace(str);
    }

    /// <summary>
    /// Returns the same string if it's not empty, otherwise null.
    /// </summary>
    [Pure]
    [ContractAnnotation("null => null")]
    public static string NullIfEmpty(this string str)
    {
        return !str.IsNullOrEmpty() ? str : null;
    }

    /// <summary>
    /// Returns the same string if it's not only whitespaces, otherwise null.
    /// </summary>
    [Pure]
    [ContractAnnotation("null => null")]
    public static string NullIfWhiteSpace(this string str)
    {
        return !str.IsNullOrWhiteSpace() ? str : null;
    }
}
