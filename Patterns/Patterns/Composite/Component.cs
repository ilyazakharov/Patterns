namespace Patterns.Composite
{
    /// <summary>
    /// Abstract component.
    /// </summary>
    public abstract class Component
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class.
        /// </summary>
        /// <param name="name">Name of the compnent.</param>
        protected Component(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the name of the component.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the parent of the component.
        /// </summary>
        public Component? Parent { get; private set; }

        /// <summary>
        /// Gets a full name of the component.
        /// </summary>
        public string FullName
        {
            get
            {
                return (this.Parent?.FullName ?? Path.DirectorySeparatorChar.ToString()) + Path.DirectorySeparatorChar.ToString() + this.Name;
            }
        }

        /// <summary>
        /// Adds new component and changes his parent. Template method.
        /// </summary>
        /// <param name="component">Component to be added.</param>
        public void Add(Component component)
        {
            ChangeParent(component, this);
            this.AddComponent(component);
        }

        /// <summary>
        /// Removes a component and changes his parent. Template method.
        /// </summary>
        /// <param name="component">Component to be added.</param>
        public void Remove(Component component)
        {
            ChangeParent(component, null);
            this.RemoveComponent(component);
        }

        /// <summary>
        /// Prints the path to the component.
        /// </summary>
        public void Print()
        {
            Console.WriteLine(this.FullName);
        }

        /// <summary>
        /// Opens a component.
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// Returns a component by it's index.
        /// </summary>
        /// <returns>Parent components.</returns>
        public abstract List<Component> GetSubComponents();

        /// <summary>
        /// Adds new component.
        /// </summary>
        /// <param name="component">Component to be added.</param>
        protected abstract void AddComponent(Component component);

        /// <summary>
        /// Removes a component.
        /// </summary>
        /// <param name="component">Component to be added.</param>
        protected abstract void RemoveComponent(Component component);

        /// <summary>
        /// Changes the parent of the component.
        /// </summary>
        /// <param name="component">Componentwhich parent should be changed.</param>
        /// <param name="parent">New parent.</param>
        private static void ChangeParent(Component component, Component? parent)
        {
            component.Parent = parent;
        }
    }
}