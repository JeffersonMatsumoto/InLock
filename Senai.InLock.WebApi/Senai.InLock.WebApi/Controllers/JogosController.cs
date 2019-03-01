using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using Senai.InLock.WebApi.Repositories;

namespace Senai.InLock.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        private IJogoRepository JogoRepository { get; set; }

        public JogosController()
        {
            JogoRepository = new JogoRepository();
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [Route("cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar(JogoDomain jogo)
        {
            try
            {
                JogoRepository.Cadastrar(jogo);
                return Ok(new
                {
                    mensagem = "Jogo Cadastrado"
                });
            }
            catch (Exception ex)
            {
                return BadRequest()
;            }
        }
        
    }
}

/*
{
	"JogoId": 4,
	"NomeJogo": "JogoTeste",
	"Descricao": "DescricaoJogo",
	"DataLancamento":"11/11/2019",
	"Valor": "1,00",
	"Estudio": {
		"EstudioId": 4,
		"NomeEstudio": "EstudioTeste"
	}
}
*/