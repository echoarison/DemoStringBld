using System;
using System.Collections.Generic;   //usando a List
using System.Text;

namespace StringBuilderDemo.Entities
{
    internal class Post
    {
        //atributos(AutoProprietes)
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        /**
         * 
         * Sempre inicia a lista para não da o "erro" de list null
         * 
         **/
        public List<Comment> Comments { get; set; } = new List<Comment>();//composicao da duas classe

        //construtor
        public Post() 
        { 
        }

        /**
         * 
         * De um modo generico o Atributos comments ele não
         * vai ser passado pelo construtor
         * 
         **/
        public Post(DateTime moment, string title, string content, int like)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = like;
        }

        /**
         * 
         * Quando tem um caso de 1 para muitos é normal adicionar 
         * add e remove
         * 
         **/
        //Methods
        public void AddComment(Comment comment) 
        {
            //essa operação vai fazer é add na minha lista de Comment
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) {

            //essa operação vai fazer é remover na minha lista de Comment
            Comments.Remove(comment);

        }

        //override ToString() mais complexo
        public override string ToString()
        {
            /**
             * 
             * StringBuilder ele vai ser responsavel por construir a string
             * conforme que vc mandar de forma legal e ele pertence
             * a using System.Text ele vai ter varaias operações para
             * montar o text
             * 
             **/
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);   //imprimi e quebra de linha
            sb.Append(Likes); //imprimi na mesma linha sem quebra
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            //fazendo um foreach para percorrer e add
            foreach (Comment item in Comments)
            {
                sb.AppendLine(item.Text);
            }

            return sb.ToString();

        }
    }
}
