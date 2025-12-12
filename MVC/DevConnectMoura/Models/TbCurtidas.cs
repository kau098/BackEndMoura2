using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_curtidas")]
[Index("IdUsuario", "IdPubli", Name = "UQ__tb_curti__3BE64B8616D0D842", IsUnique = true)]
public partial class TbCurtidas
{
    [Key]
    [Column("ID_Curtidas")]
    public int IdCurtidas { get; set; }

    [Column("ID_Usuario")]
    public int IdUsuario { get; set; }

    [Column("ID_Publi")]
    public int IdPubli { get; set; }

    [ForeignKey("IdPubli")]
    [InverseProperty("TbCurtidas")]
    public virtual TbPubli IdPubliNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbCurtidas")]
    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;
}
