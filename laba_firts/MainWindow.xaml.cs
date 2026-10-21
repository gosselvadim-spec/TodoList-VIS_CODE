using laba_firts.Model;
using laba_firts.Service;
using System.Windows;

namespace laba_firts
{
    public partial class MainWindow : Window
    {
        private TodoService _service = new TodoService();

        public MainWindow()
        {
            InitializeComponent();

            if (MessageBox.Show("Загрузить сохраненные задачи?", "Запуск", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                _service.Load();
            }
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            GridTasks.ItemsSource = null;
            GridTasks.ItemsSource = _service.tasks;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Введите название:", "Новая задача", "");
            if (string.IsNullOrWhiteSpace(name)) return;

            var task = new TodoModel();
            task.name = name;
            _service.Add(task);
            UpdateGrid();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (GridTasks.SelectedItem is TodoModel selectedTask)
            {
                _service.Delete(selectedTask);
                UpdateGrid();
            }
            else
            {
                MessageBox.Show("Сначала выделите задачу в таблице!");
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            _service.Save();
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            _service.Load();
            UpdateGrid();
        }
    }
}