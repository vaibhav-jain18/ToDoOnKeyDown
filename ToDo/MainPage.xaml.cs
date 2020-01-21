using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ToDo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const string V = " ";
         String[] ToDoList = new string[9];
        int i=0;
        public MainPage()
        {
            this.InitializeComponent();

            txt.Text = V;
            txt2.Text = V;
            txt3.Text = V;
            txt4.Text =V;
            txt5.Text = V;
            txt6.Text = V; txt8.Text = V;
            txt7.Text = V;
            

        }

        private void buttonclick(object sender, RoutedEventArgs e)
        {
            // ToDoList.Append(inp.Text);

            if (i < 9)
            {
                ToDoList[i] = inp.Text;
                i++;
                if (ToDoList[0] != null)
                    txt.Text = ToDoList[0];
                if (ToDoList[1] != null)
                    txt1.Text = ToDoList[1];
                if (ToDoList[2] != null)
                    txt2.Text = ToDoList[2];
                if (ToDoList[3] != null)
                    txt3.Text = ToDoList[3];
                if (ToDoList[4] != null)
                    txt4.Text = ToDoList[4];
                if (ToDoList[5] != null)
                    txt5.Text = ToDoList[5];
                if (ToDoList[6] != null)
                    txt6.Text = ToDoList[6];
                if (ToDoList[7] != null)
                    txt7.Text = ToDoList[7];
                if (ToDoList[8] != null)
                    txt8.Text = ToDoList[8];

                inp.Text = V;
                if (i == 9)
                    i = 0;
            }
            
        }

        private void Enter_key(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key==Windows.System.VirtualKey.Enter && inp.Text.Trim().Length>0)
            {
                if (i < 9)

                {
                    ToDoList[i] = inp.Text;
                    i++;
                    if (ToDoList[0] != null)
                        txt.Text = ToDoList[0];
                    if (ToDoList[1] != null)
                        txt1.Text = ToDoList[1];
                    if (ToDoList[2] != null)
                        txt2.Text = ToDoList[2];
                    if (ToDoList[3] != null)
                        txt3.Text = ToDoList[3];
                    if (ToDoList[4] != null)
                        txt4.Text = ToDoList[4];
                    if (ToDoList[5] != null)
                        txt5.Text = ToDoList[5];
                    if (ToDoList[6] != null)
                        txt6.Text = ToDoList[6];
                    if (ToDoList[7] != null)
                        txt7.Text = ToDoList[7];
                    if (ToDoList[8] != null)
                        txt8.Text = ToDoList[8];

                    inp.Text = V;
                    if (i == 9)
                        i = 0;
                }
                
            }
        }
    }
}
