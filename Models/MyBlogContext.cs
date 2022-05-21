using Microsoft.EntityFrameworkCore;

   public class MyBlogContext :DbContext{

    public MyBlogContext(DbContextOptions<MyBlogContext> options):base(options){

    }   
    protected override void OnConfiguring(DbContextOptionsBuilder buider){
        base.OnConfiguring(buider);
    }
   public DbSet<Article> articles {set;get;}
   protected override void OnModelCreating(ModelBuilder modelBuilder){
       base.OnModelCreating(modelBuilder);
   }
}