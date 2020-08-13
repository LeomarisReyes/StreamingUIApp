using System;
using System.Collections.ObjectModel;
using StreamingUIApp.Models;

namespace StreamingUIApp.ViewModels
{
    public class MovieViewModel
    {
        public ObservableCollection<Movie> movie { get; set; }

        public MovieViewModel()
        {
            movie = new ObservableCollection<Movie>
            {
                new Movie { MoviePicture = "Movie0"},
                new Movie { MoviePicture = "Movie1"},
                new Movie { MoviePicture = "Movie2"},
                new Movie { MoviePicture = "Movie3"},
                new Movie { MoviePicture = "Movie4"},
                new Movie { MoviePicture = "Movie5"}  
            }; 
        }
    }
}
