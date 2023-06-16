using objetkové_pražské_město;
using Spectre.Console;
string[] poleLinkaA = { "nemocnice Motol", "Petřiny", "Nádraží Veleslaví", "Bořislavka", "Dejvická", "hradčanská", "Malostranská", "Straroměstská", "Můstek", "Náměstí míru ", "Jiřího z ppoděbrad ", "Flora", "žšliského ", "strašnická", "skalka", "depo hostivař", };
string[] poleLinkaB = {"Zličín","STODŮLKY","LUKA","LUŽINY","¨HŮRKA","NOVÉ BUTOVICE","JINONICE","RADLICKÁ","SMÍCHOVKSÉ NÁDRAŽÍ","ANDĚL","KARLOVO NÁMĚSTÍ","národní třída",
"MŮSTEK","NÁMĚSTÍ REPUBLIKY","FLORENC","KŘÍŽKOVA","INVALIDOVNA","PALMOVKA","ČESKOMORAVSKÁ","VYSOČANSKÁ","KOLBENOVA","HLOUBĚTÍN","RAJSKÁ ZAHRADA","ČERNÝ MOST"}; 
string[] poleLinkaC = {  "Letnany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice", "Vltavská", "Florenc", "Hlavní Nádrazí", "Muzeum", "I.P Pavlova", "Vyšehrad", "Pražského Povstaní", "Pankrác", "Budějovická", "Kačerov", "Roztyly", "chodov", "Opatov ", "háje ", };

Console.WriteLine("zadej linku kterou chceš využit (A/B/C/D");
string volbaLinky = Console.ReadLine();


await AnsiConsole.Progress()
    .StartAsync(async ctx =>
    {
        // Define tasks
        var task1 = ctx.AddTask("[green]Reticulating splines[/]");
        var task2 = ctx.AddTask("[green]Folding space[/]");

        while (!ctx.IsFinished)
        {
            // Simulate some work
            await Task.Delay(1);

            // Increment
            task1.Increment(1);
            task2.Increment(0.5);
        }
    });
if (volbaLinky == "A")
{
    LinkaMetra LinkaA = new LinkaMetra() { nazevLinky = "A", Aktivní = true, stanice = poleLinkaA, barva = "zelená" };
    LinkaA.NastavStanice();
    Console.WriteLine("chete vypsat 1. všechny stanice, 2.první a poslední 3. vypiš čas  ");
    string volba = Console.ReadLine();

    if(volba == "1")
    {
        LinkaA.VypisVsechnyStanice();
    }
    else if(volba == "2")
    {
        LinkaA.vypisPosledniStanice();
    }
    else if (volba == "3")
    {
        LinkaA.CasCesty();
    }
}

if (volbaLinky == "B")
{
    LinkaMetra LinkaB = new LinkaMetra() { nazevLinky = "B", Aktivní = true, stanice = poleLinkaB, barva = "žlutá" };
    LinkaB.NastavStanice();
    Console.WriteLine("chete vypsat 1. všechny stanice, 2.první a poslední´ 3, vypiš čas ");
    string volba = Console.ReadLine();

    if (volba == "1")
    {
        LinkaB.VypisVsechnyStanice();
    }
    else if (volba == "2")
    {
        LinkaB.vypisPosledniStanice();
    }
    else if (volba == "3")
    {
        LinkaB.CasCesty();
    }
}

if (volbaLinky == "C")
{
    LinkaMetra LinkaA = new LinkaMetra() { nazevLinky = "A", Aktivní = true, stanice = poleLinkaA, barva = "modrá" };
    LinkaA.NastavStanice();
    Console.WriteLine("chete vypsat 1. všechny stanice, 2.první a poslední  3. zjistit čas ");
    string volba = Console.ReadLine();

    if (volba == "1")
    {
        LinkaA.VypisVsechnyStanice();
    }
    else if (volba == "2")
    {
        LinkaA.vypisPosledniStanice();
    }
    else if (volba == "3")
    {
        LinkaA.CasCesty();
    }
}
