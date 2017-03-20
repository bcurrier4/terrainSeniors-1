using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	public int max;


	public class Enemy
	{
		public int walkingSpeed;

		[SerializeField]
		int health;


		public int getHealth()
		{

			return health;
		}


		public void SetHealth()
		{

			health = 100;

		}


		public void ReduceHealth(int amount)
		{

			health = health - amount;

		}

		public void OnDeath()
		{

			//health = health - amount;
			//reminder to

		}

	}



	class Zombie : Enemy
	{




	}






	public Enemy e1;
	int a;
	int b;
	bool c;
	public float d;

	// Use this for initialization
	void Start () {
		a = 10;
		b = 5;


		Enemy e1;
		e1 = new Enemy ();
		e1.SetHealth ();




		int e1Health = e1.getHealth ();


		Zombie z1;
		z1 = new Zombie ();





	}

	// Update is called once per frame
	void Update () {

		int product;
		int x = 5;
		int y = 6;

		//product = Product (x,y);

	}
}
