namespace OwnDictionary;
class Program
{
    static void Main()
    {
        var otusDictionary = new OtusDictionary();
        otusDictionary.Add(1, "test");
        otusDictionary.Add(1, "test12");
        var result = otusDictionary.Get(1);
    }
}
