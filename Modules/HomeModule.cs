using Nancy;
using System.Collections.Generic;
using Counter;

namespace EnterNamespaceHere //replace with your desired namespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/submit"] = _ =>
      {
        RepeatCounter newCounter = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
        return View["index.cshtml", newCounter];
      };
    }
  }
}
