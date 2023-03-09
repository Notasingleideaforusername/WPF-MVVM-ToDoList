using System.Windows.Controls;
using ToDoList.Core;
using ToDoList.Core.ViewModels.Pages;

namespace WPF_CRUD_1
{
    /// <summary>
    /// Interaction logic for WorkTaskPage.xaml
    /// </summary>
    public partial class WorkTaskPage : Page
    {
        public WorkTaskPage()
        {
            InitializeComponent();

            DataContext = new WorkTasksPageViewModel();
        }
    }
}
