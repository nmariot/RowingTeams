// See https://aka.ms/new-console-template for more information
using RowingTeams;
using System.Runtime.CompilerServices;

// Initializing rowers
var rowers = new List<Rower>
{
    new("Maxime Moussé",43, Sex.Male),
    new ("Eleanor Forshaw",44, Sex.Female),
    new ("Sébastien Desgranges",49, Sex.Male),
    new ("Nicolas Delebarre",27, Sex.Male),
    new ("Thierry Davase (UNA)",55, Sex.Male),
    new ("Domitille Schneller",36, Sex.Female),
    new ("Joël Rosenfeld",53, Sex.Male),
    new ("Louis Cubaynes",32, Sex.Male),
    new ("Hayley Thompson", 39, Sex.Female),
    new ("Florence Molinie",56, Sex.Female),
    new ("Lise-Marie Michaud",38, Sex.Female),
    new ("Nicolas Mariot",51, Sex.Male)
};


DisplayBoatsForRaces(GetWednesdayRaces(), rowers, "Courses du Mercredi");
DisplayBoatsForRaces(GetThursdayRaces(), rowers, "Courses du Jeudi");
DisplayBoatsForRaces(GetFridayRaces(), rowers, "Courses du Vendredi");
DisplayBoatsForRaces(GetSaturdaryRaces(), rowers, "Courses du Samedi");
DisplayBoatsForRaces(GetSundayRaces(), rowers, "Courses du Dimanche");

void DisplayBoatsForRaces(List<Race> races, List<Rower> rowers, string label)
{
    Console.WriteLine("===================================================");
    Console.WriteLine(label);
    foreach (var race in races)
    {
        DisplayBoatsForRace(race, rowers);
    }
    Console.WriteLine("===================================================");
}

void DisplayBoatsForRace(Race race, List<Rower> rowers)
{
    Console.WriteLine($" --------- Race {race.Name} --------- ");
    var boats = Helper.GetBoatsFromRace(race, rowers, true);

    foreach (var b in boats)
    {
        var avgAge = b.Rowers.Average(r => r.Age);
        Console.WriteLine($"Age;{avgAge};" + String.Join(';', b.Rowers.Select(r => r.Name)));
    }
}

Console.ReadKey();


static List<Race> GetWednesdayRaces()
{
    return
    [
        CreateRaceFromLibelle("101 E 4+"),
        CreateRaceFromLibelle("102 WF 4-"),
        CreateRaceFromLibelle("103 H 2x"),
        CreateRaceFromLibelle("104 WA 1x"),
        CreateRaceFromLibelle("105 C 2-"),
        CreateRaceFromLibelle("106 WD 2x"),
        CreateRaceFromLibelle("107 F 1x"),
        CreateRaceFromLibelle("108 WG 2-"),
        CreateRaceFromLibelle("109 I 8+"),
        CreateRaceFromLibelle("110 WB 4x"),
        CreateRaceFromLibelle("111 A 1x"),
        CreateRaceFromLibelle("112 WE 8+"),
        CreateRaceFromLibelle("113 D 2x"),
        CreateRaceFromLibelle("114 G 4-"),
        CreateRaceFromLibelle("115 WC 4+"),
        CreateRaceFromLibelle("116 B 8+"),
    ];
}

static List<Race> GetThursdayRaces()
{
    return
    [
        CreateRaceFromLibelle("201 WC 8+"),
        CreateRaceFromLibelle("202 C 4-"),
        CreateRaceFromLibelle("203 WF 1x"),
        CreateRaceFromLibelle("204 F 2x"),
        CreateRaceFromLibelle("205 WI 1x"),
        CreateRaceFromLibelle("206 WA 4+"),
        CreateRaceFromLibelle("207 I 4x"),
        CreateRaceFromLibelle("208 A 2-"),
        CreateRaceFromLibelle("209 WD 4-"),
        CreateRaceFromLibelle("210 D 1x"),
        CreateRaceFromLibelle("211 WG  4x"),
        CreateRaceFromLibelle("212 G 8+"),
        CreateRaceFromLibelle("213 WB 2-"),
        CreateRaceFromLibelle("214 I 4+"),
        CreateRaceFromLibelle("215 B 2x"),
        CreateRaceFromLibelle("216 WE 4x"),
        CreateRaceFromLibelle("217 E 2-"),
        CreateRaceFromLibelle("218 H 1x"),
        CreateRaceFromLibelle("219 WH 2x"),
        CreateRaceFromLibelle("220 C 4x"),
        CreateRaceFromLibelle("221 F 4-"),
        CreateRaceFromLibelle("222 WC 1x"),
        CreateRaceFromLibelle("223 WF 4+"),
        CreateRaceFromLibelle("224 A 4-"),
        CreateRaceFromLibelle("225 WA 2x"),
        CreateRaceFromLibelle("226 D 8+"),
        CreateRaceFromLibelle("227 WD 4+"),
        CreateRaceFromLibelle("228 G 4x"),
        CreateRaceFromLibelle("229 J 2x"),
        CreateRaceFromLibelle("230 WB 4-"),
        CreateRaceFromLibelle("231 B 4+"),
        CreateRaceFromLibelle("232 WE 2-"),
        CreateRaceFromLibelle("233 E 4x"),
        CreateRaceFromLibelle("234 H 2-"),
        CreateRaceFromLibelle("235 WG 8+")
    ];
}

static List<Race> GetFridayRaces()
{
    return [
        CreateRaceFromLibelle("301 I 1x"),
        CreateRaceFromLibelle("302 WC 2-"),
        CreateRaceFromLibelle("303 A 2x"),
        CreateRaceFromLibelle("304 WF 4x"),
        CreateRaceFromLibelle("305 D 4+"),
        CreateRaceFromLibelle("306 WI 2x"),
        CreateRaceFromLibelle("307 G 2-"),
        CreateRaceFromLibelle("308 WA 4-"),
        CreateRaceFromLibelle("309 B 4x"),
        CreateRaceFromLibelle("310 WD 8+"),
        CreateRaceFromLibelle("311 E 1x"),
        //CreateRaceFromLibelle("312 W PR3 2x"),
        CreateRaceFromLibelle("313 H 4-"),
        CreateRaceFromLibelle("314 WG 2x"),
        CreateRaceFromLibelle("315 C 8+"),
        CreateRaceFromLibelle("316 WB 4+"),
        CreateRaceFromLibelle("317 F 4x"),
        CreateRaceFromLibelle("318 WE 2x"),
        CreateRaceFromLibelle("319 I 2-"),
        CreateRaceFromLibelle("320 WH 1x"),
        CreateRaceFromLibelle("321 A 4+"),
        CreateRaceFromLibelle("322 D 2-"),
        CreateRaceFromLibelle("323 WC 4x"),
        CreateRaceFromLibelle("324 G 2x"),
        CreateRaceFromLibelle("325 WF 2-"),
        CreateRaceFromLibelle("326 J 4x"),
        CreateRaceFromLibelle("327 B 4-"),
        CreateRaceFromLibelle("328 WA 8+"),
        CreateRaceFromLibelle("329 WD 1x"),
        CreateRaceFromLibelle("330 E 4-"),
        CreateRaceFromLibelle("331 WG 4+"),
        CreateRaceFromLibelle("332 WB 2x"),
        CreateRaceFromLibelle("333 H 4+"),
        CreateRaceFromLibelle("334 C 1x"),
        CreateRaceFromLibelle("335 WE 4-")
    ];
}

static List<Race> GetSaturdaryRaces()
{
    return
    [
        CreateRaceFromLibelle("401 D 4x"),
        CreateRaceFromLibelle("402 WC 4-"),
        CreateRaceFromLibelle("403 G 4+"),
        CreateRaceFromLibelle("404 J 1x"),
        CreateRaceFromLibelle("405 WF 2x"),
        CreateRaceFromLibelle("406 WH 4x"),
        CreateRaceFromLibelle("407 B 1x"),
        CreateRaceFromLibelle("408 E 8+"),
        CreateRaceFromLibelle("409 WA 2-"),
        CreateRaceFromLibelle("410 H 4x"),
        CreateRaceFromLibelle("411 C 2x"),
        // CreateRaceFromLibelle("412 PR3 2x"),
        CreateRaceFromLibelle("413 WD 2-"),
        CreateRaceFromLibelle("414 F 4+"),
        CreateRaceFromLibelle("415 WG 1x"),
        CreateRaceFromLibelle("416 I 4-"),
        CreateRaceFromLibelle("417 WB 8+"),
        CreateRaceFromLibelle("418 A 4x"),
        CreateRaceFromLibelle("419 WE 1x"),
        CreateRaceFromLibelle("420 D 4-"),
        CreateRaceFromLibelle("421 WC 2x"),
        CreateRaceFromLibelle("422 G 1x"),
        CreateRaceFromLibelle("423 WF 8+"),
        CreateRaceFromLibelle("424 I 2x"),
        CreateRaceFromLibelle("425 WA 4x"),
        CreateRaceFromLibelle("426 B 2-"),
        CreateRaceFromLibelle("427 E 2x"),
        CreateRaceFromLibelle("428 WD 4x"),
        CreateRaceFromLibelle("429 WG 4-"),
        CreateRaceFromLibelle("430 H 8+"),
        CreateRaceFromLibelle("431 C 4+"),
        CreateRaceFromLibelle("432 WB 1x"),
        CreateRaceFromLibelle("433 F 2-"),
        CreateRaceFromLibelle("434 WE 4+"),
        CreateRaceFromLibelle("435 K 1x"),
        CreateRaceFromLibelle("436 A 8+"),
    ];
}

static List<Race> GetSundayRaces()
{
    return
    [ 
        CreateRaceFromLibelle("501 MIX D 2x "),
        CreateRaceFromLibelle("502 MIX G 4x "),
        CreateRaceFromLibelle("503 MIX B 8+ "),
        CreateRaceFromLibelle("504 MIX E 2x "),
        CreateRaceFromLibelle("505 MIX H 4x "),
        CreateRaceFromLibelle("506 MIX C 8+ "),
        CreateRaceFromLibelle("507 MIX F 2x "),
        CreateRaceFromLibelle("508 MIX A 4x "),
        CreateRaceFromLibelle("509 MIX D 8+ "),
        CreateRaceFromLibelle("510 MIX G 2x "),
        CreateRaceFromLibelle("511 MIX PR3 2x "),
        CreateRaceFromLibelle("512 MIX B 4x "),
        CreateRaceFromLibelle("513 MIX E 8+ "),
        CreateRaceFromLibelle("514 MIX H 2x "),
        CreateRaceFromLibelle("515 MIX C 4x "),
        CreateRaceFromLibelle("516 MIX F 8+ "),
        CreateRaceFromLibelle("517 MIX A 2x "),
        CreateRaceFromLibelle("518 MIX D 4x "),
        CreateRaceFromLibelle("519 MIX G 8+ "),
        CreateRaceFromLibelle("520 MIX B 2x "),
        CreateRaceFromLibelle("521 MIX E 4x "),
        CreateRaceFromLibelle("522 MIX H 8+ "),
        CreateRaceFromLibelle("523 MIX C 2x "),
        CreateRaceFromLibelle("524 MIX F 4x "),
        CreateRaceFromLibelle("525 MIX A 8+ ")
    ];
}


static Race CreateRaceFromLibelle(string libelle)
{
    int number;
    RaceType rt;
    RaceCategory category;
    int nbRowers;

    var data = libelle.Split(' ');
    number = int.Parse(data[0]);

    if (data.Length == 3)
    {
        if (data[1][0] == 'W')
        {
            rt = RaceType.Women;
            _ = Enum.TryParse(data[1][1].ToString(), out category);
        }
        else
        {
            rt = RaceType.Men;
            _ = Enum.TryParse(data[1], out category);
        }
        nbRowers = int.Parse(data[2][0].ToString());
    }
    else
    {
        rt = RaceType.Mixed;
        _ = Enum.TryParse(data[2], out category);
        nbRowers = int.Parse(data[3][0].ToString());
    }

    return new Race(number, libelle, rt, nbRowers, category);
}
