using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApiA.Controllers
{

    //---------------------------------------------------------------------------------------------------------------------
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase     //inheritance where Controller base is baseclass , TodoItemsController is the derived class
    {
        private readonly TodoContext _context;           //read only of private type of acess modifier ...why ..?

        public TodoItemsController(TodoContext context)  //method name TodoItemsController with one parameter of context
        {
            _context = context;
        }

//---------------------------------------------------------------------------------------------------------------------
        // GET: api/TodoItems  GET - READ
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            if (_context.TodoItems == null)
            {
                return NotFound();
            }
            return await _context.TodoItems.ToListAsync();
        }

//---------------------------------------------------------------------------------------------------------------------
        // GET: api/TodoItems/5 GET - READ USING ID 
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            if (_context.TodoItems == null)
            {
                return NotFound();
            }
            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }


        [HttpGet("{name}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(string name)
        {
            if (_context.TodoItems == null)
            {
                return NotFound();
            }
            var todoItem = await _context.TodoItems.FindAsync(name);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        } //how to us einbuilt function ..?  hoe to convert normal c sharp prograam into .net asp

        //---------------------------------------------------------------------------------------------------------------------
        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        //---------------------------------------------------------------------------------------------------------------------
        [HttpPost]  //POST - CREATE used to CREATE A NEW TABLE 
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id, salary = todoItem.Salary, }, todoItem);
        }

        //---------------------------------------------------------------------------------------------------------------------
        // DELETE: api/TodoItems/5 DELETE METHOD IS USED TO DELETE THE TABLE CONTENT BASED ON ID AS REFERENCE 
        [HttpDelete("{id}")]

        //async method is used in the method so as to enable use of await keyword in the method body
        //When the await keyword is applied, it suspends the calling method and yields control back to its caller until the awaited task is complete.
        public async Task<IActionResult> DeleteTodoItem(long id)
        {

            //i used to use else if case, but 2 ifs can also be used 
            if (_context.TodoItems == null)  //this statement checks if all the parameters are null or not, meaning if elements are present in table or not
            {
                return NotFound();
            }

            //this is to find id specifically as id is given as parameter and store its value in todoItem.
            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null) //now testing if todoItem is null or not 
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //---------------------------------------------------------------------------------------------------------------------
        private bool TodoItemExists(long id)
        {
            return (_context.TodoItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
