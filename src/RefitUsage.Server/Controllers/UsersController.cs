using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RefitUsage.Server.Dto;
using RefitUsage.Contract.Interfaces;

namespace RefitUsage.Server.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;
    public UsersController(IUserService userService, IMapper mapper) 
    {
        _userService = userService;
        _mapper = mapper;
    } 

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsers()
    {
        var users = await _userService.GetUsers();
        if(users is null || !users.Any()) 
        {
            return NotFound();
        }
        var usersDto = new List<UserDto>();
        foreach(var user in users)
        {
            usersDto.Add(_mapper.Map<UserDto>(user));
        }      
        
        return Ok(usersDto);
    }

    [HttpGet("{login}")]
    public async Task<ActionResult<UserDto>> GetUser(string login)
    {
        var user = await _userService.GetUserByLogin(login);
        if(user is null) 
        {
            return NotFound();
        }
        return Ok(_mapper.Map<UserDto>(user));
    }

}