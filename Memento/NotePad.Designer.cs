namespace Memento
{
    partial class NotePad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePad));
            richTextBox1 = new RichTextBox();
            BtnDesfazer = new Button();
            ColorDialog = new ColorDialog();
            BtnChangeColor = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(5, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(790, 377);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += RichTextBox1_TextChanged;
            // 
            // BtnDesfazer
            // 
            BtnDesfazer.Location = new Point(4, 5);
            BtnDesfazer.Name = "BtnDesfazer";
            BtnDesfazer.Size = new Size(100, 30);
            BtnDesfazer.TabIndex = 0;
            BtnDesfazer.Text = "Desfazer";
            BtnDesfazer.UseVisualStyleBackColor = true;
            BtnDesfazer.Click += BtnDesfazer_Click;
            // 
            // BtnChangeColor
            // 
            BtnChangeColor.Location = new Point(110, 5);
            BtnChangeColor.Name = "BtnChangeColor";
            BtnChangeColor.Size = new Size(100, 30);
            BtnChangeColor.TabIndex = 1;
            BtnChangeColor.Text = "Change Color";
            BtnChangeColor.UseVisualStyleBackColor = true;
            BtnChangeColor.Click += BtnChangeColor_Click;
            // 
            // NotePad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnChangeColor);
            Controls.Add(BtnDesfazer);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NotePad";
            Text = "Notepad";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnDesfazer;
        private ColorDialog ColorDialog;
        private Button BtnChangeColor;
    }
}
