using System.ComponentModel.DataAnnotations;

namespace ExpensiveControlApp.DTOs
{
    public class CreateExpensiveDTO
    {
        public CreateExpensiveDTO()
        {
            Date = DateTime.Now;
        }

        [Required(ErrorMessage = "Descricao é obrigatoria.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Valor é obrigatorio.")]
        [Range(0.01, 999999999, ErrorMessage = "Valor deve ser maior que 0.")]
        public double Value { get; set; }

        [Required(ErrorMessage = "Data é obrigatoria.")]
        public DateTime Date { get; set; }
    }
}
