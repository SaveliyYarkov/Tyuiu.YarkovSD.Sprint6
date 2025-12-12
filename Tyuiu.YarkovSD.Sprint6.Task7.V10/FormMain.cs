using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.YarkovSD.Sprint6.Task7.V10.Lib;

namespace Tyuiu.YarkovSD.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        private int rows, columns;
        private string openFilePath;
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialogTask.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonDoneYSD.Enabled = false;
            buttonSaveYSD.Enabled = false;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openFilePath = openFileDialogTask.FileName;

                    string[] allLines = File.ReadAllLines(openFilePath);
                    var lines = allLines
                        .Where(line => !string.IsNullOrWhiteSpace(line))
                        .Where(line => line.Split(';').Any(x => !string.IsNullOrWhiteSpace(x)))
                        .ToArray();

                    if (lines.Length == 0)
                    {
                        MessageBox.Show("Файл пуст или содержит только пустые строки", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string[] firstLineValues = lines[0].Split(';')
                        .Where(x => !string.IsNullOrWhiteSpace(x))
                        .ToArray();

                    rows = lines.Length;
                    columns = Math.Max(firstLineValues.Length, 1);

                    // Проверяем, что есть минимум 3 столбца
                    if (columns < 3)
                    {
                        MessageBox.Show("Файл должен содержать минимум 3 столбца", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Настраиваем DataGridView для ввода
                    SetupDataGridView(dataGridViewInYSD, rows, columns);

                    // Отображаем исходные данные
                    DisplayMatrixFromFile(dataGridViewInYSD, openFilePath);

                    // Подсвечиваем третий столбец
                    HighlightThirdColumn(dataGridViewInYSD);

                    buttonDoneYSD.Enabled = true;
                    buttonSaveYSD.Enabled = false;

                    // Обновляем информацию
                    UpdateStatus($"Загружено: {rows}×{columns} | Третий столбец будет обработан");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetupDataGridView(DataGridView dgv, int rowCount, int columnCount)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                dgv.Columns.Add($"Col{i}", i.ToString()); 
                dgv.Columns[i].Width = 40;
                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.RowCount = rowCount;

            for (int i = 0; i < rowCount; i++)
            {
                dgv.Rows[i].HeaderCell.Value = i.ToString(); 
            }

            dgv.RowHeadersWidth = 40;
        }

        private void DisplayMatrixFromFile(DataGridView dgv, string filePath)
        {
            string[] allLines = File.ReadAllLines(filePath);
            var lines = allLines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Where(line => line.Split(';').Any(x => !string.IsNullOrWhiteSpace(x)))
                .ToArray();

            string[] firstLineValues = lines[0].Split(';')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToArray();

            int cols = Math.Max(firstLineValues.Length, 1);

            for (int i = 0; i < lines.Length && i < rows; i++)
            {
                string[] values = lines[i].Split(';')
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    if (j < values.Length && int.TryParse(values[j], out int parsedValue))
                    {
                        dgv.Rows[i].Cells[j].Value = parsedValue;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
        }

        private void HighlightThirdColumn(DataGridView dgv)
        {
            if (dgv.Columns.Count >= 3)
            {
                // Подсвечиваем заголовок третьего столбца
                dgv.Columns[2].HeaderCell.Style.BackColor = System.Drawing.Color.LightBlue;
                dgv.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);

                // Подсвечиваем ячейки третьего столбца
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[2].Value?.ToString() == "0")
                    {
                        dgv.Rows[i].Cells[2].Style.BackColor = System.Drawing.Color.LightYellow;
                    }
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] processedMatrix = ds.GetMatrix(openFilePath);

                SetupDataGridView(dataGridViewOutYSD, rows, columns);

                // Отображаем обработанную матрицу
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (i < processedMatrix.GetLength(0) && j < processedMatrix.GetLength(1))
                        {
                            dataGridViewOutYSD.Rows[i].Cells[j].Value = processedMatrix[i, j];

                            // Подсвечиваем измененные ячейки в третьем столбце
                            if (j == 2)
                            {
                                try
                                {
                                    object originalValue = dataGridViewInYSD.Rows[i].Cells[j].Value;
                                    int processedValue = processedMatrix[i, j];

                                    if (originalValue?.ToString() == "0" && processedValue == 1)
                                    {
                                        dataGridViewOutYSD.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.LightGreen;
                                        dataGridViewOutYSD.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
                                    }
                                }
                                catch { }
                            }
                        }
                    }
                }

                // Подсвечиваем третий столбец в выводе
                if (dataGridViewOutYSD.Columns.Count >= 3)
                {
                    dataGridViewOutYSD.Columns[2].HeaderCell.Style.BackColor = System.Drawing.Color.LightBlue;
                    dataGridViewOutYSD.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
                }

                buttonSaveYSD.Enabled = true;

                // Статистика обработки
                int changedCount = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (dataGridViewOutYSD.Rows[i].Cells[2].Value?.ToString() == "1" &&
                        dataGridViewInYSD.Rows[i].Cells[2].Value?.ToString() == "0")
                    {
                        changedCount++;
                    }
                }

                UpdateStatus($"Обработано. В столбце 2 заменено {changedCount} значений (0 → 1)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialogTask.FileName;

                    // Удаляем существующий файл, если есть
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    // Сохраняем данные из dataGridViewOut
                    using (StreamWriter writer = new StreamWriter(path, false))
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            string[] rowValues = new string[columns];

                            for (int j = 0; j < columns; j++)
                            {
                                object cellValue = dataGridViewOutYSD.Rows[i].Cells[j].Value;
                                rowValues[j] = cellValue?.ToString() ?? "0";
                            }

                            writer.WriteLine(string.Join(";", rowValues));
                        }
                    }

                    MessageBox.Show($"Файл успешно сохранен:\n{path}", "Сохранение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateStatus($"Сохранено: {Path.GetFileName(path)}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateStatus(string message)
        {
            toolStripStatusLabelInfo.Text = message;
            toolStripStatusLabelRows.Text = rows.ToString();
            toolStripStatusLabelCols.Text = columns.ToString();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string helpText = "Программа для обработки матриц из CSV файлов\n\n" +
                            "Формат файла: значения разделяются точкой с запятой (;)\n" +
                            "Поддерживается любое количество строк и столбцов\n\n" +
                            "Алгоритм работы:\n" +
                            "1. Загрузите CSV файл с матрицей (минимум 3 столбца)\n" +
                            "2. Программа обработает третий столбец (индекс 2):\n" +
                            "   - Все значения 0 заменяются на 1\n" +
                            "   - Остальные значения остаются без изменений\n" +
                            "3. Сохраните результат в новый CSV файл";

            MessageBox.Show(helpText, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.SetToolTip(buttonOpenYSD, "Загрузить CSV файл с матрицей");
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.SetToolTip(buttonDoneYSD, "Изменить в столбце 2 значения 0 на 1");
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.SetToolTip(buttonSaveYSD, "Сохранить результат в CSV файл");
        }

        private void dataGridViewOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}