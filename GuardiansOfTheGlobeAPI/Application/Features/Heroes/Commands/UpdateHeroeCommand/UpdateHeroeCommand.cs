using Application.Interface;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Heroes.Commands.UpdateHeroeCommand
{
    public class UpdateHeroeCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public string NombreSuper { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Sexo { get; set; } = string.Empty;
        public string Habilidades { get; set; } = string.Empty;
        public string Debilidades { get; set; } = string.Empty;
        public string RelacionesPersonales { get; set; } = string.Empty;
        public int PatrocinadorId { get; set; }

    }
    public class UpdateHeroeCommandHandler : IRequestHandler<UpdateHeroeCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Heroe> _repositoryAsync;
 
        
        public UpdateHeroeCommandHandler(IRepositoryAsync<Heroe> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
            
        }

        public async Task<Response<int>> Handle(UpdateHeroeCommand request, CancellationToken cancellationToken)
        {
            var heroe = await _repositoryAsync.GetByIdAsync(request.Id);
            
            if (heroe == null)
            {
                throw new KeyNotFoundException($"No se ha encontrado el héroe con el Id {request.Id}");
            }
            else
            {
                heroe.Nombre = request.Nombre;
                heroe.NombreSuper = request.NombreSuper;
                heroe.Edad = request.Edad;  
                heroe.Sexo = request.Sexo;
                heroe.Habilidades = request.Habilidades;
                heroe.Debilidades = request.Debilidades;
                heroe.RelacionesPersonales = request.RelacionesPersonales; 
                heroe.PatrocinadorId  = request.PatrocinadorId;

                await _repositoryAsync.UpdateAsync(heroe);

                return new Response<int>(heroe.Id);
            }
        }
    }
}
