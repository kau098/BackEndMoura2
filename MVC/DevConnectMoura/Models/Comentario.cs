using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("comentario")]
public partial class Comentario
{
    [Key]
    public int ComentarioId { get; set; }

    public int UsuarioId { get; set; }

    [Column("ID_Publi")]
    public int IdPubli { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string Texto { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DataComentario { get; set; }

    [ForeignKey("IdPubli")]
    [InverseProperty("Comentario")]
    public virtual TbPubli IdPubliNavigation { get; set; } = null!;

    [ForeignKey("UsuarioId")]
    [InverseProperty("Comentario")]
    public virtual TbUsuario Usuario { get; set; } = null!;
}
