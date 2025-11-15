string[] names = new string[] { "Anexceii", "Alex", "Alexander" };
int count = names.Count(n => n.Length > 6);
Console.WriteLine(count);