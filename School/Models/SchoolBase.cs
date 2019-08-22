using System;

namespace School.Models
{
    public abstract class SchoolBase
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public SchoolBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Name},{UniqueId}";
        }
    }
}