using System;
using System.Collections.Generic;

namespace aula31;

public partial class Pessoa
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();

    public virtual ICollection<Emails2> Emails2s { get; set; } = new List<Emails2>();
}
