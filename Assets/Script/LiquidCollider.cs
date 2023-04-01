using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Obi;

[RequireComponent(typeof(ObiSolver))]
public class LiquidCollider : MonoBehaviour
{
	ObiSolver solver;
	GlassController glassController;
	public int id;

	void Awake()
	{
		solver = GetComponent<Obi.ObiSolver>();
	}

	void OnEnable()
	{
		solver.OnCollision += Solver_OnCollision;
	}

	void OnDisable()
	{
		solver.OnCollision -= Solver_OnCollision;
	}

	void Solver_OnCollision(object sender, Obi.ObiSolver.ObiCollisionEventArgs e)
	{
		foreach (Oni.Contact contact in e.contacts)
		{
			if (contact.distance < 0.001f)
			{
				ObiColliderBase collider = ObiColliderWorld.GetInstance().colliderHandles[contact.bodyB].owner;


				if (collider.gameObject.tag == "Floor")
				{

					glassController = collider.GetComponent<GlassController>();
					//does something inside the gameobject colliding
					glassController.fillWithAlcohol(id);
				}

			}}
		}

}
