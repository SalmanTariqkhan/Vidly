namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies (Name,ReleasedDate,AddedDate,GenreId,NumberInStock) values ('The Grudge (2020)','1/3/2020','1/5/2020',1,200)");
            Sql("Insert into Movies (Name,ReleasedDate,AddedDate,GenreId,NumberInStock) values ('The Turning (2020)','1/24/2020','1/25/2019',1,150)");
            Sql("Insert into Movies (Name,ReleasedDate,AddedDate,GenreId,NumberInStock) values ('Bad Boys for Life (2020)','1/17/2020','1/18/2020',3,200)");
            Sql("Insert into Movies (Name,ReleasedDate,AddedDate,GenreId,NumberInStock) values ('The Mandalorian ','11/12/2019','11/13/2019',4,500)");
            Sql("Insert into Movies (Name,ReleasedDate,AddedDate,GenreId,NumberInStock) values ('The Outsider ','1/12/2020','1/13/2020',2,200)");

        }

        public override void Down()
        {
        }
    }
}
