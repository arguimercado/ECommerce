using Catalog.Domain.Models;
using FluentResults;
using MediatR;

namespace Catalog.Application.Products.Create;

public record CreateCommand(Product Product) : IRequest<Result<Unit>>;


