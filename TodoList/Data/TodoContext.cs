﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using TodoList.Models;

namespace TodoList.Data
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
