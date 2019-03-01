using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.Domains
{
    public class EstudioDomain
    {
        public int EstudioId { get; set; }
        
        [Required(ErrorMessage = "Informe o nome do estúdio")]
        public string NomeEstudio { get; set; }
    }
}
