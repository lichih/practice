namespace Tests;
using Prac.Model;
using static Prac.Serialize.Serialize;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        const string s = @"{""Key"":""_"",""Name"":""Player 1"",""Items"":[],""Gold"":123}";
        var p = new Player() {
            Key = "_",
            Name = "Player 1",
            Gold = 123,
       };
       Console.WriteLine(p.ToJson());
       Assert.AreEqual(s, p.ToJson());
    }
}