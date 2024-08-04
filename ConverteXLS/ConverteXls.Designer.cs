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
            folderBrowserPlanilhas = new FolderBrowserDialog();
            txt_Path = new TextBox();
            btnBuscar = new Button();
            pgBar = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            btn_converter = new Button();
            chk_deletaOld = new CheckBox();
            btnDeletar = new Button();
            btn_DeletaPdf = new Button();
            SuspendLayout();
            // 
            // txt_Path
            // 
            txt_Path.Location = new Point(227, 188);
            txt_Path.Name = "txt_Path";
            txt_Path.Size = new Size(285, 23);
            txt_Path.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(518, 188);
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
            label1.Location = new Point(227, 170);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 1;
            label1.Text = "Pasta onde planilhas se encontram";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F);
            label2.Location = new Point(261, 9);
            label2.Name = "label2";
            label2.Size = new Size(279, 32);
            label2.TabIndex = 0;
            label2.Text = "Conversor de planilhas";
            // 
            // btn_converter
            // 
            btn_converter.Location = new Point(298, 271);
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
            chk_deletaOld.Location = new Point(298, 255);
            chk_deletaOld.Name = "chk_deletaOld";
            chk_deletaOld.Size = new Size(163, 19);
            chk_deletaOld.TabIndex = 4;
            chk_deletaOld.Text = "Deleta arquivos originais ?";
            chk_deletaOld.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(214, 343);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(152, 66);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar XLS convertido";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btn_DeletaPdf
            // 
            btn_DeletaPdf.Location = new Point(372, 343);
            btn_DeletaPdf.Name = "btn_DeletaPdf";
            btn_DeletaPdf.Size = new Size(152, 66);
            btn_DeletaPdf.TabIndex = 7;
            btn_DeletaPdf.Text = "Deletar pdf sinapi";
            btn_DeletaPdf.UseVisualStyleBackColor = true;
            btn_DeletaPdf.Click += btn_DeletaPdf_Click;
            // 
            // ConverteXls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_DeletaPdf);
            Controls.Add(btnDeletar);
            Controls.Add(chk_deletaOld);
            Controls.Add(btn_converter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pgBar);
            Controls.Add(btnBuscar);
            Controls.Add(txt_Path);
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
        private Button btn_DeletaPdf;
    }
}
