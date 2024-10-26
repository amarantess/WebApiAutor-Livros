namespace WebApiAutor_Livros.Models
{
    // Classe que irá enviar as respostas da requisição, ela irá responder sendo para Autor ou Livros
    public class ResponseModel<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
       
    }
}
