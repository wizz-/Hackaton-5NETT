﻿using Application.Services.Cadastros.Dtos;

namespace Application.Services.Cadastros.Interfaces
{
    public interface ICadastroAppService
    {
        void CadastrarPaciente(PacienteDto dto);
        void CadastrarMedico(MedicoDto dto);
        void CadastrarHorariosDisponiveis(int medicoId, EspecialidadeDto especialidadeDto, decimal valorDaConsulta, IList<HorarioDisponivelDto> horarioDisponivelDto);
    }
}
