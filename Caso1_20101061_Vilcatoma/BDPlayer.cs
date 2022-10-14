using Microsoft.EntityFrameworkCore;

namespace Caso1_20101061_Vilcatoma
{
    public class BDPlayer: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Windows Authentications
            var cnx = "Server=LAPTOP-L2HIARQP;Database=BDPlayer;Integrated Security=true";
            optionsBuilder
                .UseSqlServer(cnx)
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

        public virtual DbSet<Player> Player { get; set; }
    }
}
