using System;
using System.Collections.Generic;
using System.Text;
using laba_firts.Model;

namespace laba_firts.Repository
{
    public interface ITaskRepository
    {
        void Save(List<TodoModel> tasks);
        List<TodoModel> Load();
    }
}
