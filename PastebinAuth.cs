using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheat_VIP
{
    public class PastebinAuth
    {
        private const string PastebinUrl = "https://pastebin.com/raw/mk2xjYiz"; 

        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string pastebinContent = await client.GetStringAsync(PastebinUrl);
                    pastebinContent = pastebinContent.Trim();
                    string[] validLogins = pastebinContent.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string validLogin in validLogins)
                    {
                        // Remove espaços em branco e divide a linha em login e senha
                        string[] parts = validLogin.Trim().Split(':');
                        if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                        {
                            return true; // Login e senha válidos
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao autenticar: " + ex.Message);
                }
            }
            return false; // Login ou senha inválidos
        }
    }
}