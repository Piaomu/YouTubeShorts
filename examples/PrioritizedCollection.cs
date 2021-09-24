//Stacks in programming are just like the stack in Magic: First in, last out.

Stack lands = new Stack();

lands.Push('Plains');
lands.Push('Island');
lands.Push('Swamp');
lands.Push('Mountain');
lands.Push('Forest');

lands.Peek(); // Reveals the top object on the Stack

lands.Pop(); // Removes the top object from the Stack
lands.Peek(); // Will reveal "Mountain"

// Queues are just like getting in line -- First in, first out.

Queue lands = new Queue();

lands.Enqueue("Plains");
lands.Enqueue("Island");
lands.Enqueue("Swamp");
lands.Enqueue("Mountain");
lands.Enqueue("Forest");

while (lands.Count > 0)
Console.WriteLine(lands.Dequeue());