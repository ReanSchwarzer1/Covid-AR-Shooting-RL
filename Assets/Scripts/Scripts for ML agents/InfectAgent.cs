using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class InfectAgent : Agent
{   
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Material winMaterial;
    [SerializeField] private Material loseMaterial;
    [SerializeField] private MeshRenderer floorMeshRenderer;


    public override void OnEpisodeBegin()
    {
        transform.localPosition=new Vector3(Random.Range(296f, -252f),(float)5.5,Random.Range(-238f,284f));
        targetTransform.localPosition=new Vector3(Random.Range(-11f,4f),(float)5.5,Random.Range(-1f,14f));

    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(targetTransform.localPosition);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX=actions.ContinuousActions[0];
        float moveZ=actions.ContinuousActions[1];

        float moveSpeed=10f;
        transform.localPosition+=new Vector3(moveX,0,moveZ)*Time.deltaTime*moveSpeed;
    }
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions=actionsOut.ContinuousActions;
        continuousActions[0]=Input.GetAxisRaw("Horizontal");
        continuousActions[1]=Input.GetAxisRaw("Vertical");

    }
    private void OnTriggerEnter(Collider other)
    {   
        if(other.TryGetComponent<Goal>(out Goal goal))
        {
            SetReward(+1f);
            floorMeshRenderer.material=winMaterial;
            EndEpisode();
        }
        if(other.TryGetComponent<Wall>(out Wall wall))
        {
            SetReward(-1f);
            floorMeshRenderer.material=loseMaterial;

            EndEpisode();
        }
    }
}
