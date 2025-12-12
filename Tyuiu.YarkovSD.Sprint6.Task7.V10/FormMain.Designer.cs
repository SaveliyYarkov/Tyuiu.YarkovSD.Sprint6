namespace Tyuiu.YarkovSD.Sprint6.Task7.V10
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelInputYSD;
        private System.Windows.Forms.Label labelOutputYSD;
        private System.Windows.Forms.DataGridView dataGridViewInYSD;
        private System.Windows.Forms.DataGridView dataGridViewOutYSD;
        private System.Windows.Forms.Button buttonOpenYSD;
        private System.Windows.Forms.Button buttonDoneYSD;
        private System.Windows.Forms.Button buttonSaveYSD;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRows;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCols;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelInputYSD = new Label();
            labelOutputYSD = new Label();
            dataGridViewInYSD = new DataGridView();
            dataGridViewOutYSD = new DataGridView();
            buttonOpenYSD = new Button();
            buttonDoneYSD = new Button();
            buttonSaveYSD = new Button();
            buttonHelpYSD = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelInfo = new ToolStripStatusLabel();
            toolStripStatusLabelRows = new ToolStripStatusLabel();
            toolStripStatusLabelCols = new ToolStripStatusLabel();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            toolTipButton = new ToolTip(components);
            groupBoxTaskYSD = new GroupBox();
            textBoxYSD = new TextBox();
            groupBoxTitleYSD = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInYSD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutYSD).BeginInit();
            statusStrip1.SuspendLayout();
            groupBoxTaskYSD.SuspendLayout();
            SuspendLayout();
            // 
            // labelInputYSD
            // 
            labelInputYSD.Font = new Font("Arial", 10F, FontStyle.Bold);
            labelInputYSD.Location = new Point(12, 214);
            labelInputYSD.Name = "labelInputYSD";
            labelInputYSD.Size = new Size(150, 20);
            labelInputYSD.TabIndex = 0;
            labelInputYSD.Text = "Ввод:";
            // 
            // labelOutputYSD
            // 
            labelOutputYSD.FlatStyle = FlatStyle.Flat;
            labelOutputYSD.Font = new Font("Arial", 10F, FontStyle.Bold);
            labelOutputYSD.ForeColor = SystemColors.ActiveCaptionText;
            labelOutputYSD.Location = new Point(563, 214);
            labelOutputYSD.Name = "labelOutputYSD";
            labelOutputYSD.Size = new Size(150, 20);
            labelOutputYSD.TabIndex = 1;
            labelOutputYSD.Text = "Вывод:";
            labelOutputYSD.Click += labelOutput_Click;
            // 
            // dataGridViewInYSD
            // 
            dataGridViewInYSD.AllowUserToAddRows = false;
            dataGridViewInYSD.AllowUserToDeleteRows = false;
            dataGridViewInYSD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInYSD.Location = new Point(12, 237);
            dataGridViewInYSD.Name = "dataGridViewInYSD";
            dataGridViewInYSD.ReadOnly = true;
            dataGridViewInYSD.RowHeadersWidth = 40;
            dataGridViewInYSD.Size = new Size(529, 262);
            dataGridViewInYSD.TabIndex = 2;
            // 
            // dataGridViewOutYSD
            // 
            dataGridViewOutYSD.AllowUserToAddRows = false;
            dataGridViewOutYSD.AllowUserToDeleteRows = false;
            dataGridViewOutYSD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutYSD.Location = new Point(563, 237);
            dataGridViewOutYSD.Name = "dataGridViewOutYSD";
            dataGridViewOutYSD.ReadOnly = true;
            dataGridViewOutYSD.RowHeadersWidth = 40;
            dataGridViewOutYSD.Size = new Size(309, 262);
            dataGridViewOutYSD.TabIndex = 3;
            dataGridViewOutYSD.CellContentClick += dataGridViewOut_CellContentClick;
            // 
            // buttonOpenYSD
            // 
            buttonOpenYSD.BackColor = SystemColors.ButtonFace;
            buttonOpenYSD.Font = new Font("Arial", 9F, FontStyle.Bold);
            buttonOpenYSD.Image = (Image)resources.GetObject("buttonOpenYSD.Image");
            buttonOpenYSD.Location = new Point(12, 3);
            buttonOpenYSD.Name = "buttonOpenYSD";
            buttonOpenYSD.Size = new Size(89, 71);
            buttonOpenYSD.TabIndex = 4;
            buttonOpenYSD.UseVisualStyleBackColor = false;
            buttonOpenYSD.Click += buttonOpen_Click;
            buttonOpenYSD.MouseEnter += buttonOpen_MouseEnter;
            // 
            // buttonDoneYSD
            // 
            buttonDoneYSD.BackColor = SystemColors.ButtonFace;
            buttonDoneYSD.Enabled = false;
            buttonDoneYSD.Font = new Font("Arial", 9F, FontStyle.Bold);
            buttonDoneYSD.Image = (Image)resources.GetObject("buttonDoneYSD.Image");
            buttonDoneYSD.Location = new Point(107, 3);
            buttonDoneYSD.Name = "buttonDoneYSD";
            buttonDoneYSD.Size = new Size(91, 71);
            buttonDoneYSD.TabIndex = 5;
            buttonDoneYSD.UseVisualStyleBackColor = false;
            buttonDoneYSD.Click += buttonDone_Click;
            buttonDoneYSD.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonSaveYSD
            // 
            buttonSaveYSD.BackColor = SystemColors.ButtonFace;
            buttonSaveYSD.Enabled = false;
            buttonSaveYSD.Font = new Font("Arial", 9F, FontStyle.Bold);
            buttonSaveYSD.Image = (Image)resources.GetObject("buttonSaveYSD.Image");
            buttonSaveYSD.Location = new Point(204, 3);
            buttonSaveYSD.Name = "buttonSaveYSD";
            buttonSaveYSD.Size = new Size(92, 71);
            buttonSaveYSD.TabIndex = 6;
            buttonSaveYSD.UseVisualStyleBackColor = false;
            buttonSaveYSD.Click += buttonSave_Click;
            buttonSaveYSD.MouseEnter += buttonSave_MouseEnter;
            // 
            // buttonHelpYSD
            // 
            buttonHelpYSD.BackColor = SystemColors.ButtonFace;
            buttonHelpYSD.Font = new Font("Arial", 9F, FontStyle.Bold);
            buttonHelpYSD.ForeColor = SystemColors.ControlText;
            buttonHelpYSD.Image = (Image)resources.GetObject("buttonHelpYSD.Image");
            buttonHelpYSD.Location = new Point(771, 3);
            buttonHelpYSD.Name = "buttonHelpYSD";
            buttonHelpYSD.Size = new Size(101, 71);
            buttonHelpYSD.TabIndex = 7;
            buttonHelpYSD.UseVisualStyleBackColor = false;
            buttonHelpYSD.Click += buttonHelp_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo, toolStripStatusLabelRows, toolStripStatusLabelCols });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(884, 22);
            statusStrip1.TabIndex = 8;
            // 
            // toolStripStatusLabelInfo
            // 
            toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            toolStripStatusLabelInfo.Size = new Size(88, 17);
            toolStripStatusLabelInfo.Text = "Готов к работе";
            // 
            // toolStripStatusLabelRows
            // 
            toolStripStatusLabelRows.Name = "toolStripStatusLabelRows";
            toolStripStatusLabelRows.Size = new Size(52, 17);
            toolStripStatusLabelRows.Text = "Строк: 0";
            // 
            // toolStripStatusLabelCols
            // 
            toolStripStatusLabelCols.Name = "toolStripStatusLabelCols";
            toolStripStatusLabelCols.Size = new Size(82, 17);
            toolStripStatusLabelCols.Text = " | Столбцов: 0";
            // 
            // groupBoxTaskYSD
            // 
            groupBoxTaskYSD.Controls.Add(textBoxYSD);
            groupBoxTaskYSD.Location = new Point(10, 80);
            groupBoxTaskYSD.Name = "groupBoxTaskYSD";
            groupBoxTaskYSD.Size = new Size(862, 117);
            groupBoxTaskYSD.TabIndex = 9;
            groupBoxTaskYSD.TabStop = false;
            groupBoxTaskYSD.Text = "Условие:";
            // 
            // textBoxYSD
            // 
            textBoxYSD.Location = new Point(2, 22);
            textBoxYSD.Multiline = true;
            textBoxYSD.Name = "textBoxYSD";
            textBoxYSD.Size = new Size(854, 89);
            textBoxYSD.TabIndex = 0;
            textBoxYSD.Text = resources.GetString("textBoxYSD.Text");
            // 
            // groupBoxTitleYSD
            // 
            groupBoxTitleYSD.Location = new Point(10, -9);
            groupBoxTitleYSD.Name = "groupBoxTitleYSD";
            groupBoxTitleYSD.Size = new Size(862, 95);
            groupBoxTitleYSD.TabIndex = 10;
            groupBoxTitleYSD.TabStop = false;
            // 
            // FormMain
            // 
            ClientSize = new Size(884, 561);
            Controls.Add(groupBoxTaskYSD);
            Controls.Add(labelInputYSD);
            Controls.Add(labelOutputYSD);
            Controls.Add(dataGridViewInYSD);
            Controls.Add(dataGridViewOutYSD);
            Controls.Add(buttonOpenYSD);
            Controls.Add(buttonDoneYSD);
            Controls.Add(buttonSaveYSD);
            Controls.Add(buttonHelpYSD);
            Controls.Add(statusStrip1);
            Controls.Add(groupBoxTitleYSD);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Tаск 7 | Вариант 10 | Ярков С. Д.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInYSD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutYSD).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBoxTaskYSD.ResumeLayout(false);
            groupBoxTaskYSD.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button buttonHelpYSD;
        private GroupBox groupBoxTaskYSD;
        private TextBox textBoxYSD;
        private GroupBox groupBoxTitleYSD;
    }
}