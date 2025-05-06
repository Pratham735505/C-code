

interface Encryptable
{
    string Encrypt(string data);
    string Decrypt(string encryptedData);
}

class AES : Encryptable
{
    public string Encrypt(string data)
    {
        return "AES_Encrypted_" + data;
    }

    public string Decrypt(string encryptedData)
    {
        return encryptedData.Replace("AES_Encrypted_", "");
    }
}

class RSA : Encryptable
{
    public string Encrypt(string data)
    {
        return "RSA_Encrypted_" + data;
    }

    public string Decrypt(string encryptedData)
    {
        return encryptedData.Replace("RSA_Encrypted_", "");
    }
}

class Program
{
    static void Main()
    {
        AES aes = new AES();
        RSA rsa = new RSA();

        string aesEncrypted = aes.Encrypt("Hello World");
        Console.WriteLine(aesEncrypted); // AES_Encrypted_Hello World
        Console.WriteLine(aes.Decrypt(aesEncrypted)); // Hello World

        string rsaEncrypted = rsa.Encrypt("Hello World");
        Console.WriteLine(rsaEncrypted); // RSA_Encrypted_Hello World
        Console.WriteLine(rsa.Decrypt(rsaEncrypted)); // Hello World
    }
}
