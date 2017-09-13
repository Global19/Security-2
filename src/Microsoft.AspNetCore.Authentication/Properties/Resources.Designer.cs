// <auto-generated />
namespace Microsoft.AspNetCore.Authentication
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Authentication.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The default data protection provider may only be used when the IApplicationBuilder.Properties contains an appropriate 'host.AppName' key.
        /// </summary>
        internal static string Exception_DefaultDpapiRequiresAppNameKey
        {
            get => GetString("Exception_DefaultDpapiRequiresAppNameKey");
        }

        /// <summary>
        /// The default data protection provider may only be used when the IApplicationBuilder.Properties contains an appropriate 'host.AppName' key.
        /// </summary>
        internal static string FormatException_DefaultDpapiRequiresAppNameKey()
            => GetString("Exception_DefaultDpapiRequiresAppNameKey");

        /// <summary>
        /// The state passed to UnhookAuthentication may only be the return value from HookAuthentication.
        /// </summary>
        internal static string Exception_UnhookAuthenticationStateType
        {
            get => GetString("Exception_UnhookAuthenticationStateType");
        }

        /// <summary>
        /// The state passed to UnhookAuthentication may only be the return value from HookAuthentication.
        /// </summary>
        internal static string FormatException_UnhookAuthenticationStateType()
            => GetString("Exception_UnhookAuthenticationStateType");

        /// <summary>
        /// The AuthenticationTokenProvider's required synchronous events have not been registered.
        /// </summary>
        internal static string Exception_AuthenticationTokenDoesNotProvideSyncMethods
        {
            get => GetString("Exception_AuthenticationTokenDoesNotProvideSyncMethods");
        }

        /// <summary>
        /// The AuthenticationTokenProvider's required synchronous events have not been registered.
        /// </summary>
        internal static string FormatException_AuthenticationTokenDoesNotProvideSyncMethods()
            => GetString("Exception_AuthenticationTokenDoesNotProvideSyncMethods");

        /// <summary>
        /// The '{0}' option must be provided.
        /// </summary>
        internal static string Exception_OptionMustBeProvided
        {
            get => GetString("Exception_OptionMustBeProvided");
        }

        /// <summary>
        /// The '{0}' option must be provided.
        /// </summary>
        internal static string FormatException_OptionMustBeProvided(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("Exception_OptionMustBeProvided"), p0);

        /// <summary>
        /// The SignInScheme for a remote authentication handler cannot be set to itself.  If it was not explicitly set, the AuthenticationOptions.DefaultSignInScheme is used.
        /// </summary>
        internal static string Exception_RemoteSignInSchemeCannotBeSelf
        {
            get => GetString("Exception_RemoteSignInSchemeCannotBeSelf");
        }

        /// <summary>
        /// The SignInScheme for a remote authentication handler cannot be set to itself.  If it was not explicitly set, the AuthenticationOptions.DefaultSignInScheme is used.
        /// </summary>
        internal static string FormatException_RemoteSignInSchemeCannotBeSelf()
            => GetString("Exception_RemoteSignInSchemeCannotBeSelf");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
