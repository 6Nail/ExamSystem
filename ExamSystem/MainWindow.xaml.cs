using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ExamSystem
{
    public partial class MainWindow : Window
    {
        public StringBuilder strbild;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void LaunchBtnClick(object sender, RoutedEventArgs e)
        {
            strbild = new StringBuilder(4000);
            for (int i = 0; i < 1000; i++)
            {
                AddNums(i);
            }
            MessageBox.Show(strbild.ToString());
            //AddDb();
            Save();
        }
        public async void Save()
        {
            using (StreamWriter sw = new StreamWriter("Report.txt"))
            {
                string date = DateTime.Now.ToString() + strbild.ToString();
                await sw.WriteAsync(date);
            }
        }
        public async void AddDb()
        {
            using (var context = new Context())
            {
                context.Results.Add(new Result { Value = strbild.ToString() });
                await context.SaveChangesAsync();
            }
        }
        public async void AddNums(int num)
        {
            await Task.Run(() =>
            {
                strbild.Append(" " + num.ToString());
            });
        }       
    }
}