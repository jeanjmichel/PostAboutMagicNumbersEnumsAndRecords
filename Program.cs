namespace MagicNumbers;
public class Program
{
    private static void Main(string[] args)
    {
        //Recuperando uma entrada como se estivesse usando uma Enum
        DDDCapitaisRecord DDDPoA = DDDCapitaisRecord.PORTO_ALEGRE;

        //Recuperando o DDD que é um int sem fazer cast!
        int DDDFortaleza = DDDCapitaisRecord.FORTALEZA;

        //Novamente usando o Record como se fosse uma Enum
        DDDCapitaisRecord DDDSampa = 11;

        Console.WriteLine($"O DDD da capital gaúcha é {DDDPoA.DDD}.");
        Console.WriteLine($"A propriedade Nome do record que representa o DDD da capital gaúcha é {DDDPoA.Nome}.");
        Console.WriteLine($"A capital de Santa Catarina é {DDDCapitaisRecord.FLORIANOPOLIS.Nome} e o DDD dela é {DDDCapitaisRecord.FLORIANOPOLIS.DDD}.");
        Console.WriteLine($"O DDD da capital cearense é {DDDFortaleza}.");
        Console.WriteLine($"O DDD {DDDPoA.DDD} é da região {DDDPoA.RegiaoDDD(DDDPoA.DDD)}.");
        Console.WriteLine($"O DDD de {DDDSampa.Nome} é {DDDSampa.DDD}.");
        Console.WriteLine(DDDSampa.ToString());
        Console.WriteLine(DDDSampa);

        try
        {
            DDDCapitaisRecord x = 42;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        int DDDRecife = (int)DDDCapitaisEnum.RECIFE;
        Console.WriteLine(DDDRecife);
    }
}