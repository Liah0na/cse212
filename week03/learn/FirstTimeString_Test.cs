
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class FindFirstLetterTests
{
  [TestMethod]
  // Scenario: A duplicate character exists later in the string.
  // Expected Result: Return the first duplicated character found.
  // Defect(s) Found: None.
  public void FindFirstLetter_NormalDuplicate()
  {
    var FirstTimeString = new FirstTimeString();
    var result = FirstTimeString.FindFirstLetter("ABCDEFA");

    Assert.AreEqual('a', result);
  }

  [TestMethod]
  // Scenario: Duplicate letters appear immediately.
  // Expected Result: Return the duplicated character.
  // Defect(s) Found: None.
  public void FindFirstLetter_ImmediateDuplicate()
  {
    var FirstTimeString = new FirstTimeString();
    var result = FirstTimeString.FindFirstLetter("AABC");

    Assert.AreEqual('a', result);
  }

  [TestMethod]
  // Scenario: Uppercase and lowercase versions of the same letter exist.
  // Expected Result: Method should detect duplicates because text is normalized to lowercase.
  // Defect(s) Found: None.
  public void FindFirstLetter_CaseInsensitive()
  {
    var FirstTimeString = new FirstTimeString();
    var result = FirstTimeString.FindFirstLetter("AbCdEa");

    Assert.AreEqual('a', result);
  }

  [TestMethod]
  // Scenario: String contains multiple duplicates.
  // Expected Result: Return the first duplicated letter encountered during traversal.
  // Defect(s) Found: None.
  public void FindFirstLetter_MultipleDuplicates()
  {
    var FirstTimeString = new FirstTimeString();
    var result = FirstTimeString.FindFirstLetter("ABCDEFGDB");

    Assert.AreEqual('d', result);
  }

  [TestMethod]
  // Scenario: String contains no duplicate characters.
  // Expected Result: Throw an ArgumentException.
  // Defect(s) Found: None.
  public void FindFirstLetter_NoDuplicates()
  {
    Assert.ThrowsException<ArgumentException>(() =>
    {
      var FirstTimeString = new FirstTimeString();
      FirstTimeString.FindFirstLetter("ABCDEF");
    });
  }

  [TestMethod]
  // Scenario: Empty string is provided.
  // Expected Result: Throw an ArgumentException.
  // Defect(s) Found: None.
  public void FindFirstLetter_EmptyString()
  {
    Assert.ThrowsException<ArgumentException>(() =>
    {
      var FirstTimeString = new FirstTimeString();
      FirstTimeString.FindFirstLetter("");
    });
  }

  [TestMethod]
  // Scenario: String contains spaces as duplicate characters.
  // Expected Result: Return the duplicated space character.
  // Defect(s) Found: None.
  public void FindFirstLetter_DuplicateSpaces()
  {
    var FirstTimeString = new FirstTimeString();
    var result = FirstTimeString.FindFirstLetter("A B C ");

    Assert.AreEqual(' ', result);
  }
}