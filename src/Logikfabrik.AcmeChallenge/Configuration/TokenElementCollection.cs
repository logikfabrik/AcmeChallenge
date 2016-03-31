// <copyright file="TokenElementCollection.cs" company="Logikfabrik">
//   Copyright (c) 2016 anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Logikfabrik.AcmeChallenge.Configuration
{
    using System.Configuration;

    /// <summary>
    /// The <see cref="TokenElementCollection" /> class.
    /// </summary>
    public class TokenElementCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Creates a new <see cref="TokenElement" />.
        /// </summary>
        /// <returns>
        /// A new <see cref="TokenElement" />.
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new TokenElement();
        }

        /// <summary>
        /// Gets the element key for a specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="TokenElement" /> to return the key for.</param>
        /// <returns>
        /// An <see cref="string" /> that acts as the key for the specified <see cref="TokenElement" />.
        /// </returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((TokenElement)element).Token;
        }
    }
}