using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.GetAll
{
    public class GetAllUseCase
    {
        public ResponseGetAllJson Execute()
        {
            return new ResponseGetAllJson
            {
                Tasks = new List<ResponseTaskJson>
                {
                    new ResponseTaskJson
                    {
                        Id = 1,
                        Name = "Study english",
                        DateLimit = new DateTime(year:2025, month:4, day:25),
                        Description = "I have to study english to pass the test",
                        Priority = Communication.Enums.Priority.High,
                        Status = Communication.Enums.Status.InProgress,
                    },
                    new ResponseTaskJson
                    {
                        Id = 2,
                        Name = "Do LeetCode Exercise number 1",
                        DateLimit = new DateTime(year: 2025, month: 6, day: 26),
                        Description = "I have to complete this exercise to improve my programming skills",
                        Priority = Communication.Enums.Priority.Low,
                        Status = Communication.Enums.Status.Waiting,
                    }
                }
            };

        }
    }
}
