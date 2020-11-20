using BlazorWebAssembly.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Pages
{
    public partial class TaskList : ComponentBase
    {
        private List<TaskModel> taskList = new List<TaskModel>();
        private TaskModel newTask = new TaskModel();  

        [Parameter]
        public string Name { get; set; }
        private int percentDone
        {
            get
            {
                return (taskList.Count(t => t.IsComplete) * 100) / taskList.Count;
            }
        }

        private void AddTask()
        {
            taskList.Add(newTask);
            newTask = new TaskModel();
        }
    }
}
