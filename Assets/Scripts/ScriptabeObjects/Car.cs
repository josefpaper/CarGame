using UnityEngine;

[CreateAssetMenu(fileName = "CarData.asset", menuName = "ScriptableObjects/Car")]
public class Car : ScriptableObject
{
    

    [SerializeField] public float maxAcceleration = 30.0f;
    [SerializeField] public float brakeAcceleration = 50.0f;

    [SerializeField] public float turnSensitivity = 1.0f;
    [SerializeField] public float maxSteerAngle = 30.0f;

   
    public float MaxAcceleration { get { return maxAcceleration; } }
    public float BrakeAcceleration { get { return brakeAcceleration; } }
    public float TurnSensitivity { get { return turnSensitivity; } }
    public float NaxSteerAngle { get { return maxSteerAngle; } }
   
   
   
}
