using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Madlib()
    {
      MadlibVariable myMadlibVariable = new MadlibVariable();
      myMadlibVariable.Noun = "turkey";
      myMadlibVariable.Adjective = "delicious";
      myMadlibVariable.Verb = "walk";
      return View(myMadlibVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/finalPage")]
    public ActionResult FinalPage(string noun, string adjective, string verb)
    {
      MadlibVariable myMadlibVariable = new MadlibVariable();
      myMadlibVariable.Noun = noun;
      myMadlibVariable.Adjective = adjective;
      myMadlibVariable.Verb = verb;
      return View(myMadlibVariable);
    }
  }
}
