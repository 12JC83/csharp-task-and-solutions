# 🕵️ Annalyn's Infiltration

This project implements the quest logic for **Annalyn’s Infiltration**, a small RPG scenario.

## 📖 Story
Annalyn is a brave girl whose best friend was kidnapped by a knight and an archer.  
To rescue her friend, Annalyn must decide which actions are possible depending on the state of the characters and whether her loyal dog is present.  

## 🎯 Tasks implemented
- **⚔️ Fast Attack**: possible if the knight is sleeping.  
- **👀 Spy**: possible if at least one of them is awake.  
- **🐦 Signal Prisoner**: possible if the prisoner is awake **and** the archer is asleep.  
- **🔓 Free Prisoner**:  
  - With the dog → possible if the archer is asleep.  
  - Without the dog → possible if the prisoner is awake **and** both the knight and archer are asleep.  

## 🛠 Methods
```csharp
public static bool CanFastAttack(bool knightIsAwake)
public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
```

## ▶️ Run the project
```bash
dotnet run --project AnnalynsInfiltration
```

## ✅ Example
```csharp
var knightIsAwake = false;
var archerIsAwake = true;
var prisonerIsAwake = false;
var petDogIsPresent = false;

Console.WriteLine(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
// Output: false
```
