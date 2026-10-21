using System;
using System.Collections.Generic;
using System.Text;
using laba_firts.Model;
using laba_firts.Repository;

namespace laba_firts.Service
{
    public class TodoService
    {
        private ITaskRepository _taskrepository;

        public List<TodoModel> tasks;

        public TodoService()
        {
            _taskrepository = new JsonTaskRepository();
            tasks = new List<TodoModel>();
        }
        public void Add(TodoModel task)
        {
            tasks.Add(task);
        }

        public void Delete(TodoModel task)
        {
            tasks.Remove(task);
        }

        public void Save()
        {
            _taskrepository.Save(tasks);
        }

        public void Load()
        {
            tasks = _taskrepository.Load();
        }
    }

}
