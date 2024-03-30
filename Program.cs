namespace OwnDictionary;
class Program
{
    static void Main()
    {
        var ownDictionary = new OwnDictionary();
        ownDictionary.Add(1, "test");
        ownDictionary.Add(1, "test12");
        var result = ownDictionary.Get(1);
    }
}
