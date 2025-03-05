using Microsoft.EntityFrameworkCore;

namespace ToDo.Infrastructure.DataContext;

public class ToDoContext :  DbContext{
    
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
    {
        
    }
    
}