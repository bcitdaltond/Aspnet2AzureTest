ApplicationDbContext

enable-migrations -ContextTypeName ApplicationDbContext -MigrationsDirectory Migrations\Country

add-migration -ConfigurationTypeName Lab3.Migrations.Country.Configuration "PInitialCreate"

update-database -ConfigurationTypeName Lab3.Migrations.Country.Configuration
