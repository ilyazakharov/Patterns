namespace Patterns.Composite
{
    /// <summary>
    /// Folder.
    /// </summary>
    public class Folder : Component
    {
        private readonly List<Component> components = new ();

        /// <summary>
        /// Initializes a new instance of the <see cref="Folder"/> class.
        /// </summary>
        /// <param name="name">Name of the folder.</param>
        public Folder(string name)
            : base(name)
        {
        }

        /// <inheritdoc/>
        public override List<Component> GetSubComponents()
        {
            return this.components;
        }

        /// <inheritdoc/>
        public override void Open()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        protected override void AddComponent(Component component)
        {
            this.components.Add(component);
        }

        /// <inheritdoc/>
        protected override void RemoveComponent(Component component)
        {
            this.components.Remove(component);
        }
    }
}
