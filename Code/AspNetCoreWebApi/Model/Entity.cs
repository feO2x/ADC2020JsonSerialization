using System;

namespace AspNetCoreWebApi.Model
{
    public abstract class Entity<T> : IEquatable<T>
        where T : Entity<T>
    {
        protected Entity(int id)
        {
            Id = id;
        }

        public int Id { get; }

        public bool Equals(T? other)
        {
            return Id == other?.Id;
        }

        public override bool Equals(object? obj)
        {
            return obj is T entity && Equals(entity);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}