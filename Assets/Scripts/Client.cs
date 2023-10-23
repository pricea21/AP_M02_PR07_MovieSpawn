using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    //public InputField iNumOfWheels;
    //public InputField iNumOfPassengers;
    //public string NumberOfWheels;
    public int MovieGenres;
    public bool Gender;
    public bool Longer;
    public Image movie;
    //public string Passengers;
    //public bool Cargo;

    // Start is called before the first frame update
    void Start()
    {
        MovieGenres = Mathf.Max(MovieGenres, 1);
        //Gender = Mathf.Max(Gender, 1);
        //NumberOfWheels = iNumOfWheels.text;
        //Passengers = iNumOfPassengers.text;
        //Longer = Cargo;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private static IMovie GetVehicle(MovieRequirements requirements)
    {
        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }

    public void SpawnButton()
    {
        MovieRequirements requirements = new MovieRequirements();
        requirements.MovieGenres = MovieGenres;
        requirements.Longer = Longer;
        requirements.Gender = Gender;

        IMovie v = GetVehicle(requirements);
        Debug.Log(v);
        movie.sprite = v.AddMovie();
    }

    public void Genre (int movGenre)
    {
        if (movGenre == 0)
        {
            MovieGenres = 1;
        }

        if (movGenre == 1)
        {
            MovieGenres = 2;
        }

        if (movGenre == 2)
        {
            MovieGenres = 3;
        }

        if (movGenre == 3)
        {
            MovieGenres = 4;
        }


    }

    public void GenderChoice(int genChoice)
    {
        if (genChoice == 0)
        {
            Gender = true /*Woman*/ ;
        }

        if (genChoice == 1)
        {
            Gender = false /*Man*/;
        }
    }
    public void MovieDuration(int runtime)
    {
        if (runtime == 0) 
        { 
            Longer = true; 
        }
        if (runtime == 1)
        { 
            Longer = false; 
        }
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
