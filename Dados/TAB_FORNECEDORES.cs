using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace RCTENNIS.Dados
{
    [Table("TAB_FORNECEDORES")]
    public class TAB_FORNECEDORES
    {
        [Key]
        public int FOR_ID { get; set; }
        public int FOR_MARCA {  get; set; }
        public string? FOR_DISTRIBUIDORA { get; set; }
        public string? FOR_CNPJ { get; set; }
        public string? FOR_INSC_ESTADUAL { get; set; }
        public string? FOR_CEP { get; set; }
        public string? FOR_ENDERECO { get; set; }
        public string? FOR_NUMERO_ENDERECO { get; set; }
        public string? FOR_COMPLEMENTO {  get; set; }
        public string? FOR_BAIRRO { get; set; }
        public string? FOR_CIDADE { get; set; }
        public string? FOR_UF {  get; set; }
        public string? FOR_CONTATO { get; set; }
        public string? FOR_TELEFONE_1 { get; set; }
        public string? FOR_WHATSAPP_1 { get; set; }
        public string? FOR_TELEFONE_2 { get; set; }
        public string? FOR_EMAIL_1 { get; set; }
        public string? FOR_EMAIL_2 { get; set; }
        public string? FOR_SITE { get; set; }
        public string? FOR_INSTAGRAM { get; set; }
        public DateTime FOR_DATA_DACASTRO { get; set; }
        public DateTime FOR_DATA_ATUALIZACAO { get; set; }
    }
}