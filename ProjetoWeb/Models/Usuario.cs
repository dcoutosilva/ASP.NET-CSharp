using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace ProjetoWeb.Models
{
    public class Usuario
    {
        //as requisições e regras de cada campo devem estar acima para elas serem atribuidas.
        [Required(ErrorMessage = "O Nome é Obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Quantidade mínima de 5 caracteres." )]
        public string Nome { get; set; }

        public string Observacoes { get; set; }

        //a condição sempre acima do campo get set
        [Range(18, 70, ErrorMessage ="A idade precisa ser entre 18 anos e 70 anos.")]
        //mesmo quando não houver 0 na frente, ele acaba escrevendo a mensagem de erro.
       // [RegularExpression(@"^(0+)", ErrorMessage ="Retirar o Zero na frente.")]
        public int Idade { get; set; }

        //Regex capturado de forma externa
        //teste os regex em www.regex101.com
        [RegularExpression(@"^[\w\.=-]+@[\w\.-]+\.[\w]{2,3}$", ErrorMessage ="Digite um e-mail válido")]
        public string Email { get; set; }

       // [RegularExpression(@"[a-zA-Z0-9]{5-10}", ErrorMessage ="Seu login deve apenas ter letras e números.")]
        [StringLength(10, MinimumLength = 5, ErrorMessage ="O Seu Login deve ter entre 5 a 10 caracteres.")]
        [Required(ErrorMessage ="O Login é Obrigatório.")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Esse Login já existe.")]
        public string Login { get; set; }

        [StringLength(15, MinimumLength = 8, ErrorMessage ="Quantidade mínima de 8 Caracteres.")]
        [Required(ErrorMessage ="A senha é obrigatória.")]
        public string Senha { get; set; }

        //verificações no usuarioController
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Os Endereços de e-mail não se coincidem.")]
        public string ConfirmaEmail { get; set; }

        //Verificações no UsuarioController
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage ="As senhas não se coincidem.")]
        public string ConfirmaSenha { get; set; }
    }
}