# SimpleThreadSafeRandom
Some simple functions in C# to work with Random numbers in a thread-safe way

Inspired by: https://devblogs.microsoft.com/pfxteam/getting-random-numbers-in-a-thread-safe-way/

*Not tested yet*

The static class Rnd manages the System.Random object for you. No initialization is needed

***Get a Random number***
```csharp
n1 = Rnd.Double();  // n1: double 
n2 = Rnd.Decimal(); // n2: decimal

n3 = Rnd.Byte();    // n3: byte
n4 = Rnd.Int16();   // n4: short (Int16)
n5 = Rnd.Int32();   // n5: int (Int32)
n6 = Rnd.Int64();   // n6: long (Int64)

n7 = Rnd.Boolean(); // n7: bool
```

***Get a Random Number between 2 values***
```csharp
n1 = Rnd.Between(n1Min, n1Max); // n1, n1Min, n1Max: double
n2 = Rnd.Between(n2Min, n2Max); // n2, n2Min, n2Max: decimal

n3 = Rnd.Between(n3Min, n3Max); // n3, n3Min, n3Max: byte
n4 = Rnd.Between(n4Min, n4Max); // n4, n4Min, n4Max: short (Int16)
n5 = Rnd.Between(n5Min, n5Max); // n5, n5Min, n5Max: int (Int32)
n6 = Rnd.Between(n6Min, n6Max); // n6, n6Min, n6Max: long (Int64)
```

***Get a Random Number Less than other***
```csharp
n1 = Rnd.LessThan(n1Max);  // n1, n1Max: double
n2 = Rnd.LessThan(n2Max);  // n2, n2Max: decimal

n3 = Rnd.LessThan(n3Max);  // n3, n3Max: byte
n4 = Rnd.LessThan(n4Max);  // n4, n4Max: short (Int16)
n5 = Rnd.LessThan(n5Max);  // n5, n5Max: int (Int32)
n6 = Rnd.LessThan(n6Max);  // n6, n6Max: long (Int64)
```
***Get a Random Number Greater than other***
```csharp
n1 = Rnd.GreaterThan(n1Min);  // n1, n1Min: double
n2 = Rnd.GreaterThan(n2Min);  // n2, n2Min: decimal

n3 = Rnd.GreaterThan(n3Min);  // n3, n3Min: byte
n4 = Rnd.GreaterThan(n4Min);  // n4, n4Min: short (Int16)
n5 = Rnd.GreaterThan(n5Min);  // n5, n5Min: int (Int32)
n6 = Rnd.GreaterThan(n6Min);  // n6, n6Min: long (Int64)
```

***Get a Random Item from IEnumerable, params or Enum***
```csharp
item1 = Rnd.From(myEnumerable);
item2 = Rnd.From(1, 2, 3, 4, 5, 6, 7, 8);
item3 = Rnd.From("Hello", "world");
item4 = Rnd.From<MyEnum>();
```
