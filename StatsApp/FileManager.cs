using System.Text;

namespace StatsApp;

public class FileManager
{
    public void SaveResults(string filePath, double[] numbers, StatsResult result)
    {
        var sb = new StringBuilder();

        sb.AppendLine("==== Statistics Results ====");
        sb.AppendLine($"Дата: {DateTime.Now}");
        sb.AppendLine($"Введённые числа: {string.Join(", ", numbers)}");
        sb.AppendLine($"Среднее (Mean): {result.Mean}");
        sb.AppendLine($"Медиана (Median): {result.Median}");
        sb.AppendLine($"Мода (Mode): {(result.Mode.HasValue ? result.Mode.Value.ToString() : "нет")}");
        sb.AppendLine($"Минимум: {result.Min}");
        sb.AppendLine($"Максимум: {result.Max}");
        sb.AppendLine();

        File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
    }
}
