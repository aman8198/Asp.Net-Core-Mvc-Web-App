using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BorrowerList1.Models.ViewModels
{
    public class ExpenseVM
    {
        public Expense Expense { get; set; }
        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
