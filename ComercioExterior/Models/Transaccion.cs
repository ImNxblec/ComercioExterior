using System;
using System.Collections.Generic;

namespace ComercioExterior.Models;

public partial class Transaccion
{
    public int Id { get; set; }

    public string? TipoTransaccion { get; set; }

    public int? IdCliente { get; set; }

    public int? IdPuerto { get; set; }

    public decimal? Costo { get; set; }

    public string? Comentarios { get; set; }

    public string? Estado { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Puerto? IdPuertoNavigation { get; set; }
}
