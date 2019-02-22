using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie
{
    internal class RazorPagesMovieContext
    {
        private DbContextOptions<RazorPagesMovieContext> dbContextOptions;

        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> dbContextOptions)
        {
            this.dbContextOptions = dbContextOptions;
        }
    }
}