using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class ArticleCardViewModel
    {
        private Article _selectedArticle;
        public Article SelectedArticle
        {
            get => _selectedArticle;
            set { _selectedArticle = value; OnPropertyChanged(nameof(SelectedArticle)); }
        }

        // Load this from your service, DB, etc.
        public ArticleCardViewModel()
        {
            SelectedArticle = new Article(); // Fill in real data
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
    
}
