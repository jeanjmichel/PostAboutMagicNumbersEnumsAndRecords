namespace MagicNumbers;
public record DDDCapitaisRecord(int DDD, string Nome)
{
    public static DDDCapitaisRecord SAO_PAULO { get; } = new(11, "São Paulo");
    public static DDDCapitaisRecord RIO_DE_JANEIRO { get; } = new(21, "Rio de Janeiro");
    public static DDDCapitaisRecord VITORIA { get; } = new(27, "Vitória");
    public static DDDCapitaisRecord BELO_HORIZONTE { get; } = new(31, "Belo Horizonte");
    public static DDDCapitaisRecord CURITIBA { get; } = new(41, "Curitiba");
    public static DDDCapitaisRecord FLORIANOPOLIS { get; } = new(48, "Florianópolis");
    public static DDDCapitaisRecord PORTO_ALEGRE { get; } = new(51, "Porto Alegre");
    public static DDDCapitaisRecord BRASILIA { get; } = new(61, "Brasília");
    public static DDDCapitaisRecord GOIANIA { get; } = new(62, "Goiânia");
    public static DDDCapitaisRecord PALMAS { get; } = new(63, "Palmas");
    public static DDDCapitaisRecord CUIABA { get; } = new(65, "Cuiabá");
    public static DDDCapitaisRecord CAMPO_GRANDE { get; } = new(67, "Campo Grande");
    public static DDDCapitaisRecord RIO_BRANCO { get; } = new(68, "Rio Branco");
    public static DDDCapitaisRecord PORTO_VELHO { get; } = new(69, "Porto Velho");
    public static DDDCapitaisRecord SALVADOR { get; } = new(71, "Salvador");
    public static DDDCapitaisRecord ARACAJU { get; } = new(79, "Aracaju");
    public static DDDCapitaisRecord RECIFE { get; } = new(81, "Recife");
    public static DDDCapitaisRecord MACEIO { get; } = new(82, "Maceió");
    public static DDDCapitaisRecord JOAO_PESSOA { get; } = new(83, "João Pessoa");
    public static DDDCapitaisRecord NATAL { get; } = new(84, "Natal");
    public static DDDCapitaisRecord FORTALEZA { get; } = new(85, "Fortaleza");
    public static DDDCapitaisRecord TERESINA { get; } = new(86, "Teresina");
    public static DDDCapitaisRecord BELEM { get; } = new(91, "Belém");
    public static DDDCapitaisRecord MANAUS { get; } = new(92, "Manaus");
    public static DDDCapitaisRecord BOA_VISTA { get; } = new(95, "Boa Vista");
    public static DDDCapitaisRecord MACAPA { get; } = new(96, "Macapá");
    public static DDDCapitaisRecord SAO_LUIS { get; } = new(98, "São Luís");

    public string RegiaoDDD(int DDD)
    {
        switch (DDD)
        {
            case int n when (n == 63) || (n >= 68 && n <= 69) || (n >= 91 && n <= 97):
                return "Norte";
            case int n when (n >= 41 && n <= 51) || (n >= 53 && n <= 55):
                return "Sul";
            case int n when (n >= 11 && n <= 19) || (n == 21) || (n == 22) || (n == 24) || (n == 27) || (n == 28) || (n >= 31 && n <= 35) || (n == 37) || (n == 38):
                return "Sudeste";
            case int n when (n == 61) || (n == 62) || (n >= 64 && n <= 67):
                return "Centro-Oeste";
            case int n when (n == 71) || (n >= 73 && n <= 75) || (n == 77) || (n == 79) || (n >= 81 && n <= 89) || (n == 98) || (n == 99):
                return "Nordeste";
            default:
                return "Desconhecida/Inválida";
        }
    }

    public static implicit operator int(DDDCapitaisRecord DDD) => DDD.DDD;

    public static implicit operator DDDCapitaisRecord(int DDD) => RetornarEntradaValidaOuExcecao(DDD);

    private static DDDCapitaisRecord RetornarEntradaValidaOuExcecao(int DDD) =>
    DDD switch
    {
        11 => SAO_PAULO,
        21 => RIO_DE_JANEIRO,
        27 => VITORIA,
        31 => BELO_HORIZONTE,
        41 => CURITIBA,
        48 => FLORIANOPOLIS,
        51 => PORTO_ALEGRE,
        61 => BRASILIA,
        62 => GOIANIA,
        63 => PALMAS,
        65 => CUIABA,
        67 => CAMPO_GRANDE,
        68 => RIO_BRANCO,
        69 => PORTO_VELHO,
        71 => SALVADOR,
        79 => ARACAJU,
        81 => RECIFE,
        82 => MACEIO,
        83 => JOAO_PESSOA,
        84 => NATAL,
        85 => FORTALEZA,
        86 => TERESINA,
        91 => BELEM,
        92 => MANAUS,
        95 => BOA_VISTA,
        96 => MACAPA,
        98 => SAO_LUIS,
        _ => throw new Exception($"O DDD {DDD} não é de uma capital brasileira.")
    };

    public override string ToString() => $"Capital {Nome} DDD {DDD}";
}