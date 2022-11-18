using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using GDIHackathonRecipeApp.Models;

namespace GDIHackathonRecipeApp.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {

    }

    public DbSet<Cookbook> Cookbooks { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<DietaryRestriction> DietaryRestrictions { get; set; }
}

