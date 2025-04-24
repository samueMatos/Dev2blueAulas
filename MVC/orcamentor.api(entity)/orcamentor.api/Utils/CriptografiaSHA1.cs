using System.Security.Cryptography;
using System.Text;

namespace orcamentor.api.Utils;

public class CriptografiaSHA1
{
    public static string CriptografarSenha(string senha)
    {
        SHA1 sha1 = SHA1.Create();
        byte[] bytesSenha = System.Text.Encoding.UTF8.GetBytes(senha);
        byte[] hashSenha = sha1.ComputeHash(bytesSenha);
        StringBuilder sb = new StringBuilder();
        
        foreach (var t in hashSenha)
        {
            sb.Append(t.ToString("X2"));
        }
        return sb.ToString();
        
    }
}