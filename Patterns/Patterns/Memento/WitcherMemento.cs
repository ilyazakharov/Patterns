namespace Patterns.Memento;

/// <summary>
/// Memento for witcher.
/// </summary>
/// <param name="Lives">Lives of the saved witcher.</param>
/// <param name="Mana">Mana of the saved witcher.</param>
internal record WitcherMemento(int Lives, int Mana);
