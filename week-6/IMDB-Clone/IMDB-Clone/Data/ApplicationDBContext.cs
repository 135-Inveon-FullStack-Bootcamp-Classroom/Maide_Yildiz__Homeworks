﻿using IMDB_Clone.Entities;
using Microsoft.EntityFrameworkCore;

namespace IMDB_Clone
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>().HasKey(mc => new { mc.ActorId,mc.MovieId });

            modelBuilder.Entity<MovieActor>()
                .HasOne<Movie>(mc => mc.Movie)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(mc => mc.MovieId);


            modelBuilder.Entity<MovieActor>()
                .HasOne<Actor>(ma=>ma.Actor)
                .WithMany(a => a.MovieActors)
                .HasForeignKey(mc => mc.ActorId);
        }
        //public DbSet<ICrew> Crew { get; set; }
        public DbSet<Movie> Movies { get;set;}
        public DbSet<Actor> Actors { get;set;}
        public DbSet<Writer> Writers { get;set;}
        public DbSet<Director> Directors { get;set;}
    }
}
