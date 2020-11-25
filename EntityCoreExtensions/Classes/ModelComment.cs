namespace EntityCoreExtensions.Classes
{
    public class ModelComment
    {
        /// <summary>
        /// Property name
        /// </summary>
        public string Name { get; internal set; }
        /// <summary>
        /// Comment value
        /// </summary>
        public string Comment { get; internal set; }
        public string Full => $"{Name}, {Comment}";
        public override string ToString() => Name;

    }
}