using Microsoft.AspNetCore.Mvc;
using RefitUsage.Domain.Interfaces;
using RefitUsage.Server.Dto;
using AutoMapper;

namespace RefitUsage.Server.Controllers;

[ApiController]
[Route("api/writers")]
public class WritersController : ControllerBase
{
    private readonly IWriter _writerService;
    private readonly IMapper _mapper;
    public WritersController(IWriter writerService, IMapper mapper)
    {
        _writerService = writerService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<WriterDto>>> GetAllWriters()
    {
        var writers = await _writerService.GetWriters();
        if(writers is null || !writers.Any()) 
        {
            return NotFound();
        }
        var writersDto = new List<WriterDto>();
        foreach(var writer in writers)
        {
            writersDto.Add(_mapper.Map<WriterDto>(writer));
        }      
        
        return Ok(writersDto);
    }




}