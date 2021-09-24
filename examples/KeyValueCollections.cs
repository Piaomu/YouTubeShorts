// Key value pairs match one user-defined set of keys with a set of values. Dictionaries are a good example.

var lands = new Dictionary<string, string>()
{
  {"PLN", "Plains"},
  {"ISL", "Island"},
  {"SMP", "Swamp"},
  {"MTN", "Mountain"},
  {"FOR", "Forest"}
}

// Checking for an unknown key
if(lands.ContainsKey("PLN"))
{
  Console.WriteLine("I'm a white mage.");
}

// using ElementAt() to retrieve key-value pairs using an index
for (int i = 0; i < lands.Count; i++)
{
  Console.WriteLine("Key:{0}, Value {1}",
                                          lands.ElementAt(i).Key,
                                          lands.ElementAt(i).Value);
}