using UnityEngine;

[CreateAssetMenu(fileName = "CarData.asset", menuName = "ScriptableObjects/Car")]
public class Car : ScriptableObject
{
    [SerializeField] private string carName; // نام ماشین
    [SerializeField] private float topSpeed; // سرعت نهایی
    [SerializeField] private float acceleration; // شتاب
    [SerializeField] private float handling; // هندلینگ
    [SerializeField] private float braking; // ترمز
    [SerializeField] private int gears; // دنده
    [SerializeField] private float fuelEconomy; // مصرف سوخت
   
    

    public string CarName { get { return carName; } }
    public float TopSpeed { get { return topSpeed; } }
    public float Acceleration { get { return acceleration; } }
    public float Handling { get { return handling; } }
    public float Braking { get { return braking; } }
    public int Gears { get { return gears; } }
    public float FuelEconomy { get { return fuelEconomy; } }
   
   
}
