﻿namespace NestedObjects
{
	/// <summary>
	/// Represents an individual college student
	/// </summary>
	public class Student
	{
		/// <summary>
		/// The legal first name
		/// </summary>
        public string FirstName { get; set; }

		/// <summary>
		/// The legal last name
		/// </summary>
        public string LastName { get; set; }

		/// <summary>
		/// The assigned school email address
		/// </summary>
        public string SchoolEmail { get; set; }

		/// <summary>
		/// Student's date of birth
		/// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Student's preferred phone number
        /// </summary>
        public string PhoneNumber { get; set; }

		/// <summary>
		/// The advisor who is assing to the student
		/// </summary>
		public Advisor AssignedAdvisor { get; set; }
    }
}
