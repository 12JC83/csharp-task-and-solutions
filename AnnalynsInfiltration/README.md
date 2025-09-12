# 🏹 Annalyn's Infiltration

This project implements the quest logic for **Annalyn’s Infiltration**, a small RPG scenario.  
It’s part of my C# practice projects.

---

## 📖 Story

Annalyn is a brave girl whose best friend was kidnapped by a knight and an archer.  
To rescue her friend, Annalyn must decide which actions are possible depending on the state of the characters and whether her loyal dog is present.

The possible actions are: fast attack, spying, signalling the prisoner, and freeing the prisoner.

---

## ✅ Tasks Implemented

### 1. Fast Attack
- **Method:** `CanFastAttack(bool knightIsAwake)`
- Returns `true` if the knight is sleeping (since he needs time to put on his armor).

### 2. Spy
- **Method:** `CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)`
- Returns `true` if **at least one** of the characters is awake.

### 3. Signal Prisoner
- **Method:** `CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)`
- Returns `true` if the prisoner is awake **and** the archer is asleep (otherwise, the archer can intercept the signal).

### 4. Free Prisoner
- **Method:**  
  `CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)`
- Returns `true` in **two cases**:
  - ✅ With the dog → if the archer is asleep (the knight fears the dog).  
  - ✅ Without the dog → if the prisoner is awake **and** both the knight and archer are asleep.

---

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
var prisonerIsAwake = true;
var petDogIsPresent = false;

Console.WriteLine(QuestLogic.CanFastAttack(knightIsAwake)); // => true
Console.WriteLine(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake)); // => true
Console.WriteLine(QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake)); // => false
Console.WriteLine(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent)); // => false

