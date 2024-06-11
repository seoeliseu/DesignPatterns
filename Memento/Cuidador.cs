namespace Memento
{
    public class Cuidador(RichTextBox richTextBox)
    {
        public bool IsDesfazer { get; set; } = false;
        public RichTextBox RichTextBox { get; set; } = richTextBox;
        public List<EditorTexto.Memento> Mementos { get; set; } = [];
        public EditorTexto EditorTexto { get; set; } = new EditorTexto(richTextBox.BackColor);

        public void Desfazer()
        {
            if (Mementos.Count > 0)
            {
                var memento = Mementos.Last();
                Mementos.Remove(memento);
                IsDesfazer = true;
                EditorTexto.Desfazer(memento);
                RichTextBox.Text = EditorTexto.Texto;
                RichTextBox.BackColor = EditorTexto.BackColor;
                IsDesfazer = false;
            }
        }

        public void Salvar()
        {
            Mementos.Add(EditorTexto.Save());
        }
    }
}
