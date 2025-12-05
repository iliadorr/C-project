# 📊 StatsApp — Basic Statistics Calculator

This is a C# console application that calculates basic statistics from a list of numbers provided by the user.
The application supports:

* **Mean (Average)**
* **Median**
* **Mode**
* **Minimum**
* **Maximum**

The results are also saved into a `.txt` file.

---

## 🚀 How to Run

### 1️⃣ Clone the repository

```bash
git clone https://github.com/iliadorr/C-project.git
```

### 2️⃣ Navigate to the project folder

```bash
cd C-project/StatsApp
```

### 3️⃣ Run the application

```bash
dotnet run
```

---

## 📥 Input Example

```
Введите числа через пробел:
1 2 3 4 5 5 9
```

---

## 📤 Output Example

```
Результаты:
Среднее: 4.142857142857143
Медиана: 4
Мода: 5
Минимум: 1
Максимум: 9
```

---

## 📝 File Output

The program asks for a filename:

```
Введите имя файла для сохранения:
```

Example:

```
results.txt
```

The file is then created in the project folder and contains:

* Input numbers
* Mean, Median, Mode
* Min, Max
* Timestamp

---

## 🏗 Project Structure

```
C-project/
 ├── StatsApp/
 │   ├── Program.cs
 │   ├── FileManager.cs
 │   ├── StatisticsCalculator.cs
 │   ├── StatsResult.cs
 │   └── StatsApp.csproj
 └── README.md
```

---

## 📦 Build Release Version

To build a release version:

```bash
dotnet publish -c Release -r win-x64 --self-contained false
```

The final executable will appear in:

```
StatsApp/bin/Release/net8.0/win-x64/
```

---

## 📸 Screenshots

Add your screenshots here:

```
![Console Output](screenshots/run.png)
![Results File](screenshots/results.png)
```

---

# ✔️ Project Status

* Input processing
* Statistics calculation
* File output
* OOP structure
* README documentation

Everything required by the assignment is implemented.

