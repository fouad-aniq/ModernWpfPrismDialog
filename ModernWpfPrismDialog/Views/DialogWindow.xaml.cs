using ModernWpf;
using ModernWpf.Controls;
using Prism.Services.Dialogs;
using System;
using System.ComponentModel;

namespace ModernWpfPrismDialog.Views
{
    /// <summary>
    /// Logique d'interaction pour DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : ContentDialog, IDialogWindow
    {
        public DialogWindow()
        {
            InitializeComponent();
        }

        public IDialogResult Result { get; set; }

        event EventHandler IDialogWindow.Closed
        {
            add
            {
                
            }

            remove
            {

            }
        }

        event CancelEventHandler IDialogWindow.Closing
        {
            add
            {

            }

            remove
            {

            }
        }

        public void Close()
        {

        }

        public void Show()
        {
            ShowAsync();
        }

        public bool? ShowDialog()
        {
            ShowAsync();

            return false;
        }
    }
}
