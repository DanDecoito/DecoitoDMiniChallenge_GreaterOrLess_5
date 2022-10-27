// Daniel Decoito
// 10-25-2022
// MiniChallenge 6 
// Use api to return if one int value is greater than or less than another
// PR: Rafael Manzo Runs well. API is nice, Runs on postman well, Teranary Operator... Niiiice. Kudos

using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallenge_GreaterOrLess_5.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLessController : ControllerBase
{

[HttpGet]
[Route("Maths/{num1}/{num2}")]
public string Maths(string num1,string num2)
{
    
    int number1 = int.Parse(num1);
    int number2 = int.Parse(num2);

    string response = number1 == number2 ? $"{num1} is equal to {num2}" : number1 > number2 ? $"{num1} is Greater than {num2}" :  $"{num1} is Less than {num2}";

    return response;
}


}
