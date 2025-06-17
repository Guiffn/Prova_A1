
using api_avaliacao.Models;

namespace api_avaliacao.Data.Interfaces;

public interface IItemRepository
{
    void Cadastrar(Item Item);
    Item BuscarCategoriaPorId(int id);
    List<Item> Listar();

};