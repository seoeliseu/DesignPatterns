namespace Memento
{
    public partial class NotePad : Form
    {
        private Cuidador _cuidador { get; set; }

        public NotePad()
        {
            InitializeComponent();
            _cuidador = new Cuidador(richTextBox1);
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_cuidador.IsDesfazer == false)
            {
                _cuidador.EditorTexto.Texto = richTextBox1.Text;
                _cuidador.EditorTexto.BackColor = richTextBox1.BackColor;
                _cuidador.Salvar();
            }
        }

        private void BtnDesfazer_Click(object sender, EventArgs e)
        {
            _cuidador.Desfazer();
        }

        private void BtnCancelarDesfazer_Click(object sender, EventArgs e)
        {

        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            richTextBox1.BackColor = ColorDialog.Color;
        }
    }
}
