using UnityEngine;
using System.Collections;

public class RoadPart3 : PlotPart3
// 現状はつかってないぽい　道路も PlotPart3 使ってると思う　廃止予定？
{
	
	
	protected override bool fallDown( _StructureHit3 hitter, Vector3 force, Vector3 point )
	{

		//var tf = transform;


		//var smoke = (GameObject)Instantiate( GM.roadBreakPrefab, tf.position, GM.roadBreakPrefab.transform.rotation );

		//Destroy( smoke, 1.0f );

		
		fallDownDestructionSurface( hitter );


		return true;

	}

}
