using BlazorMoviewReview.Models;

namespace BlazorMoviewReview.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}
