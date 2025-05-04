using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public Producto oProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string IdTransaccion { get; set; }
    }
}
/*
create table detalle_venta(
IdDetalleVenta int primary key identity,
IdVenta int references venta(IdVenta),
IdProducto int references producto(IdProducto),
Cantidad int,
Total decimal(10,2)*/