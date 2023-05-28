using Application.Interface;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Heroes.Commands.CreateHeroeCommand
{
    public class CreateHeroeCommand : IRequest<Response<int>>
    {
        public string NombreSuper { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Sexo { get; set; } = string.Empty;
        public string Habilidades { get; set; } = string.Empty;
        public string Debilidades { get; set; } = string.Empty;
        public string RelacionesPersonales { get; set; } = string.Empty;
        public int PatrocinadorId { get; set; }
        
    }
    public class CreateHeroesCommandHandler : IRequestHandler<CreateHeroeCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Heroe> _repositoryAsync;
        private readonly IMapper _mapper;
        
        public CreateHeroesCommandHandler(IRepositoryAsync<Heroe> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }
        public async Task<Response<int>> Handle(CreateHeroeCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<Heroe>(request);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);

            return new Response<int>(data.Id);
        }
    }
}
