using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.Core.Base;
using ToDoList.Core.Helpers;
using ToDoList.Core.ViewModels.Controls;

namespace ToDoList.Core.ViewModels.Pages
{
    public class WorkTasksPageViewModel : BaseViewModel
    {
        public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();
        public string NewWorkTaskTitle { get; set; }
        public string NewWorkTaskDescription { get; set; }


        public ICommand AddNewTaskCommand { get; set; }
        public ICommand DeleteTaskCommand { get; set; }

        public WorkTasksPageViewModel()
        {
            AddNewTaskCommand = new RelayCommand(AddNewTask);
            DeleteTaskCommand = new RelayCommand(DeleteTask);
        }
        private void AddNewTask()
        {
            var newTask = new WorkTaskViewModel
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreatedDate = DateTime.Now,
            };

            WorkTaskList.Add(newTask);

            NewWorkTaskTitle = string.Empty;
            NewWorkTaskDescription = string.Empty;

            OnPropertyChanged(nameof(NewWorkTaskDescription));
            OnPropertyChanged(nameof(NewWorkTaskTitle));
        }

        private void DeleteTask()
        {
            for(int i = WorkTaskList.Count - 1; i>=0; i--)
            {
                if(WorkTaskList[i].IsSelected == true)
                {
                    WorkTaskList.RemoveAt(i);
                }
            }
        }
    }
}
