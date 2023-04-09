namespace Patterns.Builder;

/// <summary>
/// House.
/// </summary>
/// <param name="IsMedieval">Is medieval.</param>
/// <param name="HasOuthouse">Has outhouse</param>
/// <param name="HasPark">Has park</param>
internal record House(bool IsMedieval, bool HasOuthouse, bool HasPark);
