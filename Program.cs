using etapa5Aula1;

class TestClass {

    static void Main(String[] args)
    {


        //Veiculo v = new Veiculo(); //Classe abstrata não pode ser instanciada

        // Console.WriteLine(v.TipoCombustivel);

        Carro c = new Carro("gasolina");
        Aviao v = new Aviao("gasolina");
        
        Console.ReadKey();
    }



}

