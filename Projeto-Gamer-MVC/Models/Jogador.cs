using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Gamer_MVC.Models
{
    public class Jogador
    {
        [Key]
        public int IdJogador { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }


        //referenciando e dizendo qual a classe
        [ForeignKey("Equipe")]
        public int IdEquipe { get; set; }
        
        
        public Equipe? Equipe {get;set;}
        
        
        
    }
}