using System;
using System.Collections.Generic;

namespace aula31;

public partial class Email
{
    public int Id { get; set; }

    public int Pessoaid { get; set; }

    public string Email1 { get; set; } = null!;

    public virtual Pessoa Pessoa { get; set; } = null!;
}
