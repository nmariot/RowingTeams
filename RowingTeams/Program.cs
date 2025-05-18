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
        Helper.CreateRaceFromLibelle("101 E 4+"),
        Helper.CreateRaceFromLibelle("102 WF 4-"),
        Helper.CreateRaceFromLibelle("103 H 2x"),
        Helper.CreateRaceFromLibelle("104 WA 1x"),
        Helper.CreateRaceFromLibelle("105 C 2-"),
        Helper.CreateRaceFromLibelle("106 WD 2x"),
        Helper.CreateRaceFromLibelle("107 F 1x"),
        Helper.CreateRaceFromLibelle("108 WG 2-"),
        Helper.CreateRaceFromLibelle("109 I 8+"),
        Helper.CreateRaceFromLibelle("110 WB 4x"),
        Helper.CreateRaceFromLibelle("111 A 1x"),
        Helper.CreateRaceFromLibelle("112 WE 8+"),
        Helper.CreateRaceFromLibelle("113 D 2x"),
        Helper.CreateRaceFromLibelle("114 G 4-"),
        Helper.CreateRaceFromLibelle("115 WC 4+"),
        Helper.CreateRaceFromLibelle("116 B 8+"),
    ];
}

static List<Race> GetThursdayRaces()
{
    return
    [
        Helper.CreateRaceFromLibelle("201 WC 8+"),
        Helper.CreateRaceFromLibelle("202 C 4-"),
        Helper.CreateRaceFromLibelle("203 WF 1x"),
        Helper.CreateRaceFromLibelle("204 F 2x"),
        Helper.CreateRaceFromLibelle("205 WI 1x"),
        Helper.CreateRaceFromLibelle("206 WA 4+"),
        Helper.CreateRaceFromLibelle("207 I 4x"),
        Helper.CreateRaceFromLibelle("208 A 2-"),
        Helper.CreateRaceFromLibelle("209 WD 4-"),
        Helper.CreateRaceFromLibelle("210 D 1x"),
        Helper.CreateRaceFromLibelle("211 WG  4x"),
        Helper.CreateRaceFromLibelle("212 G 8+"),
        Helper.CreateRaceFromLibelle("213 WB 2-"),
        Helper.CreateRaceFromLibelle("214 I 4+"),
        Helper.CreateRaceFromLibelle("215 B 2x"),
        Helper.CreateRaceFromLibelle("216 WE 4x"),
        Helper.CreateRaceFromLibelle("217 E 2-"),
        Helper.CreateRaceFromLibelle("218 H 1x"),
        Helper.CreateRaceFromLibelle("219 WH 2x"),
        Helper.CreateRaceFromLibelle("220 C 4x"),
        Helper.CreateRaceFromLibelle("221 F 4-"),
        Helper.CreateRaceFromLibelle("222 WC 1x"),
        Helper.CreateRaceFromLibelle("223 WF 4+"),
        Helper.CreateRaceFromLibelle("224 A 4-"),
        Helper.CreateRaceFromLibelle("225 WA 2x"),
        Helper.CreateRaceFromLibelle("226 D 8+"),
        Helper.CreateRaceFromLibelle("227 WD 4+"),
        Helper.CreateRaceFromLibelle("228 G 4x"),
        Helper.CreateRaceFromLibelle("229 J 2x"),
        Helper.CreateRaceFromLibelle("230 WB 4-"),
        Helper.CreateRaceFromLibelle("231 B 4+"),
        Helper.CreateRaceFromLibelle("232 WE 2-"),
        Helper.CreateRaceFromLibelle("233 E 4x"),
        Helper.CreateRaceFromLibelle("234 H 2-"),
        Helper.CreateRaceFromLibelle("235 WG 8+")
    ];
}

static List<Race> GetFridayRaces()
{
    return [
        Helper.CreateRaceFromLibelle("301 I 1x"),
        Helper.CreateRaceFromLibelle("302 WC 2-"),
        Helper.CreateRaceFromLibelle("303 A 2x"),
        Helper.CreateRaceFromLibelle("304 WF 4x"),
        Helper.CreateRaceFromLibelle("305 D 4+"),
        Helper.CreateRaceFromLibelle("306 WI 2x"),
        Helper.CreateRaceFromLibelle("307 G 2-"),
        Helper.CreateRaceFromLibelle("308 WA 4-"),
        Helper.CreateRaceFromLibelle("309 B 4x"),
        Helper.CreateRaceFromLibelle("310 WD 8+"),
        Helper.CreateRaceFromLibelle("311 E 1x"),
        //Helper.CreateRaceFromLibelle("312 W PR3 2x"),
        Helper.CreateRaceFromLibelle("313 H 4-"),
        Helper.CreateRaceFromLibelle("314 WG 2x"),
        Helper.CreateRaceFromLibelle("315 C 8+"),
        Helper.CreateRaceFromLibelle("316 WB 4+"),
        Helper.CreateRaceFromLibelle("317 F 4x"),
        Helper.CreateRaceFromLibelle("318 WE 2x"),
        Helper.CreateRaceFromLibelle("319 I 2-"),
        Helper.CreateRaceFromLibelle("320 WH 1x"),
        Helper.CreateRaceFromLibelle("321 A 4+"),
        Helper.CreateRaceFromLibelle("322 D 2-"),
        Helper.CreateRaceFromLibelle("323 WC 4x"),
        Helper.CreateRaceFromLibelle("324 G 2x"),
        Helper.CreateRaceFromLibelle("325 WF 2-"),
        Helper.CreateRaceFromLibelle("326 J 4x"),
        Helper.CreateRaceFromLibelle("327 B 4-"),
        Helper.CreateRaceFromLibelle("328 WA 8+"),
        Helper.CreateRaceFromLibelle("329 WD 1x"),
        Helper.CreateRaceFromLibelle("330 E 4-"),
        Helper.CreateRaceFromLibelle("331 WG 4+"),
        Helper.CreateRaceFromLibelle("332 WB 2x"),
        Helper.CreateRaceFromLibelle("333 H 4+"),
        Helper.CreateRaceFromLibelle("334 C 1x"),
        Helper.CreateRaceFromLibelle("335 WE 4-")
    ];
}

static List<Race> GetSaturdaryRaces()
{
    return
    [
        Helper.CreateRaceFromLibelle("401 D 4x"),
        Helper.CreateRaceFromLibelle("402 WC 4-"),
        Helper.CreateRaceFromLibelle("403 G 4+"),
        Helper.CreateRaceFromLibelle("404 J 1x"),
        Helper.CreateRaceFromLibelle("405 WF 2x"),
        Helper.CreateRaceFromLibelle("406 WH 4x"),
        Helper.CreateRaceFromLibelle("407 B 1x"),
        Helper.CreateRaceFromLibelle("408 E 8+"),
        Helper.CreateRaceFromLibelle("409 WA 2-"),
        Helper.CreateRaceFromLibelle("410 H 4x"),
        Helper.CreateRaceFromLibelle("411 C 2x"),
        // Helper.CreateRaceFromLibelle("412 PR3 2x"),
        Helper.CreateRaceFromLibelle("413 WD 2-"),
        Helper.CreateRaceFromLibelle("414 F 4+"),
        Helper.CreateRaceFromLibelle("415 WG 1x"),
        Helper.CreateRaceFromLibelle("416 I 4-"),
        Helper.CreateRaceFromLibelle("417 WB 8+"),
        Helper.CreateRaceFromLibelle("418 A 4x"),
        Helper.CreateRaceFromLibelle("419 WE 1x"),
        Helper.CreateRaceFromLibelle("420 D 4-"),
        Helper.CreateRaceFromLibelle("421 WC 2x"),
        Helper.CreateRaceFromLibelle("422 G 1x"),
        Helper.CreateRaceFromLibelle("423 WF 8+"),
        Helper.CreateRaceFromLibelle("424 I 2x"),
        Helper.CreateRaceFromLibelle("425 WA 4x"),
        Helper.CreateRaceFromLibelle("426 B 2-"),
        Helper.CreateRaceFromLibelle("427 E 2x"),
        Helper.CreateRaceFromLibelle("428 WD 4x"),
        Helper.CreateRaceFromLibelle("429 WG 4-"),
        Helper.CreateRaceFromLibelle("430 H 8+"),
        Helper.CreateRaceFromLibelle("431 C 4+"),
        Helper.CreateRaceFromLibelle("432 WB 1x"),
        Helper.CreateRaceFromLibelle("433 F 2-"),
        Helper.CreateRaceFromLibelle("434 WE 4+"),
        Helper.CreateRaceFromLibelle("435 K 1x"),
        Helper.CreateRaceFromLibelle("436 A 8+"),
    ];
}

static List<Race> GetSundayRaces()
{
    return
    [ 
        Helper.CreateRaceFromLibelle("501 MIX D 2x "),
        Helper.CreateRaceFromLibelle("502 MIX G 4x "),
        Helper.CreateRaceFromLibelle("503 MIX B 8+ "),
        Helper.CreateRaceFromLibelle("504 MIX E 2x "),
        Helper.CreateRaceFromLibelle("505 MIX H 4x "),
        Helper.CreateRaceFromLibelle("506 MIX C 8+ "),
        Helper.CreateRaceFromLibelle("507 MIX F 2x "),
        Helper.CreateRaceFromLibelle("508 MIX A 4x "),
        Helper.CreateRaceFromLibelle("509 MIX D 8+ "),
        Helper.CreateRaceFromLibelle("510 MIX G 2x "),
        Helper.CreateRaceFromLibelle("511 MIX PR3 2x "),
        Helper.CreateRaceFromLibelle("512 MIX B 4x "),
        Helper.CreateRaceFromLibelle("513 MIX E 8+ "),
        Helper.CreateRaceFromLibelle("514 MIX H 2x "),
        Helper.CreateRaceFromLibelle("515 MIX C 4x "),
        Helper.CreateRaceFromLibelle("516 MIX F 8+ "),
        Helper.CreateRaceFromLibelle("517 MIX A 2x "),
        Helper.CreateRaceFromLibelle("518 MIX D 4x "),
        Helper.CreateRaceFromLibelle("519 MIX G 8+ "),
        Helper.CreateRaceFromLibelle("520 MIX B 2x "),
        Helper.CreateRaceFromLibelle("521 MIX E 4x "),
        Helper.CreateRaceFromLibelle("522 MIX H 8+ "),
        Helper.CreateRaceFromLibelle("523 MIX C 2x "),
        Helper.CreateRaceFromLibelle("524 MIX F 4x "),
        Helper.CreateRaceFromLibelle("525 MIX A 8+ ")
    ];
}
