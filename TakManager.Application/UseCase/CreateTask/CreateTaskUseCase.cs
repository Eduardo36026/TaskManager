using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.CreateTask
{
    public class CreateTaskUseCase
    {
        public ResponseTaskJson Execute(RequestTaskJson request)
        {
            return new ResponseTaskJson
            {
                Id = 1,
                Name = request.Name,
                DateLimit = request.DateLimit,
                Description = request.Description,
                Priority = request.Priority,
                Status = request.Status,

            };
        }
    }
}
