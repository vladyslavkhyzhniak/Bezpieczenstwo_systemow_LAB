namespace Bezpieczeństwo_systemów_LAB.Models;

public class SzyfrCezaraEncrypt
{
    public string? text { get; set; }
    public int? step { get; set; }

    public bool IsValid()
    {
        return text != null && step != null;
    }

    public string Encrypt()
    {
        step = step % 35;
        if (step<0)
        {
            step += 35;
        }
        string result = null;

        string Clearedtext = string.Join("", text.Split(' ')).ToLower();

        for (int i = 0; i < Clearedtext.Length; i++)
        {
            char letter = Clearedtext[i];
            int index = Array.IndexOf(Enum.GetNames(typeof(AlphabetEnum)), letter.ToString());
            int EncryptedIndex =index +step.Value;
            if (EncryptedIndex > 34)
            {
                EncryptedIndex -=35;
            }
            
            AlphabetEnum? EncryptedLetter =(AlphabetEnum)EncryptedIndex;
            result+=EncryptedLetter.ToString();
        }
        return result;
    }
}