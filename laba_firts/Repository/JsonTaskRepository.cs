using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using laba_firts.Model;
using laba_firts.Repository;

namespace laba_firts.Repository
{
    public class JsonTaskRepository : ITaskRepository
    {
        private string fileName = "tasks.json";

        public void Save(List<TodoModel> tasks)
        {
            string text = JsonSerializer.Serialize(tasks);
            File.WriteAllText(fileName, text);
        }

        public List<TodoModel> Load()
        {
            if (File.Exists(fileName) == false)
            {
                return new List<TodoModel>();
            }

            string text = File.ReadAllText(fileName);
            List<TodoModel> tasks = JsonSerializer.Deserialize<List<TodoModel>>(text);

            return tasks;
        }
    }
}
