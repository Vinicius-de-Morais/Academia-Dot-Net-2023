using System;
using System.Collections.Generic;

namespace aula31;

public partial class Emails2
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public int? FkPessoa { get; set; }

    public virtual Pessoa? FkPessoaNavigation { get; set; }
}
