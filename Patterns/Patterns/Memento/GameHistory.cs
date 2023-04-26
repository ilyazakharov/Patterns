namespace Patterns.Memento;

/// <summary>
/// Game history.
/// </summary>
internal class GameHistory
{
    private readonly WitcherMemento[] saves = new WitcherMemento[10];

    /// <summary>
    /// Save game.
    /// </summary>
    /// <param name="memento">Witcher state.</param>
    /// <param name="slot">Saving slot.</param>
    public void SaveGame(WitcherMemento memento, int slot)
    {
        if (memento == null)
        {
            throw new ArgumentNullException(nameof(memento));
        }

        if (slot is < 0 or > 9)
        {
            throw new ArgumentNullException(nameof(slot));
        }

        this.saves[slot] = memento;
    }

    /// <summary>
    /// Load game.
    /// </summary>
    /// <param name="slot">Saving slot.</param>
    /// <returns>Witcher state.</returns>
    public WitcherMemento? LoadGame(int slot)
    {
        if (slot is < 0 or > 9)
        {
            throw new ArgumentNullException(nameof(slot));
        }

        return this.saves[slot];
    }
}
