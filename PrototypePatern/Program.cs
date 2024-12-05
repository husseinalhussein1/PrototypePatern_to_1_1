using PrototypePatern;

SubClassPrototype a = new SubClassPrototype(4, 1);
Console.WriteLine(a);

SubClassPrototype a1 = a.Clone();
Console.WriteLine(a1);

SubClassPrototype a2 = a.Clone();
Console.WriteLine(a2);

///////////
        
SubClassPrototype1 c = new SubClassPrototype1(4,1);
Console.WriteLine(c);

SubClassPrototype1 c1 = c.Clone();
Console.WriteLine(c1);

SubClassPrototype1 c2 = c.Clone();
Console.WriteLine(c2);