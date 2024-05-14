namespace PruebaTecnologia.Test;

[TestClass]
public class MaterialTest
{
    [TestMethod]
    public void CreateMaterial()
    {
        string tipo = "Ceramica";
        float precio = 10;
        Material material = new Material(tipo,precio);
        Assert.AreEqual(tipo,material.TipoMaterial);
        Assert.AreEqual(precio,material.PrecioMaterial);
    }
   [TestMethod]
   public void SetTipoMaterial()
   {
       string tipo = "Ceramica";
       float precio = 10;
       Material material = new Material(tipo,precio);
       material.TipoMaterial = "Marmol";
       Assert.AreEqual("Marmol",material.TipoMaterial);
   }
   [TestMethod]
   public void SetPrecioMaterial()
   {
       string tipo = "Ceramica";
       float precio = 10;
       Material material = new Material(tipo,precio);
       material.PrecioMaterial = 20;
       Assert.AreEqual(20,material.PrecioMaterial);
   }
    
    
}