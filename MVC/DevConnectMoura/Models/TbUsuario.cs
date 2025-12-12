using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_usuario")]
[Index("Email", Name = "UQ__tb_usuar__AB6E6164E8D8079D", IsUnique = true)]
[Index("NomeUsuario", Name = "UQ__tb_usuar__CCB80B0A98079463", IsUnique = true)]
public partial class TbUsuario
{
    [Key]
    [Column("ID_Usuario")]
    public int IdUsuario { get; set; }

    [Column("nome_completo")]
    [StringLength(255)]
    public string NomeCompleto { get; set; } = null!;

    [Column("nome_usuario")]
    [StringLength(55)]
    public string NomeUsuario { get; set; } = null!;

    [Column("email")]
    [StringLength(155)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(50)]
    public string Senha { get; set; } = null!;

    [Column("foto_perfl_url")]
    [StringLength(150)]
    public string? FotoPerflUrl { get; set; }

    [InverseProperty("Usuario")]
    public virtual ICollection<Comentario> Comentario { get; set; } = new List<Comentario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbCurtidas> TbCurtidas { get; set; } = new List<TbCurtidas>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbPubli> TbPubli { get; set; } = new List<TbPubli>();

    [ForeignKey("IdUsuarioSeguidor")]
    [InverseProperty("IdUsuarioSeguidor")]
    public virtual ICollection<TbUsuario> IdUsuarioSeguido { get; set; } = new List<TbUsuario>();

    [ForeignKey("IdUsuarioSeguido")]
    [InverseProperty("IdUsuarioSeguido")]
    public virtual ICollection<TbUsuario> IdUsuarioSeguidor { get; set; } = new List<TbUsuario>();
}
