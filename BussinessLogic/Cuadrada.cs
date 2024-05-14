// See https://aka.ms/new-console-template for more information

namespace BusinessLogic;

public class Cuadrada{


     private float _largo;
   

    public Cuadrada (float largo){
        _largo = largo;
     
    }

    public float calcularArea (){

        return _largo * _largo;

    }

}

