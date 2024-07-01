using Application.Models;
using System.Globalization;

namespace Application.Util
{
    public class CalculoCotizacion
    {
        private const decimal PORCENTAJEVEHICULO = 0.0009M;
        public static decimal CalcularCotizacion(ObjetoParametrizado objetonParametrizado)
        {
            var precioBase = objetonParametrizado.version.PrecioBase;

            var test = decimal.Parse(objetonParametrizado.gnc.Peso, CultureInfo.InvariantCulture);

            decimal valorCrudoVehiculo = (precioBase * PORCENTAJEVEHICULO)
                + (precioBase * decimal.Parse(objetonParametrizado.gnc.Peso, CultureInfo.InvariantCulture)) 
                + (precioBase * decimal.Parse(objetonParametrizado.localidad.Peso, CultureInfo.InvariantCulture)) 
                + (precioBase * decimal.Parse(objetonParametrizado.rangoEtario.Peso, CultureInfo.InvariantCulture))
                + (precioBase * decimal.Parse(objetonParametrizado.anioVehiculo.Peso, CultureInfo.InvariantCulture));

            return valorCrudoVehiculo;
        }
    }
}
