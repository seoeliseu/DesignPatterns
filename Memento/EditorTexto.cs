namespace Memento
{
    public class EditorTexto(Color color)
    {
        public Color BackColor { get; set; } = color;
        public string Texto { get; set; } = "";

        public Memento Save()
        {
            return new Memento(Texto.Substring(0, Texto.Length - 1), BackColor);
        }

        public void Desfazer(Memento memento)
        {
            Texto = memento.Texto;
            BackColor = memento.BackColor;
        }

        public class Memento(string texto, Color color)
        {
            public Color BackColor { get; set; } = color;
            public string Texto { get; set; } = texto;
        }
    }


}
