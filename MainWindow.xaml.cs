using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfEjednevnik
{
    public partial class MainWindow : Window
    {
        public List<Note> notes = new List<Note>();
        private string filePath = "notes.json";

        public MainWindow()
        {
            InitializeComponent();
            LoadNotes();
            datePicker.SelectedDate = DateTime.Today;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedNote = listBox.SelectedItem as Note;
            if (selectedNote != null)
            {
                titleTextBox.Text = selectedNote.Title;
                descriptionTextBox.Text = selectedNote.Description;
            }
        }

        private void LoadNotes()
        {
            if (File.Exists(filePath))
            {
                notes = NoteSerializer.Deserialize<List<Note>>(filePath);
            }
        }

        private void SaveNotes()
        {
            NoteSerializer.Serialize(notes, filePath);
        }

        private void UpdateNoteList()
        {
            DateTime selectedDate = datePicker.SelectedDate ?? DateTime.Today;
            var notesForSelectedDate = notes.Where(n => n.Date.Date == selectedDate.Date).ToList();
            listBox.ItemsSource = notesForSelectedDate;
        }

        private void datePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateNoteList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var newNote = new Note
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                Date = datePicker.SelectedDate ?? DateTime.Today
            };

            notes.Add(newNote);
            SaveNotes();
            UpdateNoteList();

            titleTextBox.Clear();
            descriptionTextBox.Clear();

            MessageBox.Show($"Название: {newNote.Title}\nОписание: {newNote.Description}", "Новая заметка добавлена", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedNote = listBox.SelectedItem as Note;
            if (selectedNote != null)
            {
                selectedNote.Title = titleTextBox.Text;
                selectedNote.Description = descriptionTextBox.Text;
                SaveNotes();
                UpdateNoteList();
            }
        }
        private void viewButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedNote = listBox.SelectedItem as Note;
            if (selectedNote != null)
            {
                titleTextBox.Text = selectedNote.Title;
                descriptionTextBox.Text = selectedNote.Description;
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedNote = listBox.SelectedItem as Note;
            if (selectedNote != null)
            {
                notes.Remove(selectedNote);
                SaveNotes();
                UpdateNoteList();
            }
        }
    }
}