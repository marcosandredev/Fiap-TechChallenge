using AutoMapper;
using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Domain.Exceptions;
using CBF.Infra.Repositories;
using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Service.Services
{
    public class EstatisticaService : IEstatisticaService
    {
        private readonly IEstatisticaJogadorClubeRepository _estatisticaJogadorClubeRepository;
        private readonly IEstatisticaJogadorRepository _estatisticaJogadorRepository;
        private readonly IMapper _mapper;

        public EstatisticaService(IEstatisticaJogadorClubeRepository estatisticaJogadorClubeRepository,
            IEstatisticaJogadorRepository estatisticaJogadorRepository,
            IMapper mapper)
        {
            _estatisticaJogadorClubeRepository = estatisticaJogadorClubeRepository;
            _estatisticaJogadorRepository = estatisticaJogadorRepository;
            _mapper = mapper;
        }

        public async Task<EstatisticaJogadorResponse> CadastrarEstatisticaAsync(EstatisticaJogadorRequest request)
        {
            var estatistica = _mapper.Map<EstatisticaJogador>(request);

            var model = await _estatisticaJogadorRepository.AddAsync(estatistica);

            return _mapper.Map<EstatisticaJogadorResponse>(model);
        }

        public async Task<EstatisticaJogadorResponse> CadastrarEstatisticaJogadorAsync(EstatisticaJogadorRequest request)
        {
            var estatistica = _mapper.Map<EstatisticaJogador>(request);

            var model = await _estatisticaJogadorRepository.AddAsync(estatistica);

            return _mapper.Map<EstatisticaJogadorResponse>(model);
        }


        public async Task<EstatisticaJogadorClubeResponse> CadastrarEstatisticaJogadorClubeAsync(EstatisticaJogadorClubeRequest request)
        {
            var estatistica = _mapper.Map<EstatisticaJogadorClube>(request);

            var model = await _estatisticaJogadorClubeRepository.AddAsync(estatistica);

            return _mapper.Map<EstatisticaJogadorClubeResponse>(model);
        }

        public async Task<IEnumerable<EstatisticaClubeResponse>> GetEstatisticasClubesTemporada(EstatisticasClubesRequest request)
        {
            var result = await _estatisticaJogadorRepository.GetEstatisticasClubesTemporada(request);

            return result;
        }

        public async Task<IEnumerable<EstatisticaResponse>> GetJogadoresAmarelosAsync(long idTemporada)
        {
            var result = await _estatisticaJogadorRepository.GetJogadorAmarelosAsync(idTemporada);

            return result;
        }

        public async Task<IEnumerable<EstatisticaResponse>> GetJogadoresAssistenciasAsync(long idTemporada)
        {
            var result = await _estatisticaJogadorRepository.GetJogadorAssistenciasAsync(idTemporada);

            return result;
        }

        public async Task<IEnumerable<EstatisticaResponse>> GetJogadoresGolsAsync(long idTemporada)
        {
            var result = await _estatisticaJogadorRepository.GetJogadorGolsAsync(idTemporada);

            return result;
        }

        public async Task<IEnumerable<EstatisticaResponse>> GetJogadoresPartidasAsync(long idTemporada)
        {
            var result = await _estatisticaJogadorRepository.GetJogadorPartidasAsync(idTemporada);

            return result;
        }

        public async Task<IEnumerable<EstatisticaResponse>> GetJogadoresVermelhosAsync(long idTemporada)
        {
            var result = await _estatisticaJogadorRepository.GetJogadorVermelhosAsync(idTemporada);

            return result;
        }

    }
}
