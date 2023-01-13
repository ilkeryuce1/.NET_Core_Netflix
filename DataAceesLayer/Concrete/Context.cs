using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAceesLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-QJ144O6\\SQLEXPRESS; database=Netflix; integrated security=true;TrustServerCertificate=True");
        }





        public DbSet<Account> Tbl_Accounts { get; set; }
        public DbSet<AccountKind> Tbl_AccountKinds { get; set; }
        public DbSet<CommentRated> Tbl_CommentRateds { get; set; }
        public DbSet<Movie> Tbl_Movies { get; set; }
        public DbSet<MovieKind> Tbl_MovieKinds { get; set; }
        public DbSet<Packet> Tbl_Packets { get; set; }
    }
}
