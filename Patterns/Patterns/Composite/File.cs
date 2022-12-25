using System.Text;

namespace Patterns.Composite
{
    /// <summary>
    /// File.
    /// </summary>
    public class File : Component
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        /// <param name="name">Name of the file.</param>
        public File(string name)
            : base(name)
        {
        }

        /// <inheritdoc/>
        public override void Open()
        {
            Console.WriteLine("Opened file: " + this.FullName);
        }

        /// <inheritdoc/>
        public override List<Component> GetSubComponents()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        protected override void AddComponent(Component component)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        protected override void RemoveComponent(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
