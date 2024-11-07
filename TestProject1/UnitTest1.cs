using NUnit.Framework.Legacy;
using Proyecto20241107.modelos;
using Proyecto20241107.servicios;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestVolumen()
        {
            var envio1 = new Envio(2, 2, 2, 5, "sunset blv");
            ClassicAssert.AreEqual(8, EnvioSrv.Volumen(envio1));         
        }
        [Test]
        public void TestPrecio()
        {
            var envio1 = new Envio(2, 2, 2, 5, "sunset blv");
            ClassicAssert.AreEqual(92, EnvioSrv.PrecioEnvio(envio1));
        }
        [Test]
        public void TestCorrecto()
        {
            var envio1 = new Envio(2, 2, 2, 5, "sunset blv");
            ClassicAssert.AreEqual(true, EnvioSrv.Correcto(envio1));
            var envio2 = new Envio(-2, 2, 2, 5, "sunset blv");
            ClassicAssert.AreEqual(false, EnvioSrv.Correcto(envio2));
        }
        [Test]
        public void TestMostrar()
        {
            var envio1 = new Envio(2, 2, 2, 5, "sunset blv");
            EnvioSrv.Mostrar(envio1);
        }
    }
}
