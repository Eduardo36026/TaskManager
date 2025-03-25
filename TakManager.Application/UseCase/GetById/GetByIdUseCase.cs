using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.GetById
{
    public class GetByIdUseCase
    {
        public ResponseTaskJson Execute(int id)
        {
            return new ResponseTaskJson
            {
                Id = id,
                Name = "Study english",
                DateLimit = new DateTime(year: 2025, month: 4, day: 25),
                Description = "I have to study english to pass the test",
                Priority = Communication.Enums.Priority.High,
                Status = Communication.Enums.Status.InProgress,

            };
        }
    }
}
