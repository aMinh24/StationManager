using Meziantou.Framework.Win32;
using System;

namespace TaskManager.Service
{
    public static class SavePassword
    {
        public static List<Credential> LoadCredential()
        {
            return CredentialManager.EnumerateCredentials().Where(x => x.ApplicationName.StartsWith("SMAccount")).ToList();
        }
        public static void SaveCredential(string username, string password, bool cb)
        {
            if (cb)
            {
                CredentialManager.WriteCredential(
                applicationName: "SMAccount_" + username,
                userName: username,
                secret: password,
                comment: "",
                persistence: CredentialPersistence.LocalMachine);
            }
            else
            {
                try
                {
                    CredentialManager.DeleteCredential("SMAccount_" + username);
                }
                catch { }
            }
        }
    }
}
