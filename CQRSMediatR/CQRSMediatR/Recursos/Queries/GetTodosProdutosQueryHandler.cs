using CQRSMediatR.Context;
using CQRSMediatR.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatR.Recursos.Queries
{
    public class GetTodosProdutosQueryHandler : IRequestHandler<GetTodosProdutosQuery, IEnumerable<Produto>>
    {
        private readonly AppDbContext _context;

        public GetTodosProdutosQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> Handle(GetTodosProdutosQuery request, CancellationToken cancellationToken)
        {
            return await _context.Produtos.ToListAsync();
        }
    }
}
