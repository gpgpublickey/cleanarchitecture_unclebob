﻿using Agenda.UseCases.Interfaces;
using Agenda.UseCases.Todo.AddTodoTask.Models;

namespace Agenda.UseCases.Todo.AddTodoTask.Interfaces
{
    public interface IInputPort : IPort<InputDataRequest>
    {
        OutputDataResponse Response { get; set; }
    }
}
