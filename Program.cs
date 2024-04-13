using Clase_13_de_abril.Clase_hija;

{
    Nintendo sw = new Nintendo();

    sw.Esportatil = true;
    sw.anioLanzamiento = 2017;
    sw.Marca = "Nintendo Switch";

    string resultado = sw.MostrarDetallesNintendo();
    Console.WriteLine(resultado);
}


{
    PlayStation ps = new PlayStation();

    ps.ModeloControlador = "2015";
    ps.anioLanzamiento = 2013;
    ps.Marca = "Play Station 3";

    string resultado2 = ps.MostrarDetallesPS();
    Console.WriteLine(resultado2);
}


{
    Xbox xb = new Xbox();

    xb.GamePass = true;
    xb.anioLanzamiento = 2018;
    xb.Marca = "Xbox One";

    string resultado3 = xb.MostrarDetallesXbox();
    Console.WriteLine(resultado3);
}

