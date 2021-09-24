// Index-based collections in C# are assigned an internal index number starting with 0
// and can be targeted by that index.

List<string> lands = new List<string>()
{
  lands.Add("Plains");
  lands.Add("Island");
  lands.Add("Swamp");
  lands.Add("Mountain");
  lands.Add("Forest");
}

console.WriteLine(lands[0]); // prints Plains

foreach(var land in lands)
{
  land.Tap();
}

string[] basicLands = new string[5]{"Plains", "Island", "Swamp", "Mountain", "Forest"};


