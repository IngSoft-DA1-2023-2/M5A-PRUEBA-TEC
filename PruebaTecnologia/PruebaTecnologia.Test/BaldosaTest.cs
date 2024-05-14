namespace PruebaTecnologia.Test;

[TestClass]
public class BaldosaTest
{
    [TestMethod]
    public void CreateBaldosaWithParameters()
    {
        Forma forma = Forma.Cuadrado;
        string tipoMaterial = "Ceramica";
        float precioMaterial = 10;
        Material material = new Material(tipoMaterial,precioMaterial);
        Baldosa baldosa = new Baldosa(forma,material);
        Assert.AreEqual(forma,baldosa.Forma);
        Assert.AreEqual(material,baldosa.Material);
    }
    
    [TestMethod]
    public void SetForma()
    {
        Forma forma = Forma.Cuadrado;
        string tipoMaterial = "Ceramica";
        float precioMaterial = 10;
        Material material = new Material(tipoMaterial,precioMaterial);
        Baldosa baldosa = new Baldosa(forma,material);
        baldosa.Forma = Forma.Rectangulo;
        Assert.AreEqual(Forma.Rectangulo,baldosa.Forma);
    }
    [TestMethod]
public void SetMaterial()
    {
        Forma forma = Forma.Cuadrado;
        string tipoMaterial = "Ceramica";
        float precioMaterial = 10;
        Material material = new Material(tipoMaterial,precioMaterial);
        Baldosa baldosa = new Baldosa(forma,material);
        string tipoMaterial2 = "Marmol";
        float precioMaterial2 = 20;
        Material material2 = new Material(tipoMaterial2,precioMaterial2);
        baldosa.Material = material2;
        Assert.AreEqual(material2,baldosa.Material);
    }
[TestMethod]
public void CalcularAreaCuadrado()
    {
        Forma forma = Forma.Cuadrado;
        string tipoMaterial = "Ceramica";
        float precioMaterial = 10;
        Material material = new Material(tipoMaterial,precioMaterial);
        Baldosa baldosa = new Baldosa(forma,material);
        baldosa.CalcularAreaCuadrado(5);
        Assert.AreEqual(25,baldosa.Area);
    }
[TestMethod]
public void CalcularAreaRectangulo()
    {
        Forma forma = Forma.Cuadrado;
        string tipoMaterial = "Ceramica";
        float precioMaterial = 10;
        Material material = new Material(tipoMaterial,precioMaterial);
        Baldosa baldosa = new Baldosa(forma,material);
        baldosa.CalcularAreaRectangulo(5,10);
        Assert.AreEqual(50,baldosa.Area);
    }


    
    

    
    
}