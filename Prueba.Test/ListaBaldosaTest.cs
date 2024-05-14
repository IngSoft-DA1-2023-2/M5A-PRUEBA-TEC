namespace Prueba.Test;
[TestClass]
public class ListaBaldosaTest
{
    [TestMethod]
    public void CreateListaBaldosaTest()
    {
        var listaBaldosa = new ListaBaldosa();

        Assert.IsNotNull(listaBaldosa);
    }
    
    [TestMethod]
    public void AddBladosaTest()
    {
        var listaBaldosa = new ListaBaldosa();
        var forma = Forma.Cuadrado;
        var materialPrecio = new MaterialPrecio(Material.Ceramica, 10);;
        var baldosa = new Baldosa(forma, materialPrecio);
        listaBaldosa.AddBaldosa(baldosa);
        Assert.IsTrue(listaBaldosa.Baldosas.Contains(baldosa));
       
    }
}