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
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public string Gender { get; set; }
        [Display(Name = "Cnh")]
        public string CnhClass { get; set; }
        [Required]
        [Display(Name = "Data de nascimento")]
        public string BirthDate { get; set; }
        [Display(Name = "Dependentes")]
        public string Dependentes { get; set; }
        [Required]
        [Display(Name = "Estado Civil")]
        public string Maritalstatu { get; set; }
        [Display(Name = "Celular")]
        public string CellPhone { get; set; }
        [Required]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Endereço")]
        public string Adress { get; set; }
        [Required]
        [Display(Name = "Cidade")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public string State { get; set; }
        #endregion
    }
    #endregion
}