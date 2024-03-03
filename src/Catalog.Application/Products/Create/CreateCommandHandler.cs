using FluentResults;
using MediatR;

namespace Catalog.Application.Products.Create;

public class CreateCommandHandler : IRequestHandler<CreateCommand, Result<Unit>>
{

    public Task<Result<Unit>> Handle(CreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
