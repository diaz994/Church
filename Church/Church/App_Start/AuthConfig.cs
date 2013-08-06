using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using Church.Models;

namespace Church
{
	public static class AuthConfig
	{
		public static void RegisterAuth()
		{
			//OAuthWebSecurity.RegisterMicrosoftClient(
			//    clientId: "",
			//    clientSecret: "");

			//OAuthWebSecurity.RegisterTwitterClient(
			//    consumerKey: "",
			//    consumerSecret: "");

			OAuthWebSecurity.RegisterFacebookClient(
				appId: "573370666038574",
				appSecret: "a3e1b3a2ab1129ba9cd80a35dd643e31");

			//OAuthWebSecurity.RegisterGoogleClient();
		}
	}
}
