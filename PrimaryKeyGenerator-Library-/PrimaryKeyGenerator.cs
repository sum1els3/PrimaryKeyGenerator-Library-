using System;

namespace PrimaryKeyGenerator_Library_
{
    /// <summary>
    /// Generates a new primary key
    /// </summary>
    public static class PrimaryKeyGenerator
    {
        /// <summary>
        /// Initializes the size of the string
        /// </summary>
        public static int Lenght = 0;
        /// <summary>
        /// Initializes where the dash will be inserted
        /// </summary>
        public static int Interval = 0;

        /// <summary>
        ///  Generates a 15 characters primary key
        /// </summary>
        /// <returns></returns>
        public static string GenerateCustomPrimaryKey()
        {
            return CreateCustomPrimaryKey(new Random());
        }

        /// <summary>
        /// Creates a new primary key.
        /// </summary>
        /// <returns></returns>
        private static string CreateCustomPrimaryKey(Random random)
        {
            string custom_primary_key = "";
            for (int key_length = 1; key_length <= Lenght; key_length++)
            {
                custom_primary_key += key_length % Interval == 0 && key_length != 0 ? "-" : GenerateLetterOrNumber(random.Next(1, 4), random);
            }
            return custom_primary_key;
        }

        /// <summary>
        /// Creates a random character
        /// </summary>
        /// <param name="category"></param>
        /// <param name="random"></param>
        /// <returns></returns>
        private static string GenerateLetterOrNumber(int category, Random random)
        {
            return category == 1 ? ((char)random.Next('0', '9')).ToString() : category == 2 ? ((char)random.Next('A', 'Z')).ToString() : category == 3 ? ((char)random.Next('a', 'z')).ToString() : "a";
        }
    }
}
