using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace go_horse_voos_comerciais.Domain.Voo;
[Table("voos")]
public class Voo 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }

    [Column("id_origem")]
    public long IdOrigem { get; set; }

    [Column("id_destino")]
    public long IdDestino { get; set; }

    [Column("data_ida")]
    public DateTime DataIda { get; set; }

    [Column("data_volta")]
    public DateTime DataVolta { get; set; }

    [Column("id_companhia_operante")]
    public long IdCompanhiaOperante { get; set; }

    [Column("preco")]
    public double Preco { get; set; }

    [Column("quantiade_assentos")]
    public int QuantidadeAssentos { get; set; }

    public Voo() { }

    public Voo (DadosCadastroVooDTO dadosCadastroVooDTO)
    {
        this.IdOrigem = dadosCadastroVooDTO.IdOrigem;
        this.IdDestino = dadosCadastroVooDTO .IdDestino;
        this.DataIda = dadosCadastroVooDTO.DataIda;
        this.DataVolta = dadosCadastroVooDTO.DataVolta;
        this.IdCompanhiaOperante = dadosCadastroVooDTO.IdCompanhiaOperante;
        this.Preco = dadosCadastroVooDTO.Preco;
        this.QuantidadeAssentos = dadosCadastroVooDTO.QuantidadeAssentos;
    }
}