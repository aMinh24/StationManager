using Meziantou.Framework.Win32;
using System;

namespace TaskManager.Service
{
    public static class SavePassword
    {
        public static List<Credential> LoadCredential()
        {
            return CredentialManager.EnumerateCredentials().Where(x => x.ApplicationName.StartsWith("TMAccount")).ToList();
        }
        public static void SaveCredential(string username, string password, bool cb)
        {
            if (cb)
            {
                CredentialManager.WriteCredential(
                applicationName: "TMAccount_" + username,
                userName: username,
                secret: password,
                comment: "",
                persistence: CredentialPersistence.LocalMachine);
            }
            else
            {
                try
                {
                    CredentialManager.DeleteCredential("TMAccount_" + username);
                }
                catch { }
            }
        }
    }
}
