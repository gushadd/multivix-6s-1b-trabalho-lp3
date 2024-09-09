﻿namespace go_horse_voos_comerciais.Domain.Relatorios;

public interface IRelatoriosService
{
    Task<RelatorioOcupacaoDTO> GeraRelatorioOcupacao(DateTime dataInicio, DateTime dataFim);
    //Task<List<RelatorioVendasDTO>> GeraRelatorioVendas(int mes, int ano);
}
