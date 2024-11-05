using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RCTENNIS.Dados
{
    [Table("TAB_EMPRESA")]
    public class TAB_EMPRESA
    {
        [Key]
        public int EMP_ID { get; set; }
        public string? EMP_NOME { get; set; }
        public string? EMP_RAZAO_SOCIAL { get; set; }  
        public string? EMP_CNPJ { get; set; }
        public string? EMP_INSC_ESTADUAL { get; set; }
        public string? EMP_CEP { get; set; }
        public string? EMP_ENDERECO { get; set; }
        public string? EMP_NUMERO_ENDERECO { get; set; }
        public string? EMP_COMPLEMENTO {  get; set; }
        public string? EMP_BAIRRO { get; set; }
        public string? EMP_CIDADE { get; set; }
        public string? EMP_UF {  get; set; }        
        public string? EMP_TELEFONE_1 { get; set; }
        public string? EMP_TELEFONE_2 { get; set; }
        public string? EMP_EMAIL { get; set; }
        public string? EMP_SITE { get; set; }
        public string? EMP_LINKEDIN { get; set; }
        public string? EMP_INSTAGRAM { get; set; }
        public string? EMP_FACEBOOK { get; set; }
        public DateTime EMP_DATA_VCTO_DAS { get; set; }
        public decimal EMP_VALOR_DAS { get; set; }
        public DateTime EMP_DATA_CADASTRO { get; set; }
        public DateTime EMP_DATA_ATUALIZACAO { get; set; }

    }

}



    