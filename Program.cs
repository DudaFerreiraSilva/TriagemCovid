int idade;

bool febre, tosse, outroSintomaRespiratorio;
bool faltaAr, aumentoFrequenciaRespiratoria, dorToracica, sensacaoDesmaio;
bool hipertensao, diabetes, outrasDoencasCronicas;
bool doencaCoronariana, doencaCronica;

bool possuiSinalDeAlarme, possuiFatorDeRisco;

bool situacaoGrave;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Clear();
Console.WriteLine("-- Triagem para Covid-19 --");
Console.WriteLine("\nAdaptado de https://www.slmandic.edu.br/tudo-sobre-coronavirus/");
Console.WriteLine("RESULTADO ESTRITAMENTE EDUCACIONAL. PROCURE AJUDA ESPECIALIZADA.\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Qual a idade do paciente? ");
bool idadeNumerica = Int32.TryParse(Console.ReadLine(), out idade);
Console.ResetColor();

if (!idadeNumerica || idade < 0 || idade > 130)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Idade inválida.");
    Console.ResetColor();
    Environment.Exit(-1);
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nResponda [S] para SIM, ou outro para NÃO.\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Paciente com febre? ");
febre = Console.ReadLine()!.ToUpper() == "S";
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Paciente com tosse? ");
tosse = Console.ReadLine()!.ToUpper() == "S";
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Paciente com outro sintoma respiratório? ");
outroSintomaRespiratorio = Console.ReadLine()!.ToUpper() == "S";
Console.ResetColor();

if (!febre && !tosse && !outroSintomaRespiratorio)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n* Nenhuma recomendação específica.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\n-- Sinais de alarme --");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;  
    Console.Write("Paciente com falta de ar? ");
    faltaAr = Console.ReadLine()!.ToUpper() == "S";
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Paciente com aumento de frequência respiratória? ");
    aumentoFrequenciaRespiratoria = Console.ReadLine()!.ToUpper() == "S";
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Paciente com dor torácica? ");
    dorToracica = Console.ReadLine()!.ToUpper() == "S";
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Paciente com sensação de desmaio? ");
    sensacaoDesmaio = Console.ReadLine()!.ToUpper() == "S";
    Console.ResetColor();

    possuiSinalDeAlarme = faltaAr
        || aumentoFrequenciaRespiratoria
        || dorToracica
        || sensacaoDesmaio;

    if (idade < 18)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n-- Fatores de risco para menores --");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.Write("Paciente com hipertensão arterial sistêmica? ");
        hipertensao = Console.ReadLine()!.ToUpper() == "S";
         Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.Write("Paciente com diabetes melito? ");
        diabetes = Console.ReadLine()!.ToUpper() == "S";
         Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.Write("Paciente com outras doenças crônicas? ");
        outrasDoencasCronicas = Console.ReadLine()!.ToUpper() == "S";
         Console.ResetColor();

        possuiFatorDeRisco = hipertensao || diabetes || outrasDoencasCronicas;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n-- Fatores de risco para maiores --");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Paciente com doença coronariana prévia? ");
        doencaCoronariana = Console.ReadLine()!.ToUpper() == "S";
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Paciente com doença crônica descompensada? ");
        doencaCronica = Console.ReadLine()!.ToUpper() == "S";
        Console.ResetColor();

        possuiFatorDeRisco = (idade > 65)
            || aumentoFrequenciaRespiratoria
            || doencaCoronariana
            || doencaCronica;
    }

    if (possuiSinalDeAlarme || possuiFatorDeRisco)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n-- Situação --");
        Console.ResetColor();

        Console.Write("Paciente com situação grave? ");
        situacaoGrave = Console.ReadLine()!.ToUpper() == "S";
        Console.ResetColor();

        if (situacaoGrave)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n* Encaminhar ambulância para o local.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n* Encaminhar para o sistema de saúde.");
              Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n* Recomendar isolamento domiciliar.");
          Console.ResetColor();
    }

}

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\nObrigado por responder nosso questionário!");
Console.ResetColor();
