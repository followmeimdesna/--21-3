using System;

class CaesarCipher
{
    private int shift;

    public CaesarCipher(int shift)
    {
        this.shift = shift;
    }

    public string Encrypt(string input)
    {
        char[] characters = input.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLetter(characters[i]))
            {
                char baseChar = char.IsUpper(characters[i]) ? 'A' : 'a';
                characters[i] = (char)(((characters[i] - baseChar + shift) % 28) + baseChar);
            }
        }

        return new string(characters);
    }

    public string Decrypt(string input)
    {
        char[] characters = input.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLetter(characters[i]))
            {
                char baseChar = char.IsUpper(characters[i]) ? 'A' : 'a';
                characters[i] = (char)(((characters[i] - baseChar - shift + 28) % 28) + baseChar);
            }
        }

        return new string(characters);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Что нужно зашифровать ?: ");
        string originalText = Console.ReadLine();

        Console.Write("Введите целое число: ");
        int shift = int.Parse(Console.ReadLine());

        CaesarCipher cipher = new CaesarCipher(shift);

        string encryptedText = cipher.Encrypt(originalText);
        Console.WriteLine("Зашифрованный текст: " + encryptedText);

        string decryptedText = cipher.Decrypt(encryptedText);
        Console.WriteLine("Расшифрованный текст: " + decryptedText);
    }
}