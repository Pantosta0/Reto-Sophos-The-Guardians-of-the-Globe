using Application.Interface;
using Application.Wrappers;
using Domain.Entities;
using MediatR;

namespace Application.Features.Heroes.Commands.DeleteHeroeCommand
{
    public class DeleteHeroeCommand : IRequest<Response<int>>
    {
        public int Id { get; set;}
    }
    public class DeleteHeroeCommandHandler : IRequestHandler<DeleteHeroeCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Heroe> _repositoryAsync;

        public DeleteHeroeCommandHandler(IRepositoryAsync<Heroe> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(DeleteHeroeCommand request, CancellationToken cancellationToken)
        {
            var heroe = await _repositoryAsync.GetByIdAsync(request.Id);

            if (heroe == null)
            {
                throw new KeyNotFoundException($"No se ha encontrado el héroe con el Id {request.Id}");
            }
            else
            {
                await _repositoryAsync.DeleteAsync(heroe);

                return new  Response<int>(heroe.Id);
            }   
        }
    }
}
