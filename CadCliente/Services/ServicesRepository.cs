using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadCliente.Services
{
    public class ServicesRepository
    {
        public static List<ServicesRepositoryListModel> ListaSexo()
        {
            return new()
            {
                new ServicesRepositoryListModel { Value = "M", Text = "M - Masculino" },
                new ServicesRepositoryListModel { Value = "F", Text = "F - Feminino" },
                new ServicesRepositoryListModel { Value = "N", Text = "S - Sem Genero" }
            };
        }

        public static List<ServicesRepositoryListModel> ListaUf()
        {
            return new()
            {
                new ServicesRepositoryListModel { Value = "AC", Text = "AC - Acre" },
                new ServicesRepositoryListModel { Value = "AL", Text = "AL - Alagoas" },
                new ServicesRepositoryListModel { Value = "AP", Text = "AP - Amapá" },
                new ServicesRepositoryListModel { Value = "AM", Text = "AM - Amazonas" },
                new ServicesRepositoryListModel { Value = "BA", Text = "BA - Bahia" },
                new ServicesRepositoryListModel { Value = "CE", Text = "CE - Ceará" },
                new ServicesRepositoryListModel { Value = "DF", Text = "DF - Distrito Federal" },
                new ServicesRepositoryListModel { Value = "ES", Text = "ES - Espírito Santo" },
                new ServicesRepositoryListModel { Value = "GO", Text = "GO - Goiás" },
                new ServicesRepositoryListModel { Value = "MA", Text = "MA - Maranhão" },
                new ServicesRepositoryListModel { Value = "MT", Text = "MT - Mato Grosso" },
                new ServicesRepositoryListModel { Value = "MS", Text = "MS - Mato Grosso do Sul" },
                new ServicesRepositoryListModel { Value = "MG", Text = "MG - Minas Gerais" },
                new ServicesRepositoryListModel { Value = "PA", Text = "PA - Pará" },
                new ServicesRepositoryListModel { Value = "PB", Text = "PB - Paraíba" },
                new ServicesRepositoryListModel { Value = "PR", Text = "PR - Paraná" },
                new ServicesRepositoryListModel { Value = "PE", Text = "PE - Pernambuco" },
                new ServicesRepositoryListModel { Value = "PI", Text = "PI - Piauí" },
                new ServicesRepositoryListModel { Value = "RJ", Text = "RJ - Rio de Janeiro" },
                new ServicesRepositoryListModel { Value = "RN", Text = "RN - Rio Grande do Norte" },
                new ServicesRepositoryListModel { Value = "RS", Text = "RS - Rio Grande do Sul" },
                new ServicesRepositoryListModel { Value = "RO", Text = "RO - Rondônia" },
                new ServicesRepositoryListModel { Value = "RR", Text = "RR - Roraima" },
                new ServicesRepositoryListModel { Value = "SC", Text = "SC - Santa Catarina" },
                new ServicesRepositoryListModel { Value = "SP", Text = "SP - São Paulo" },
                new ServicesRepositoryListModel { Value = "SE", Text = "SE - Sergipe" },
                new ServicesRepositoryListModel { Value = "TO", Text = "TO - Tocantins" }
            };
        }
    }

    public class ServicesRepositoryListModel
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
