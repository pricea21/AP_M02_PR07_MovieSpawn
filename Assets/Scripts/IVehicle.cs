using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovie 
{
    public Sprite AddMovie();
}
public class HungerGames : IMovie 
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("HungerGames");
    }
}
public class Divergent : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("Divergent");
    }
}
public class MazeRunner : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("MazeRunner");
    }
}
public class TheGiver : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("TheGiver");
    }
}
public class HarryPotter : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("HarryPotter");
    }
}
public class PercyJackson : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("PercyJackson");
    }
}
public class Twilight : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("Twilight");
    }
}
public class WizardOfOz : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("WizardOfOz");
    }
}
public class BlackWidow : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("BlackWidow");
    }
}
public class WonderWoman : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("WonderWoman");
    }
}
public class BlackAdam : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("BlackAdam");
    }
}
public class Thor : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("Thor");
    }
}
public class TombRaider : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("TombRaider");
    }
}
public class MonsterHunter : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("MonsterHunter");
    }
}
public class MarioMovie : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("MarioMovie");
    }
}
public class SonicMovie : IMovie
{
    public Sprite AddMovie()
    {
        return Resources.Load<Sprite>("Sonic");
    }
}
