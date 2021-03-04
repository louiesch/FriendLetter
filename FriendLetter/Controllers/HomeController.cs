using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route ("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route ("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route ("/")] //root path aka home page
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Landes";
      myLetterVariable.Sender = "Louie";
      return View(myLetterVariable);
    }

    [Route ("/form")]
    public ActionResult Form() { return View(); }

    [Route ("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient; //for recipient and sender, application is looking for the name attributes in Form.cshtml
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }
  }
}