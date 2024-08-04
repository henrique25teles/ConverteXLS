namespace ConverteXLS
{
    partial class ConverteXls
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            folderBrowserPlanilhas = new FolderBrowserDialog();
            txt_Path = new TextBox();
            btnBuscar = new Button();
            pgBar = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            btn_converter = new Button();
            chk_deletaOld = new CheckBox();
            btnDeletar = new Button();
            btn_DeletaExtensao = new Button();
            txt_extensionDelete = new TextBox();
            label3 = new Label();
            lbl_Status = new Label();
            lbl_Timer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txt_Path
            // 
            txt_Path.Location = new Point(227, 106);
            txt_Path.Name = "txt_Path";
            txt_Path.Size = new Size(285, 23);
            txt_Path.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(518, 106);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pgBar
            // 
            pgBar.Location = new Point(12, 415);
            pgBar.Name = "pgBar";
            pgBar.Size = new Size(776, 23);
            pgBar.Style = ProgressBarStyle.Continuous;
            pgBar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 88);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 1;
            label1.Text = "Pasta onde planilhas se encontram";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F);
            label2.Location = new Point(263, 9);
            label2.Name = "label2";
            label2.Size = new Size(279, 32);
            label2.TabIndex = 0;
            label2.Text = "Conversor de planilhas";
            // 
            // btn_converter
            // 
            btn_converter.Location = new Point(309, 166);
            btn_converter.Name = "btn_converter";
            btn_converter.Size = new Size(152, 66);
            btn_converter.TabIndex = 5;
            btn_converter.Text = "Converter";
            btn_converter.UseVisualStyleBackColor = true;
            btn_converter.Click += btn_converter_Click;
            // 
            // chk_deletaOld
            // 
            chk_deletaOld.AutoSize = true;
            chk_deletaOld.Location = new Point(309, 141);
            chk_deletaOld.Name = "chk_deletaOld";
            chk_deletaOld.Size = new Size(163, 19);
            chk_deletaOld.TabIndex = 4;
            chk_deletaOld.Text = "Deleta arquivos originais ?";
            chk_deletaOld.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(309, 238);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(152, 66);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar XLS convertido";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btn_DeletaExtensao
            // 
            btn_DeletaExtensao.Location = new Point(636, 238);
            btn_DeletaExtensao.Name = "btn_DeletaExtensao";
            btn_DeletaExtensao.Size = new Size(152, 66);
            btn_DeletaExtensao.TabIndex = 7;
            btn_DeletaExtensao.Text = "Deletar arquivos de alguma extensão";
            btn_DeletaExtensao.UseVisualStyleBackColor = true;
            btn_DeletaExtensao.Click += btn_DeletaExtensao_Click;
            // 
            // txt_extensionDelete
            // 
            txt_extensionDelete.Location = new Point(636, 211);
            txt_extensionDelete.Name = "txt_extensionDelete";
            txt_extensionDelete.PlaceholderText = "Ex.: pdf";
            txt_extensionDelete.Size = new Size(152, 23);
            txt_extensionDelete.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(636, 193);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 9;
            label3.Text = "Extensão a ser deletada";
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Location = new Point(388, 397);
            lbl_Status.MinimumSize = new Size(400, 0);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(400, 15);
            lbl_Status.TabIndex = 10;
            lbl_Status.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Timer
            // 
            lbl_Timer.AutoSize = true;
            lbl_Timer.Location = new Point(12, 397);
            lbl_Timer.MinimumSize = new Size(100, 0);
            lbl_Timer.Name = "lbl_Timer";
            lbl_Timer.Size = new Size(100, 15);
            lbl_Timer.TabIndex = 11;
            lbl_Timer.Text = "00:00:00";
            lbl_Timer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            timer.Interval = 1;
            timer.Tick += timer_Tick;
            // 
            // ConverteXls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Timer);
            Controls.Add(lbl_Status);
            Controls.Add(label3);
            Controls.Add(txt_extensionDelete);
            Controls.Add(btn_DeletaExtensao);
            Controls.Add(btnDeletar);
            Controls.Add(chk_deletaOld);
            Controls.Add(btn_converter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pgBar);
            Controls.Add(btnBuscar);
            Controls.Add(txt_Path);
            MaximizeBox = false;
            Name = "ConverteXls";
            Text = "Conversor de planilha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserPlanilhas;
        private TextBox txt_Path;
        private Button btnBuscar;
        private ProgressBar pgBar;
        private Label label1;
        private Label label2;
        private Button btn_converter;
        private CheckBox chk_deletaOld;
        private Button btnDeletar;
        private Button btn_DeletaExtensao;
        private TextBox txt_extensionDelete;
        private Label label3;
        private Label lbl_Status;
        private Label lbl_Timer;
        private System.Windows.Forms.Timer timer;
    }
}
