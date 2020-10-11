using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AspNetCoreWebApi.Model
{
    public sealed class Organization : Entity<Organization>
    {
        private List<User>? _users;

        public Organization(int id, string name) : base(id)
        {
            Name = name;
        }

        public string Name { get; }

        public IReadOnlyList<User> Users => _users ??= new List<User>();

        public bool CheckIfUserExists(string email)
        {
            if (_users == null)
                return false;

            foreach (var user in _users)
            {
                if (user.Email == email)
                    return true;
            }

            return false;
        }

        public bool TryAddNewUser(string firstName,
                                  string lastName,
                                  string email,
                                  [NotNullWhen(true)] out User? newUser)
        {
            if (CheckIfUserExists(email))
            {
                newUser = null;
                return false;
            }

            var users = _users ??= new List<User>();
            newUser = new User(_users.Count + 1, firstName, lastName, email, this);
            users.Add(newUser);
            return true;
        }
    }
} 