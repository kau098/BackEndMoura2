using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_publi")]
public partial class TbPubli
{
    [Key]
    [Column("ID_Publi")]
    public int IdPubli { get; set; }

    [Column("descricao")]
    [StringLength(155)]
    public string Descricao { get; set; } = null!;

    [Column("imagem_url")]
    [StringLength(150)]
    public string? ImagemUrl { get; set; }

    [Column("data_publi")]
    public DateOnly DataPubli { get; set; }

    [Column("ID_Usuario")]
    public int? IdUsuario { get; set; }

    [InverseProperty("IdPubliNavigation")]
    public virtual ICollection<Comentario> Comentario { get; set; } = new List<Comentario>();

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbPubli")]
    public virtual TbUsuario? IdUsuarioNavigation { get; set; }

    [InverseProperty("IdPubliNavigation")]
    public virtual ICollection<TbCurtidas> TbCurtidas { get; set; } = new List<TbCurtidas>();
}
