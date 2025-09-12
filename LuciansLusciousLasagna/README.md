# 🍝 Lucian's Luscious Lasagna

This project helps Lucian cook a perfect lasagna by tracking oven and preparation times.  
It’s part of my C# practice projects.

---

## 📝 Story
Lucian's girlfriend is on her way home and he hasn’t cooked their anniversary dinner!  
Using his favorite cookbook, Lucian must prepare an exquisite lasagna in time.  

This project calculates cooking times to ensure the lasagna is ready before dinner.

---

## ✅ Tasks Implemented
1. **Expected Oven Time**  
   - Method: `ExpectedMinutesInOven()`  
   - Returns the total oven time needed (40 minutes).  

2. **Remaining Oven Time**  
   - Method: `RemainingMinutesInOven(int actualMinutesInOven)`  
   - Returns how many minutes are left based on the expected oven time.  

3. **Preparation Time**  
   - Method: `PreparationTimeInMinutes(int numberOfLayers)`  
   - Calculates preparation time (2 minutes per layer).  

4. **Elapsed Time**  
   - Method: `ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven)`  
   - Returns total time spent (prep time + time in oven).  

---

## 🛠 Methods
```csharp
public int ExpectedMinutesInOven()
public int RemainingMinutesInOven(int actualMinutesInOven)
public int PreparationTimeInMinutes(int numberOfLayers)
public int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven)
```

## ▶️ Run the project
```bash
dotnet run --project LuciansLusciousLasagna
```

## ✅ Example

```csharp
var lasagna = new Lasagna();

Console.WriteLine(lasagna.ExpectedMinutesInOven());       // => 40
Console.WriteLine(lasagna.RemainingMinutesInOven(30));    // => 10
Console.WriteLine(lasagna.PreparationTimeInMinutes(2));   // => 4
Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));   // => 26
