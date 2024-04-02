using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;   


public class AccountController : ControllerBase
{
    private readonly IAccountManager _accountManager;

    public AccountController(IAccountManager accountManager)
    {
        _accountManager = accountManager;
    }   

    [HttpGet("/api/account/getall")]
    public IActionResult GetAll()
    {
        return Ok(_accountManager.GetAccounts());
    }

    [HttpGet("/api/account/get/{name}")]
    public IActionResult Get(string name)
    {
        return Ok(_accountManager.GetAccount(name));
    }

    [HttpPost("/api/account/register")]
    public IActionResult Create([FromBody] User account)
    {
        Console.WriteLine("Registring account: " + account.Name); 
        _accountManager.RegisterAccount(account);

        return _accountManager.VerifyAccount(account) ? Ok(account) : BadRequest();
    }   

    [HttpPost("api/account/verify")]    
    public IActionResult Verify([FromBody] User account)
    {
        return Ok(_accountManager.VerifyAccount(account));
    }   

} 