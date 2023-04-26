namespace Patterns.Memento;

/// <summary>
/// The witcher.
/// </summary>
internal class Witcher
{
    private int lives = 100;
    private int mana = 100;
    private int armour = 0;

    /// <summary>
    /// Casts a spell.
    /// </summary>
    public void CastASpell()
    {
        if (this.mana <= 0)
        {
            return;
        }

        this.mana -= 30;
    }

    /// <summary>
    /// Meditates.
    /// </summary>
    public void Meditate()
    {
        this.mana = 100;
    }

    /// <summary>
    /// Enhance armour.
    /// </summary>
    /// <param name="enhancement">Enhancement value.</param>
    public void EnhanceArmour(int enhancement)
    {
        this.armour += enhancement;
    }

    /// <summary>
    /// Get damage.
    /// </summary>
    /// <param name="damage">Value of the damage.</param>
    public void GetDamage(int damage)
    {
        int finalDamage = damage * (1 - (this.armour / 10));
        this.lives -= finalDamage;

        if (this.lives <= 0)
        {
            this.Die();
        }
    }

    /// <summary>
    /// Save character.
    /// </summary>
    /// <returns>Memento object.</returns>
    public WitcherMemento Save()
    {
        WitcherMemento memento = new (this.lives, this.mana);
        return memento;
    }

    /// <summary>
    /// Load saved character.
    /// </summary>
    /// <param name="memento">Memento object.</param>
    public void Load(WitcherMemento memento)
    {
        this.lives = memento.Lives;
        this.mana = memento.Mana;
    }

    /// <inheritdoc/>
    public override string? ToString()
    {
        return $"Witcher's lives: {this.lives}, mana: {this.mana}";
    }

    private void Die()
    {
        this.lives = 0;
        this.mana = 0;
        Console.WriteLine("Wither is dead");
    }
}
