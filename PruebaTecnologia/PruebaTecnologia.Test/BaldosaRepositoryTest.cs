namespace PruebaTecnologia.Test;

[TestClass]
public class BaldosaRepositoryTest
{
    [TestMethod]
    public void AddBaldosa()
    {
        Material material = new Material("Ceramica",10);
        var baldosa = new Baldosa(Forma.Cuadrado,material);
        var baldosaRepository = new BaldosaRepository();
        
     
        baldosaRepository.AddBaldosa(baldosa);
        
        Assert.AreEqual(1, baldosaRepository.Baldosas.Count);
    }
    
}