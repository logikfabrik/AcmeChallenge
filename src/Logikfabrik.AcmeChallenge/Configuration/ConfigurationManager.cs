// <copyright file="ConfigurationManager.cs" company="Logikfabrik">
//   Copyright (c) 2016 anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Logikfabrik.AcmeChallenge.Configuration
{
    using System.Linq;

    /// <summary>
    /// The <see cref="ConfigurationManager" /> class. Manager for ACME challenge configuration.
    /// </summary>
    public static class ConfigurationManager
    {
        private static readonly Section Section = GetSection();

        /// <summary>
        /// Gets a value indicating whether ACME challenge support is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        public static bool Enabled => Section.Enabled;

        /// <summary>
        /// Gets the tokens.
        /// </summary>
        /// <value>
        /// The tokens.
        /// </value>
        public static TokenElement[] Tokens => Section.Tokens.Cast<TokenElement>().ToArray();

        /// <summary>
        /// Gets the configuration section.
        /// </summary>
        /// <returns>The configuration section.</returns>
        private static Section GetSection()
        {
            return System.Configuration.ConfigurationManager.GetSection("logikfabrik.acmeChallenge") as Section ?? new Section();
        }
    }
}