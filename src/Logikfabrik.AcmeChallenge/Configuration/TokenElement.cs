// <copyright file="TokenElement.cs" company="Logikfabrik">
//   Copyright (c) 2016 anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Logikfabrik.AcmeChallenge.Configuration
{
    using System.Configuration;

    /// <summary>
    /// The <see cref="TokenElement" /> class.
    /// </summary>
    public class TokenElement : ConfigurationElement
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        [ConfigurationProperty(
            "token",
            IsRequired = true,
            IsKey = true)]
        public string Token
        {
            get { return (string)this["token"]; }
            set { this["token"] = value; }
        }

        /// <summary>
        /// Gets or sets the payload.
        /// </summary>
        /// <value>
        /// The payload.
        /// </value>
        [ConfigurationProperty(
            "payload",
            IsRequired = true)]
        public string Payload
        {
            get { return (string)this["payload"]; }
            set { this["payload"] = value; }
        }
    }
}