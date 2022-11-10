namespace team3.Data;

/// <summary>
/// Class to create a random code to access a hunt
/// </summary>
public class CodeGenerator
{
    private int codeLength = 6;
    private string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

    public string CreateAccessCode() //Function creates and returns random access code
    {
        Random rand = new Random();
        string accessCode = "";
        for (int x = 0; x < codeLength; x++)
        {
            accessCode += letters[rand.Next(letters.Length)];
        }
        // TODO: implement functionality to determine if the new codes are unique
        return accessCode;
    }
}
