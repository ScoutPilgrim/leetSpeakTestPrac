using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void LeetCheck_CharIse()
    {
      string myStr = "eee";
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual(true, testLeet.LeetCheck(myStr));
    }
    [TestMethod]
    public void LeetCheck_CharIso()
    {
      string myStr = "ooo";
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual(true, testLeet.LeetCheck(myStr));
    }
    [TestMethod]
    public void LeetCheck_CharIsI()
    {
      string myStr = "III";
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual(true, testLeet.LeetCheck(myStr));
    }
    [TestMethod]
    public void LeetCheck_CharIst()
    {
      string myStr = "ttt";
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual(true, testLeet.LeetCheck(myStr));
    }
    [TestMethod]
    public void LeetCheck_CharIss()
    {
      string myStr = "sss";
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual(true, testLeet.LeetCheck(myStr));
    }
    [TestMethod]
    public void LeetConvert_CharIsAll()
    {
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual('3', testLeet.LeetConvert('e'));
      Assert.AreEqual('0', testLeet.LeetConvert('o'));
      Assert.AreEqual('1', testLeet.LeetConvert('I'));
      Assert.AreEqual('7', testLeet.LeetConvert('t'));
      Assert.AreEqual('z', testLeet.LeetConvert('s'));
    }
    [TestMethod]
    public void LeetConvert_CharIsFailure()
    {
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual('~', testLeet.LeetConvert('w'));//Check Failure return
    }
    [TestMethod]
    public void LeetMakeStr_AllChars()
    {
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual("3 0 1 7 z", testLeet.LeetMakeStr("e o I t s"));
    }
    [TestMethod]
    public void LeetMakeStr_NoChars()
    {
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual("w p z x v", testLeet.LeetMakeStr("w p z x v"));
    }
    [TestMethod]
    public void LeetMakeStr_MixChars()
    {
      IsLeet testLeet = new IsLeet();
      Assert.AreEqual("Thiz iz a 73z7", testLeet.LeetMakeStr("This is a test"));
      Assert.AreEqual("And z0 iz 7hiz 0n3", testLeet.LeetMakeStr("And so is this one"));
    }
  }
}
