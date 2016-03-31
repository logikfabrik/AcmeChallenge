// <copyright file="Section.cs" company="Logikfabrik">
//   Copyright (c) 2016 anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Logikfabrik.AcmeChallenge.Configuration
{
    using System.Configuration;

    /// <summary>
    /// The <see cref="Section" /> class.
    /// </summary>
    public class Section : ConfigurationSection
    {
        /// <summary>
        /// Gets or sets a value indicating whether ACME challenge support is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        [ConfigurationProperty(
            "enabled",
            DefaultValue = "true",
            IsRequired = false)]
        public bool Enabled
        {
            get { return (bool)this["enabled"]; }
            set { this["enabled"] = value; }
        }

        /// <summary>
        /// Gets or sets the tokens.
        /// </summary>
        /// <value>
        /// The tokens.
        /// </value>
        [ConfigurationProperty(
            "tokens",
            IsRequired = true,
            IsDefaultCollection = true)]
        public TokenElementCollection Tokens
        {
            get { return (TokenElementCollection)this["tokens"]; }
            set { this["tokens"] = value; }
        }
    }
}
