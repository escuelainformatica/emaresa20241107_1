using Proyecto20241107.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto20241107.servicios
{
    public class EnvioSrv
    {
        public static void Mostrar(Envio env)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{env.Direccion} : {env.Alto}x{env.Ancho}x{env.Largo} {env.Peso} kg.");
            Console.WriteLine("----------------------------------------");
        }
        public static int Volumen(Envio env)
        {
            var resultado = 0;
            //todo: pendiente
            resultado = env.Alto * env.Ancho * env.Largo;
            return resultado;
        }
        public static double PrecioEnvio(Envio envio)
        {
            var resultado = 0.0;
            // todo: pendiente precio envio
            resultado = Volumen(envio) * envio.Peso * 2.3;
            return resultado;
        }
        public static bool Correcto(Envio env)
        {
            var resultado = false;
            //todo: pendiente correcto
            if(env.Ancho>0 && env.Alto>0 && env.Largo>0 && env.Peso>0)
            {
                resultado = true;
            }

            return resultado;
        }


    }
}
