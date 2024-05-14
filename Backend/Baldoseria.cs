public class Baldoseria{
    public List<Baldosa> baldosas;

    public void AgregarBaldosa(Baldosa baldosa){
        baldosas.Add(baldosa);
    }

    public int CalcularAreaTotal(){
        int ret = 0;
        for(int i=0;i<baldosas.Count();i++){
            ret +=baldosas[i].CalcularArea();
        }
        return ret;
    }
}