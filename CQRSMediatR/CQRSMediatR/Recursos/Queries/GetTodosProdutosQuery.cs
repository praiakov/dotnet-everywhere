using CQRSMediatR.Models;
using MediatR;
using System.Collections.Generic;

namespace CQRSMediatR.Recursos.Queries
{
    public class GetTodosProdutosQuery : IRequest<IEnumerable<Produto>>
    {
    }
}
