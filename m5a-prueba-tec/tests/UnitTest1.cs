using m5a_prueba_tec;
using m5a_prueba_tec.Formas;
using m5a_prueba_tec.Materiales;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize] public void Init()
        {

        }

        [TestMethod]
        public void Deberia_poder_crear_Cuadrado()
        {
            Cuadrado square = new(3);
            Assert.IsNotNull(square);
        }

        public void Deberia_poder_crear_triangulo()
        {
            Triangulo triangulo = new(2.0,2.0);
            Assert.IsNotNull(triangulo);
        }

        public void Deberia_poder_crear_Circulo()
        {
            Circulo circ = new(1.0);
            Assert.IsNotNull(circ);
        }

        [TestMethod]
        public void Deberia_poder_crear_ceramica()
        {
            Ceramica cer = new(3);
            Assert.IsNotNull(cer);
        }

        [TestMethod]
        public void Deberia_poder_crear_porcelana()
        {
            Ceramica cer = new(3);
            Assert.IsNotNull(cer);
        }

        [TestMethod]
        public void Deberia_poder_crear_piedra()
        {
            Piedra piedra = new(3);
            Assert.IsNotNull(piedra);
        }




        [TestMethod]
        public void Deberia_Poder_Crear_baldosa_Cuadrada_Ceramica()
        {

            Baldosa b = new Baldosa(new Cuadrado(3), new Ceramica(3));

            Assert.IsNotNull(b);
        }

        [TestMethod]
        public void Deberia_calcular_correctamente_el_costo()
        {
            //Arrange
            Baldosa b = new(new Cuadrado(3.0), new Ceramica(3.0));

            //Act
            double esperado = 27.0;
            double actual = b.CalcularPrecio();

            //Assert
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void deberia_obtener_area_total()
        {
            //Arrange 
            Baldosa baldosa1 = new(new Cuadrado(3.0), new Ceramica(3.0));
            Baldosa baldosa2 = new(new Triangulo(2.0,2.0), new Porcelana(3.0));
            Baldosa baldosa3 = new(new Cuadrado(1.0), new Ceramica(3.0));
            List<Baldosa> baldosas = new()
            {
                baldosa1,
                baldosa2,
                baldosa3
            };

            //Act
            double resultado = Baldoseria.CalcularAreaTotal(baldosas);
            double esperado = 12.0;

            //Assert
            Assert.AreEqual(esperado,resultado);
        }

        [TestMethod]
        public void deberia_obtener_costo_total()
        {
            //Arrange 
            Baldosa baldosa1 = new(new Cuadrado(1.0), new Ceramica(3.0));
            Baldosa baldosa2 = new(new Triangulo(2.0, 2.0), new Porcelana(3.0));
            Baldosa baldosa3 = new(new Cuadrado(1.0), new Ceramica(4.0));
            List<Baldosa> baldosas = new()
            {
                baldosa1,
                baldosa2,
                baldosa3
            };

            //Act
            double resultado = Baldoseria.CalcularCostoTotal(baldosas);
            double esperado = 13.0;

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}