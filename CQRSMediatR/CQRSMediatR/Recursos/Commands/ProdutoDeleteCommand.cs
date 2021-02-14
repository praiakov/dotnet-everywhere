using CQRSMediatR.Models;
using MediatR;

namespace CQRSMediatR.Recursos.Commands
{
    public class ProdutoDeleteCommand : IRequest<Produto>
    {
        public int Id { get; set; }
    }
}
