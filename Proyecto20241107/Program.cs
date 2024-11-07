// See https://aka.ms/new-console-template for more information
using Proyecto20241107.modelos;
using Proyecto20241107.servicios;


Console.WriteLine("Hello, World!");

var envio = new Envio(5, 5, 5, 20, "Avenida Argentina #222, Santiago");
EnvioSrv.Mostrar(envio);
Console.WriteLine("El volumen es :" + EnvioSrv.Volumen(envio));
Console.WriteLine("El precio $:" + EnvioSrv.PrecioEnvio(envio));
