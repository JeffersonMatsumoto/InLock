using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    public class JogoDomain
    {
        public int JogoId { get; set; }

        [Required(ErrorMessage = "Informe o nome do jogo")]
        public string NomeJogo { get; set; }

        [Required(ErrorMessage = "Informe a descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Informe o valor")]
        public decimal Valor { get; set; }

        public EstudioDomain Estudio { get; set; }

        public int EstudioId { get; set; }
    }
}
