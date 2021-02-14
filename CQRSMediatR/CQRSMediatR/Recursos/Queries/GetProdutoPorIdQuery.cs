using CQRSMediatR.Models;
using MediatR;

namespace CQRSMediatR.Recursos.Queries
{
    public class GetProdutoPorIdQuery : IRequest<Produto>
    {
        public int Id { get; set; }
    }
}
