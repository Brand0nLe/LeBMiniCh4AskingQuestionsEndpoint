//Brandon Le
//10-25-22
//Mini Challenge 4 - Asking Questions
//Web API project that will take the users two inputs in the url and take the two inputs and print them out in the statement:
//Hello {name}! It's nice to finally meet you! Wow you woke up at {time} AM?! That's impressive! The early bird gets the worm :)
//For example if it's MiniCh4/Asking/Brandon/5 the outcome would be Hello Brandon. It's nice to finally meet you! Wow you woke up at 5AM?! That's impressive! The early bird gets the worm :)
//Peer Review Carlos Felipe: This program works well it displays a good amount of text about the user's name and time they woke. It is way better than my one liner that is bland and boring and not good and god I wish I was as good as Brandon. Good job. 



using Microsoft.AspNetCore.Mvc;

namespace MiniCh4AskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh4Controller : ControllerBase
{
    [HttpGet]
    [Route("Asking/{name}/{time}")]
    public string sayHello(string name, string time)
    {
        return $"Hi there what's your name? \n Wow what a beautiful name you have {name}! It's nice to finally meet you! \n What time did you wake up today? \n Wow you woke up at {time} AM?! You must be fully rested :)";
    }
}