using Osztály;

Auto kek = new Auto(2020, "Focus", "Ford");
Auto zold = new Auto(1992, "Golf", "Volkswagen");
Auto piros = new Auto(2018, "Civic", "Honda");

List<Auto> garazs = new List<Auto> { kek, zold, piros};

foreach (Auto seged in garazs)
{
    seged.KiirAdatok();
}

//átlag
double atlag = garazs.Average(x => x.GyartasiEv);
Console.WriteLine($"Átlag gyártási év: {atlag}");