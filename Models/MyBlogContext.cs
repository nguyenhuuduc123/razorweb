using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

   public class MyBlogContext :IdentityDbContext<AppUser>{

    public MyBlogContext(DbContextOptions<MyBlogContext> options):base(options){

    }   
    protected override void OnConfiguring(DbContextOptionsBuilder buider){
        base.OnConfiguring(buider);
    }
   public DbSet<Article> articles {set;get;}
   protected override void OnModelCreating(ModelBuilder modelBuilder){
       base.OnModelCreating(modelBuilder);
       foreach(var entitytype in  modelBuilder.Model.GetEntityTypes()){
                var tableName = entitytype.GetTableName();
                if(tableName.StartsWith("AspNet")){
                    entitytype.SetTableName(tableName.Substring(6));
                }
       }
   }
}