public int[,] GetMatrix(string path)
{
    // Проверки
    if (string.IsNullOrEmpty(path))
        throw new ArgumentException("Путь к файлу не указан");

    if (!File.Exists(path))
        throw new FileNotFoundException($"Файл не найден: {path}", path);

    string[] lines = File.ReadAllLines(path);

    if (lines.Length == 0)
        throw new ArgumentException("Файл пуст");

    if (lines.Length < 5)
        throw new ArgumentException($"В файле только {lines.Length} строк. Требуется минимум 5.");

    // Определяем размеры
    int rows = lines.Length;
    string[] firstLineValues = lines[0].Split(';');
    int cols = firstLineValues.Length;

    int[,] matrix = new int[rows, cols];
    int[,] result = new int[rows, cols];

    // Парсинг и обработка в одном цикле
    for (int i = 0; i < rows; i++)
    {
        string[] values = lines[i].Split(';');

        if (values.Length != cols)
            throw new FormatException($"Строка {i + 1}: ожидалось {cols} значений, получено {values.Length}");

        for (int j = 0; j < cols; j++)
        {
            if (!int.TryParse(values[j].Trim(), out int value))
                throw new FormatException($"Строка {i + 1}, столбец {j + 1}: не удалось преобразовать '{values[j]}' в число");

            matrix[i, j] = value;

            // Обработка пятой строки
            if (i == 4) // Пятая строка
            {
                result[i, j] = (value >= 5 && value <= 10) ? 0 : value;
            }
            else
            {
                result[i, j] = value;
            }
        }
    }

    return result;
}