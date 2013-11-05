﻿using System.Management.Automation;
using Octokit;

namespace Illallangi.GitHubPS.Extensions
{
    public static class PSCredentialExtensions
    {
        public static Credentials ConvertToOctokitCredentials(this PSCredential credential)
        {
            return new Credentials(credential.UserName, credential.Password.ConvertToUnsecureString());
        }
    }
}