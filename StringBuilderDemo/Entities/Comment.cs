
namespace StringBuilderDemo.Entities
{
    internal class Comment
    {
        //atributos(usando o AutoPropreites)
        public string Text { get; set; }

        //construtor
        public Comment() { }

        public Comment(string text) //usando o generetor construtor(ferramenta do C#)
        {
            Text = text;
        }
    }
}
