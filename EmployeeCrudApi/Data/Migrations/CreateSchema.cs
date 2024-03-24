using FluentMigrator;

namespace EmployeeCrudApi.Data.Migrations
{
    [Migration(03032024)]
    public class CreateSchema : Migration
    {
        public override void Up()
        {
            Create.Table("employees")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("full_name").AsString(128).NotNullable()
                .WithColumn("position").AsString(128).NotNullable()
                .WithColumn("department").AsString(128).NotNullable()
                .WithColumn("date_of_birth").AsDateTime().NotNullable()
                .WithColumn("salary").AsDouble().NotNullable();
        }

        public override void Down()
        {
           
        }
    }
}
