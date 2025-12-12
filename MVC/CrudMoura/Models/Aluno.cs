using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrudMoura.Models;

[Table("Aluno")]
public partial class Aluno
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Sobrenome { get; set; } = null!;

    public int Idade { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? Cpf { get; set; }
}
