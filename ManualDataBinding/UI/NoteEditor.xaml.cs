using System;
using System.Collections.Generic;
using System.Text;
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

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    {

        private Note noteBacking;

        /// <summary>
        /// The note that will be edited by this control
        /// </summary>
        public Note note
        {
            get
            {
                return noteBacking;
            }
            set
            {
                if (noteBacking != null) noteBacking.NoteChanged -= OnNoteChange;
                noteBacking = value;
                if (noteBacking != null)
                {
                    noteBacking.NoteChanged += OnNoteChange;
                    OnNoteChange(noteBacking, new EventArgs());
                }
            }
        }
        public NoteEditor()
        {
            InitializeComponent();
        }

        public void OnNoteChange(object sender, EventArgs e)
        {
            if (note == null) return;
            Title.Text = note.Title;
            Body.Text = note.Body;
        }

        public void OnTitleChanged(object sender, TextChangedEventArgs e)
        {
            note.Title = Title.Text;
        }

        public void OnBodyChanged(object sender, TextChangedEventArgs e)
        {
            note.Body = Body.Text;
        }
    }
}
