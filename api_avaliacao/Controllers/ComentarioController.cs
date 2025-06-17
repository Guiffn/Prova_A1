using api_avaliacao.Data.Interfaces;
using api_avaliacao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_avaliacao.Controllers;

[Route("api/comentario")]
[ApiController]
public class ComentarioController : ControllerBase
{
    private readonly IItemRepository _itemRepository;
    private readonly IComentarioRepository _rep;
    public ComentarioController(IComentarioRepository rep,IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
        _rep = rep;
        }

    [HttpPost("cadastrar")]
    public IActionResult Cadastrar([FromBody] Comentario comentario)
    {
        comentario.Item = _itemRepository.BuscarCategoriaPorId(comentario.ItemId);
        _rep.Cadastrar(comentario);
        return Created("", comentario);
    }

    [HttpGet("listar")]
    public IActionResult Listar()
    {
        return Ok(_rep.Listar());
    }
    }

