using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication3
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        int i;
        public List<Todo> list1= new List<Todo>();

        private void TextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
               
                
                list1.Add(new Todo(i, TextBox1.Text));
                
               Label lb1 = new Label();
                lb1.Name = "label" + i;
                lb1.Content = i + ". " + list1[i].todo;
                wrap1.Children.Add(lb1);

                CheckBox ch1 = new CheckBox();
                ch1.Name = "checkbox" + i;
                ch1.Content = "Выполнено?";
                ch1.Checked+=new RoutedEventHandler(ch1_check);
                wrap1.Children.Add(ch1);

                //wrap1.Children.Add(new Label() { Name = "label" + i, Content = i+". "+ TextBox1.Text});
                //wrap1.Children.Add(new CheckBox() { Name = "checkbox" + i, Content ="Выполнено?"});

                i++;
            }
        }

        public void ch1_check(object sender, RoutedEventArgs e)
        {
            wrap1.Children.RemoveAt(2*i);
            wrap1.Children.RemoveAt(2*i);
            i--;
 /*           int q = 0;
            while (q <= i)
            {
                if (list1[q].done == true)
                {
                                    MessageBox.Show(q+" ");
                    wrap1.Children.RemoveAt(q);
                    wrap1.Children.RemoveAt(q);
                    list1.Remove(list1[q]);
                }
                q++;
            }
*/
              
        }


        public class Todo
        {
            public int n;
            public string todo;
            public bool done;
               
       
            public Todo(int num, string el)
            {
                n = num;
                todo = el;
                done = false;
          
            }
            
            public void AddNewTodo()
            {
                
  
            }

            public void RemElem()
            {
                
            }

            public void ReDraw()
            { 
            
            }
        }

      

    }

    
        
}
