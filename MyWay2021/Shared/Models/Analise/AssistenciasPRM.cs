﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWay2021.Shared.Models.Analise
{
    [Table("AssistenciasPRMS")]
    public class AssistenciasPRM : IBaseEntity
    {
        [Key]
        public Guid ID { get; set; }
        public Guid UhID { get; set; }
        [Display(Name = "Aeroporto:")]
        public string Aeroporto { get; set; }
        [Display(Name = "Mensagem:")]
        public string Msg { get; set; }
        [Display(Name = "Notificação:")]
        public string Notif { get; set; }
        [Required]
        [Display(Name = "Data:")]
        public DateTime Data { get; set; }
        [Required]
        [Display(Name = "Voo:")]
        public string Voo { get; set; }
        [Display(Name = "Movimento:")]
        public string Mov { get; set; }
        [Display(Name = "Origem/Destino:")]
        public string OrigDest { get; set; }
        [Required]
        [Display(Name = "Passageiro:")]
        public string Pax { get; set; }
        [Display(Name = "Serviçe Request:")]
        public string SSR { get; set; }
        [Display(Name = "Aeronave:")]
        public string AC { get; set; }
        [Display(Name = "Stand:")]
        public string Stand { get; set; }
        [Display(Name = "Saída:")]
        public string Exit { get; set; }
        [Display(Name = "Check-in:")]
        public string CkIn { get; set; }
        [Display(Name = "Porta:")]
        public string Gate { get; set; }
        [Display(Name = "Transferênçia:")]
        public string Transferencia { get; set; }
        [Display(Name = "Hora de embarque:")]
        public DateTime HoraEmbarque { get; set; }
        [Display(Name = "Saída da Staging Area:")]
        public DateTime SaidaStaging { get; set; }
        [Display(Name = "Estimativa de apresentação:")]
        public DateTime EstimaApresentacao { get; set; }

        #region BaseEntity
        [Display(Name = "Registo criado em:", ShortName = "Criado em:")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "Registo criado por:", ShortName = "Criado por:")]
        public string CreatedBy { get; set; }
        [Display(Name = "Registo atualizado em:", ShortName = "Atualizado em:")]
        public DateTime? LastUpdatedAt { get; set; }
        [Display(Name = "Registo atualizado por:", ShortName = "Atualizado por:")]
        public string LastUpdatedBy { get; set; }
        #endregion
    }
}
