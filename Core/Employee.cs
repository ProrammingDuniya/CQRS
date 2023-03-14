using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// Employee
    /// </summary>
    public class Employee : Entity<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="dateOfBirth">The date of birth.</param>
        /// <param name="city">The city.</param>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="street">The street.</param>
        private Employee(string? firstName, string? lastName, DateTime? dateOfBirth, string? city, string? postalCode, string? street)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            City = city;
            PostalCode = postalCode;
            Street = street;
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string? FirstName { get; private set; }

        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string? LastName { get; private set; }

        /// <summary>
        /// Gets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        public DateTime? DateOfBirth { get; private set; }

        /// <summary>
        /// Gets the street.
        /// </summary>
        /// <value>
        /// The street.
        /// </value>
        public string? Street { get; private set; }

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string? City { get; private set; }

        /// <summary>
        /// Gets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string? PostalCode { get; private set; }

        /// <summary>
        /// Creates the specified first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="dateOfBirth">The date of birth.</param>
        /// <param name="city">The city.</param>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="street">The street.</param>
        /// <returns></returns>
        public static Employee Create(string? firstName, string? lastName, DateTime? dateOfBirth, string? city, string? postalCode, string? street) =>
           new(firstName, lastName, dateOfBirth, city, postalCode, street);
    }
}
