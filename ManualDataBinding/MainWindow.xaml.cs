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
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Creating the note for our editor
        /// </summary>
        Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.note = note;
        }

        /// <summary>
        /// Event handler to create a new noter and apply it to the editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnNewNode(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.note = note;
           
        }

        /// <summary>
        /// Event handler to clear the contents of the note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
            
        }


        /// <summary>
        /// Event handler to mutate a note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "Procrastination";
            note.Body = "I am an expert in procrastination and online classes are difficult";
        }
    }
}
