using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Model
{

    //Ejer 7: RESPONDIENDO A LA PREGUNTA ABAJO

    //Es innecesario crear un servicio, ya que los virus no están almacenados en una lista, si no que están separados entre clases y solo se comparan segun el caso que sea.

    public class Ebola : Virus
    {

        public override string Name => "Ebola";

    }
}
