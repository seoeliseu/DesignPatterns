namespace Command
{
    partial class Command
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
            BtnProcessarPedido = new Button();
            BtnProcessarPagamento = new Button();
            LogCommands = new RichTextBox();
            BtnExecutarFila = new Button();
            BtnProcessarDevolucao = new Button();
            BtnLimparLog = new Button();
            SuspendLayout();
            // 
            // BtnProcessarPedido
            // 
            BtnProcessarPedido.Location = new Point(12, 12);
            BtnProcessarPedido.Name = "BtnProcessarPedido";
            BtnProcessarPedido.Size = new Size(150, 30);
            BtnProcessarPedido.TabIndex = 0;
            BtnProcessarPedido.Text = "Processar Pedido";
            BtnProcessarPedido.UseVisualStyleBackColor = true;
            BtnProcessarPedido.Click += BtnProcessarPedido_Click;
            // 
            // BtnProcessarPagamento
            // 
            BtnProcessarPagamento.Location = new Point(164, 12);
            BtnProcessarPagamento.Name = "BtnProcessarPagamento";
            BtnProcessarPagamento.Size = new Size(146, 30);
            BtnProcessarPagamento.TabIndex = 1;
            BtnProcessarPagamento.Text = "Processar Pagamento";
            BtnProcessarPagamento.UseVisualStyleBackColor = true;
            BtnProcessarPagamento.Click += BtnProcessarPagamento_Click;
            // 
            // LogCommands
            // 
            LogCommands.BorderStyle = BorderStyle.None;
            LogCommands.Location = new Point(12, 48);
            LogCommands.Name = "LogCommands";
            LogCommands.Size = new Size(776, 390);
            LogCommands.TabIndex = 4;
            LogCommands.Text = "";
            // 
            // BtnExecutarFila
            // 
            BtnExecutarFila.BackColor = Color.Salmon;
            BtnExecutarFila.Location = new Point(460, 12);
            BtnExecutarFila.Name = "BtnExecutarFila";
            BtnExecutarFila.Size = new Size(146, 30);
            BtnExecutarFila.TabIndex = 3;
            BtnExecutarFila.Text = "Executar Fila Operações";
            BtnExecutarFila.UseVisualStyleBackColor = false;
            BtnExecutarFila.Click += BtnExecutarFila_Click;
            // 
            // BtnProcessarDevolucao
            // 
            BtnProcessarDevolucao.Location = new Point(312, 12);
            BtnProcessarDevolucao.Name = "BtnProcessarDevolucao";
            BtnProcessarDevolucao.Size = new Size(146, 30);
            BtnProcessarDevolucao.TabIndex = 2;
            BtnProcessarDevolucao.Text = "Processar Devolução";
            BtnProcessarDevolucao.UseVisualStyleBackColor = true;
            BtnProcessarDevolucao.Click += BtnProcessarDevolucao_Click;
            // 
            // BtnLimparLog
            // 
            BtnLimparLog.Location = new Point(642, 12);
            BtnLimparLog.Name = "BtnLimparLog";
            BtnLimparLog.Size = new Size(146, 30);
            BtnLimparLog.TabIndex = 5;
            BtnLimparLog.Text = "Limpar Log";
            BtnLimparLog.UseVisualStyleBackColor = true;
            BtnLimparLog.Click += BtnLimparLog_Click;
            // 
            // Command
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLimparLog);
            Controls.Add(BtnProcessarDevolucao);
            Controls.Add(BtnExecutarFila);
            Controls.Add(LogCommands);
            Controls.Add(BtnProcessarPagamento);
            Controls.Add(BtnProcessarPedido);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Command";
            Text = "Exemplo Commands";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnProcessarPedido;
        private Button BtnProcessarPagamento;
        private RichTextBox LogCommands;
        private Button BtnExecutarFila;
        private Button BtnProcessarDevolucao;
        private Button BtnLimparLog;
    }
}
