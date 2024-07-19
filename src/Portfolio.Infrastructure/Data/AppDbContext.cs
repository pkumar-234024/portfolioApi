using System.Reflection;
using Ardalis.SharedKernel;
using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Modal;

namespace Portfolio.Infrastructure.Data;

public class AppDbContext : DbContext
{
  private readonly IDomainEventDispatcher? _dispatcher;

  public AppDbContext(DbContextOptions<AppDbContext> options,
    IDomainEventDispatcher? dispatcher)
      : base(options)
  {
    _dispatcher = dispatcher;
  }

  public DbSet<Contributor> Contributors => Set<Contributor>();
  public DbSet<Users> Users => Set<Users>();

  public DbSet<Projects> Projects => Set<Projects>();

  public DbSet<ProjectTechnologies> ProjectTechnologies => Set<ProjectTechnologies>();

  public DbSet<Skills> Skills => Set<Skills>();


  public DbSet<Tools> Tools => Set<Tools>();

  public DbSet<SocialMediaAccount> SocialMediaAccount => Set<SocialMediaAccount>();
  public DbSet<UserDocument> UserDocument => Set<UserDocument>();

  public DbSet<ErrorLogs> ErrorLogs => Set<ErrorLogs>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    // ignore events if no dispatcher provided
    if (_dispatcher == null) return result;

    // dispatch events only if save was successful
    var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
        .Select(e => e.Entity)
        .Where(e => e.DomainEvents.Any())
        .ToArray();

    await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges()
  {
    return SaveChangesAsync().GetAwaiter().GetResult();
  }
}
