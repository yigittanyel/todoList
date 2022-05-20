using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListCore.Data;

namespace TodoListCore.Controllers
{
    public class TodoDeneme : Controller
    {
        private readonly Context _context;
        //public TodoController(Context context)
        //{
        //    _context = context;
        //}
        //public async Task<IActionResult> TodoList()
        //{
        //    return _context.Todos != null ?
        //                  View(await _context.Todos.ToListAsync()) :
        //                  Problem("Entity set 'Context.Todos'  is null.");
        //}
    }
}
