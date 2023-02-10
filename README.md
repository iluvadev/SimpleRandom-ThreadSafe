# SimpleRandom-ThreadSafe
Some simple functions in C# to work with Random numbers in a thread-safe way

Inspired by: https://devblogs.microsoft.com/pfxteam/getting-random-numbers-in-a-thread-safe-way/


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
item1 = Rnd.From(myEnumerable);           // item1: a random item from "myEnumerable"
item2 = Rnd.From(1, 2, 3, 4, 5, 6, 7, 8); // item2: a random item from params
item3 = Rnd.From("Hello", "world");       // item3: a random item from params
item4 = Rnd.From<MyEnum>();               // item4: a random value from "MyEnum"
```

***Get a Sequence of Random elements***
```csharp
// If length is null: the Enumerable is infinite

seq1 = Rnd.SequenceDouble(length);  // seq1: IEnumerable<double>
seq2 = Rnd.SequenceDecimal(length); // seq2: IEnumerable<decimal>

seq3 = Rnd.SequenceByte(length);    // seq3: IEnumerable<byte>
seq4 = Rnd.SequenceInt16(length);   // seq4: IEnumerable<short> (Int16)
seq5 = Rnd.SequenceInt32(length);   // seq5: IEnumerable<int> (Int32)
seq6 = Rnd.SequenceInt64(length);   // seq6: IEnumerable<long> (Int64)

seq7 = Rnd.SequenceBoolean(length); // seq7: IEnumerable<bool>
```

***Get a Sequence of Random Items from IEnumerable, params or Enum***
```csharp
// If length is null: the Enumerable is infinite

seq1 = Rnd.SequenceFrom(length, myEnumerable);           // seq1: a sequence with random items from "myEnumerable"
seq2 = Rnd.SequenceFrom(length, 1, 2, 3, 4, 5, 6, 7, 8); // seq2: a sequence with random items from params
seq3 = Rnd.SequenceFrom(length, "Hello", "world");       // seq3: a sequence with random items from params
seq4 = Rnd.SequenceFrom<MyEnum>(length);                 // seq4: a sequence with random values from "MyEnum"
```

***Get a Sequence Suffling randomly an IEnumerable***

(The IEnumerable to `Shuffle` must be finite, the process calls the `Count()` method)
```csharp
seq1 = Rnd.Shuffle(myEnumerable); // seq1: a sequence with "myEnumerable" shuffled
```
