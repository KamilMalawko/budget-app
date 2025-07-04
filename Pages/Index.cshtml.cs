using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BudgetApp.Models;

namespace BudgetApp.Pages;
public class IndexModel : PageModel {
    [BindProperty]
    public Expense NewExpense { get; set; }
    public static List<Expense> Expenses { get; set; } = new();

    public void OnGet() { }

    public IActionResult OnPost() {
        if (!ModelState.IsValid) return Page();
        Expenses.Add(NewExpense);
        return RedirectToPage();
    }
}
