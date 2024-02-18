using Abstract;

class Program
{
    public static void Main()
    {
        //создаем экземпляры национальностей
        Russian r1 = new Russian("Слава","Накул","Игоревич");
        Moldavian m1 = new Moldavian("Слава", "Накул", "Игоревич");
        Englishman e1 = new Englishman("Jo", "Jo", "Gambit");


        //выводим информацию и приветствие
        r1.Inf();
        r1.Greetings();

        m1.Inf();
        m1.Greetings();

        e1.Inf();
        e1.Greetings();
    } 
}