using ExpensiveControlApp.Models.Expensives;

namespace ExpensiveControlApp.Services
{
    public interface IExpensiveService
    {
        Task Create(DTOs.CreateExpensiveDTO createExpensiveDTO);

        Task<List<Expensive>> FindBy(DateTime startDate, DateTime endDate);
    }
}
