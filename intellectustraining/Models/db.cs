using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace intellectustraining.Models
{
    #region db
    public class db :DbContext
    {

        DbSet<Candidate> Candidates { get; set; }
    }
    #endregion

    #region Tabela Candidato
    public class Candidate
    {
        #region campos do candidato
        [Required]
        [Display(Name = "Nome")]
        string Name { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        string Gender { get; set; }
        [Display(Name = "Cnh")]
        string CnhClass { get; set; }
        [Required]
        [Display(Name = "Data de nascimento")]
        string BirthDate { get; set; }
        [Display(Name = "Dependentes")]
        string Dependentes { get; set; }
        [Required]
        [Display(Name = "Estado Civil")]
        string Maritalstatu { get; set; }
        [Display(Name = "Celular")]
        string CellPhone { get; set; }
        [Required]
        [Display(Name = "Telefone")]
        string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        string Email { get; set; }
        [Required]
        [Display(Name = "Endereço")]
        string Adress { get; set; }
        [Required]
        [Display(Name = "Cidade")]
        string City { get; set; }
        [Required]
        [Display(Name = "Estado")]
        string State { get; set; }
        #endregion
    }
    #endregion
}