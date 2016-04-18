// <copyright file="AcmeChallengeHttpHandler.cs" company="Logikfabrik">
//   Copyright (c) 2016 anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Logikfabrik.AcmeChallenge
{
    using System.Linq;
    using System.Web;
    using Configuration;

    /// <summary>
    /// The <see cref="AcmeChallengeHttpHandler" /> class. HTTP handler for ACME challenges.
    /// </summary>
    public class AcmeChallengeHttpHandler : IHttpHandler
    {
        /// <summary>
        /// Gets a value indicating whether another request can use this <see cref="AcmeChallengeHttpHandler" /> instance.
        /// </summary>
        public bool IsReusable => true;

        /// <summary>
        /// Processes of HTTP web requests.
        /// </summary>
        /// <param name="context">An <see cref="HttpContext" /> object that provides references to the intrinsic server objects used to service HTTP requests.</param>
        public void ProcessRequest(HttpContext context)
        {
            if (!ConfigurationManager.Enabled)
            {
                context.Response.StatusCode = 404;
                context.Response.End();

                return;
            }

            var tokenSegment = context.Request.Url.Segments.LastOrDefault();
            var tokenElement = ConfigurationManager.Tokens.FirstOrDefault(element => element.Token.Equals(tokenSegment));

            if (tokenElement == null)
            {
                context.Response.StatusCode = 404;
                context.Response.End();

                return;
            }

            context.Response.Write(tokenElement.Payload);
        }
    }
}