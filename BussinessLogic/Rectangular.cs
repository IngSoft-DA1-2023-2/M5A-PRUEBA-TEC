// See https://aka.ms/new-console-template for more information

namespace BusinessLogic;

public  class Rectangular{


     private float _largo;
     private float _ancho;

    public Rectangular (float largo, float ancho){
        _largo = largo;
        _ancho = ancho;
    }

    public float calcularArea (){

        return _largo * _ancho;

    }

}

