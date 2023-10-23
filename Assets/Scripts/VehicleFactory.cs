using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovieFactory
{
    IMovie Create(MovieRequirements requirements);
}

public class GenreFactory : IMovieFactory
{
    public IMovie Create(MovieRequirements requirements)
    {
        switch (requirements.MovieGenres)
        {
            case 1:
                if (requirements.MovieGenres == 1)
                {
                    if (requirements.Longer)
                    {
                        return new HarryPotter();
                    }
                    
                }
                return new PercyJackson();

            case 2:
                if (requirements.MovieGenres == 2)
                {
                    if (requirements.Longer)
                    {
                        return new MazeRunner();
                    }
                    
                }
                return new TheGiver();

            case 3:
                if (requirements.MovieGenres == 3)
                {
                    if (requirements.Longer)
                    {
                        return new BlackAdam();
                    }
                    
                }
                return new Thor();

            case 4:
                if (requirements.MovieGenres == 4) 
                {
                    if (requirements.Longer)
                    {
                        return new SonicMovie();
                    }
                    
                }
                return new MarioMovie();

            default:
                return new PercyJackson();
        }
    }
}

public class MainCharacterGenderFactory : IMovieFactory
{
    public IMovie Create(MovieRequirements requirements)
    {
        switch (requirements.MovieGenres)
        {
            case 1:
                if (requirements.MovieGenres == 1)
                {
                    if (requirements.Longer)
                    {
                        return new Twilight();
                    }
                   
                }
                return new WizardOfOz();

            case 2:
                if (requirements.MovieGenres == 2)
                {
                    if (requirements.Longer)
                    {
                        return new HungerGames();
                    }
                    
                }
                return new Divergent();


            case 3:
                if (requirements.MovieGenres == 3)
                {
                    if (requirements.Longer)
                    {
                        return new WonderWoman();
                    }
                    
                }
                return new BlackWidow();

            case 4:
                if (requirements.MovieGenres == 4)
                {
                    if (requirements.Longer)
                    {
                        return new TombRaider();
                    }
                    
                }
                return new MonsterHunter();

            default:
                return new WizardOfOz();
        }
    }
}

public abstract class AbstractMovieFactory
{
    public abstract IMovie Create();
}



public class VehicleFactory : AbstractMovieFactory
{
    private readonly IMovieFactory _factory;
    private readonly MovieRequirements _requirements;

    public VehicleFactory(MovieRequirements requirements)
    {
        _factory = requirements.Gender ? (IMovieFactory)new MainCharacterGenderFactory() : new GenreFactory();
        //_factory = requirements.Longer ? (IMovieFactory)new MainCharacterGenderFactory() : new GenreFactory();
        _requirements = requirements;
    }

    public override IMovie Create()
    {
        return _factory.Create(_requirements);
    }
}
