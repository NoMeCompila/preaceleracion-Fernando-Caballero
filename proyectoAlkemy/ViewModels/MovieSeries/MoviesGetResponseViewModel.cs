﻿namespace proyectoAlkemy.ViewModels.MovieSeries
{
    //view model de salida
    public class MoviesGetResponseViewModel
    {
        public string? Image { get; set; }
        public string? Title { get; set; }
        public DateTime Release_Year { get; set; }
        public int Ranking { get; set; }
        //lista solo cion los id de las peliculas
        
        public List<int> GenresIDs { get; set; } = new List<int>(); 
    }
}
